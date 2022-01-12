using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Lines : MonoBehaviour
{
    private LineRenderer lineRend;
    private Vector2 mousePos;
    private Vector2 startMousePos;


    // Start is called before the first frame update
    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //lineRend.SetPosition(0, new Vector3(startMousePos.x, startMousePos.y, 1.0f));
            //lineRend.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 10.0f));
            lineRend.SetPosition(0, new Vector3(10, 10, 10.0f));
            lineRend.SetPosition(1, new Vector3(11, 12, 10.0f));
        }
            
    }
}
