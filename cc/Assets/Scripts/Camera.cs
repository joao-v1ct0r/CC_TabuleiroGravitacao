using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [Header("Config")]
    [Range(1.0f, 10.0f)] public float sensibility = 2.0f;
    [Range(0.0f, 1.0f)] public float smooth = 0.005f;

    //privates
    float mY;
    float mX;

    float smoothRotX;
    float smoothRotY;

    void Start()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        mX -= Input.GetAxis("Mouse Y") * sensibility * 50 * Time.deltaTime;
        mY += Input.GetAxis("Mouse X") * sensibility * 50 * Time.deltaTime;

        smoothRotX = Mathf.Lerp(smoothRotX, mX, smooth);
        smoothRotY = Mathf.Lerp(smoothRotX, mY, smooth);

        transform.eulerAngles = new Vector3(mX, mY, 0);
    }

}
