using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagBounce : MonoBehaviour
{

    bool extended = false;

    Vector2 initialScale;

    public float extAmount = 1.0f;

    [SerializeField] private AudioClip clipMag;
    [SerializeField] private AudioClip clipRev;

    Vector3 transformable = Vector3.zero;

    GameObject trigger;

    // Start is called before the first frame update
    void Awake()
    {
        trigger = transform.GetChild(0).gameObject;

        initialScale.y = transform.localScale.y;
        initialScale.x = transform.localScale.x;

        transformable.y = extAmount;
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        Debug.Log("CLICKED THE FUCKER");
        if (extended == false)
        {
            AudioManager.instance.playLoudSound(clipMag);
            transform.localScale += transformable;
            trigger.transform.localScale += transformable;
            extended = true;
        }
        else
        {
            AudioManager.instance.playLoudSound(clipRev);
            transform.localScale = initialScale;
            trigger.transform.localScale = initialScale;
            extended = false;
        }
    }
}
