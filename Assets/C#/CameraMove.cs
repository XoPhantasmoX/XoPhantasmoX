using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePosOnScreen = new Vector3( 0f, Input.mousePosition.y, transform.position.z);
            Vector3 mousePosInWorld = Camera.main.ScreenToWorldPoint(mousePosOnScreen);
            transform.position = new Vector3( 0f, Input.mousePosition.y, transform.position.z);
        }
    }
}
