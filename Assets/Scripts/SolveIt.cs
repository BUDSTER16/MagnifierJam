using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SolveIt : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
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
        Vector3 head = this.transform.position;
        Vector3 dirTest = new Vector3(this.transform.position.x, this.transform.position.y, 1);
        head.y += headHeight;

        Vector3 foot = this.transform.position;
        foot.y -= headHeight - 0.25f;

        LayerMask mask = LayerMask.GetMask("Terrain");

        RaycastHit2D obstacle = Physics2D.Raycast(foot, Vector2.right, 1, mask);
        Debug.DrawRay(foot, Vector2.right, Color.magenta, 0, false);


        RaycastHit2D lookAhead = Physics2D.Raycast(head, dir, 2, mask);
        Debug.DrawRay(head, dir, Color.red, 0, false);

        RaycastHit2D onGround = Physics2D.Raycast(this.transform.position, -Vector2.up, 0.6f, mask);
        Debug.DrawRay(dirTest, -Vector2.up, Color.green, 0, false);

        movement.x = speed;

        if (obstacle.collider == null)
        {
            rb.AddForce(movement, ForceMode2D.Force);
        }
        else if(onGround.collider != null)
        {
            rb.velocity = Vector2.zero;
        }
        
        if (lookAhead.collider == null && onGround.collider != null)
        {
            rb.AddForce(yump, ForceMode2D.Impulse);
        }

        if (obstacle.collider == null && rb.velocity.magnitude == 0)
        {
            Debug.Log("GIVING A PUSH");
            Vector3 push = new Vector3(1,1,0);
            rb.AddForce(push, ForceMode2D.Impulse);
        }else if(rb.velocity.magnitude == 0)
        {
            Debug.Log("SMTH IN FRONT, IM STOPPED");
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
