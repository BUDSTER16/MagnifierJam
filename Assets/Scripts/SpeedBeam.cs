using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBeam : MonoBehaviour
{

    public bool fast = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Vector3 boost = new Vector3(150, 0, 0);
            Debug.Log("vroom");
            Rigidbody2D playerRB = other.gameObject.GetComponent<Rigidbody2D>();

            if (fast)
            {
                playerRB.AddForce(boost, ForceMode2D.Force);
            }
            else
            {
                playerRB.AddForce(-boost, ForceMode2D.Force);
            }
            
        }
    }

    private void OnMouseDown()
    {
        if(fast)
        {
            fast = false;
        }
        else
        {
            fast = true;
        }
    }
}
