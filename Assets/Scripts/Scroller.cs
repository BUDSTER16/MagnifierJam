using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Scroller : MonoBehaviour
{

    [SerializeField] private RawImage _img;
    [SerializeField] private float x, y;

    public Transform camera;

    // Update is called once per frame
    void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(x, y) * Time.deltaTime, _img.uvRect.size);
        transform.position = camera.transform.position + new Vector3(0, 0, 5);

    }
}
