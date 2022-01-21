using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    RectTransform canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;
    public Transform myObj;

    void Start()
    {
        button = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("CanvasLab").GetComponent<RectTransform>();
        startingPosition = transform.position;
        int xcount = Random.Range(3, 11);
        speed = xcount;
    }

    void FixedUpdate()
    {
        if (transform.position.y < 300) {
            transform.Rotate (180, 0, 0, Space.World);
        }
        if (transform.position.y > 775)
        {
            transform.Rotate(180, 0, 0, Space.World);
        }
        transform.Translate(0f, speed, 0f);
        if (button.position.y < -button.rect.height)
            transform.position = new Vector3(startingPosition.x, canvas.rect.height + button.rect.height, startingPosition.z);
    }
}