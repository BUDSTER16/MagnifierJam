using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolveIt : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 15;
    public ContactFilter2D contactfilter;
    Vector2 dir = new Vector2(1,-1.5f);
    float headHeight = 0.5f;

    Vector3 movement = new Vector3(0, 0, 0);
    Vector3 yump = new Vector3(0, 0.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 head = transform.position;
        Vector3 dirTest = new Vector3(transform.position.x, transform.position.y, 1);
        head.y += headHeight;
        LayerMask mask = LayerMask.GetMask("Terrain");
        RaycastHit2D lookAhead = Physics2D.Raycast(head, dir, 2, mask);
        Debug.DrawRay(head, dir, Color.red, 0, false);
        RaycastHit2D onGround = Physics2D.Raycast(transform.position, -Vector2.up, 0.6f, mask);
        Debug.DrawRay(dirTest, -Vector2.up, Color.green, 0, false);

        movement.x = speed;

        rb.AddForce(movement, ForceMode2D.Force);

        if (lookAhead.collider == null && onGround.collider != null)
        {
            rb.AddForce(yump, ForceMode2D.Impulse);
        }
    }
}
