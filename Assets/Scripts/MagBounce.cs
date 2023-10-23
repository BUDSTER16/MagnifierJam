using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagBounce : MagnifyBlock
{

    bool extended = false;

    Vector2 initialScale;

    Vector3 transformable = Vector3.zero;

    GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GameObject.Find("JUMPER");

        initialScale.y = transform.localScale.y;
        initialScale.x = transform.localScale.x;

        if (verticallyScaling == true)
        {
            transformable.y = extAmount;
        }
        else
        {
            transformable.x = extAmount;
        }
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        if (extended == false)
        {
            transform.localScale += transformable;
            trigger.transform.localScale += transformable;
            extended = true;
        }
        else
        {
            transform.localScale = initialScale;
            trigger.transform.localScale = initialScale;
            extended = false;
        }
    }
}
