using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = .75f;
    public float minZoom = 3;
    public float maxZoom = 20;

    private void Update()
    {
        UpdateCameraMovement();
    }
    void UpdateCameraMovement()
    {
        var axisH = Input.GetAxis("Horizontal");
        var axisV = Input.GetAxis("Vertical");
        var zoom = Input.GetAxis("Mouse ScrollWheel");

        Camera.main.transform.Translate(new Vector3(axisH, 0, axisV) * speed, Space.World);
        Camera.main.transform.Translate(new Vector3(0, -zoom * 5, 0) * speed, Space.Self);
        //Camera.main.orthographicSize -= Camera.main.orthographicSize * zoom);
        //Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom);
    }

}
