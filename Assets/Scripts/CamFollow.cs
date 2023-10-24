using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform camera;

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.transform.position + new Vector3(0, 0, 5);
    }
}
