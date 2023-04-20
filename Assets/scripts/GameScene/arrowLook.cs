using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowLook : MonoBehaviour
{
    private Camera Cam;
    private GameManager _GameManager;

    private bool locked = false;

    void Start()
    {
        Cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        _GameManager = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0) && !locked)
        {
            Look();
        } else if (Input.GetMouseButtonUp(0) && !locked) 
        {
            _GameManager.StartCoroutine("incBall");
            locked = true;
        }
    }

    void Look() 
    {
        Vector3 camPos = Cam.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(new Vector3(camPos.x, camPos.y, 0f));
    }
}
