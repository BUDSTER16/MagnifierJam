using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class MagnifyBlock : MonoBehaviour
{
    bool extended = false;
    public bool verticallyScaling = true;
    public float extAmount = 1.0f;

    [SerializeField] private AudioClip clipMag;
    [SerializeField] private AudioClip clipRev;

    Vector2 initialScale;

    Vector3 transformable = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        initialScale.y = transform.localScale.y;
        initialScale.x = transform.localScale.x;

        if (verticallyScaling == true)
        {
            transformable.y = extAmount;
        }else
        {
            transformable.x = extAmount;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(extended == false)
        {
            AudioManager.instance.playLoudSound(clipMag);
            transform.localScale += transformable;
            extended = true;
        }else
        {
            AudioManager.instance.playLoudSound(clipRev);
            transform.localScale = initialScale;
            extended = false;
        }
    }
}
