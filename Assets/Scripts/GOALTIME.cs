using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOALTIME : MonoBehaviour
{
    public string nextScene;
    [SerializeField] private AudioClip clip;

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
            AudioManager.instance.playSound(clip);  
            SceneManager.LoadScene(nextScene);
        }
    }
}
