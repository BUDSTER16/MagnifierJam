using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBeam : MonoBehaviour
{

    public bool fast = false;

    public Sprite speedUp;
    public Sprite speedDown;

    [SerializeField] private AudioClip clipRev;

    SpriteRenderer objectSprite;

    // Start is called before the first frame update
    void Start()
    {
        objectSprite= GetComponent<SpriteRenderer>();

        if (fast)
        {
            objectSprite.sprite = speedUp;
        }
        else
        {
            objectSprite.sprite = speedDown;
        }
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
            Rigidbody2D playerRB = other.gameObject.GetComponent<Rigidbody2D>();

            if (fast)
            {
                playerRB.AddForce(boost, ForceMode2D.Force);
                Debug.Log("vroom");
            }
            else if (playerRB.velocity.magnitude >= 10)
            {
                playerRB.AddForce(-boost * 4f, ForceMode2D.Force);
                Debug.Log("SLOW AS FUCK");
            }
            else
            {
                playerRB.AddForce(-boost * 1.5f, ForceMode2D.Force);
                Debug.Log("SLOWED");
            }
            
        }
    }

    private void OnMouseDown()
    {
        if(fast)
        {
            fast = false;
            objectSprite.sprite = speedDown;
            AudioManager.instance.playLoudSound(clipRev);
        }
        else
        {
            fast = true;
            objectSprite.sprite = speedUp;
        }
    }
}
