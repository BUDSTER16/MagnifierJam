using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BOUNCY : MonoBehaviour
{
    Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerRB = other.gameObject.GetComponent<Rigidbody2D>();
            Debug.Log("BOING");
            Vector3 boing = new Vector3(0, 10);
            playerRB.AddForce(boing, ForceMode2D.Impulse);
        }
    }
}
