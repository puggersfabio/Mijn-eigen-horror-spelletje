using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaron : MonoBehaviour
{
    public Transform player;

    public float MousSensitivity = 0.9f;

    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //input
        x += -Input.GetAxis("Mouse Y") * MousSensitivity;
        y += Input.GetAxis("Mouse X") * MousSensitivity;

        //clamping
        x = Mathf.Clamp(x, -90, 90);

        //rotation
        transform.localRotation = Quaternion.Euler(x, 0, 0);
        player.transform.localRotation = Quaternion.Euler(0, y, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }

            if (Cursor.lockState == CursorLockMode.None)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

}
