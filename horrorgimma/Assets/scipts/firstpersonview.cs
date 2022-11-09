using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstpersonview : MonoBehaviour
{
    [SerializeField] Transform playercamera = null;
    [SerializeField] float mousesens = 1.5f;
    [SerializeField] float walkspeed = 2.0f;   

    [SerializeField] bool verstopmuis = true;

    CharacterController controller = null;

    float camerapitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        if (verstopmuis)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        updatemouselock();
    }

    void updatemouselock()
    {
        Vector2 mousedelta = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));

        camerapitch += mousedelta.x * mousesens;

        camerapitch = Mathf.Clamp(camerapitch, -90.0f, 90.0f);

        playercamera.localEulerAngles = Vector3.right * camerapitch;
       

        transform.Rotate(Vector3.up * mousedelta * mousesens);
    }

    void updatemovement()
    {
        Vector2 inputdir = new Vector2(Input.GetAxisRaw("horizontal"), Input.GetAxisRaw("vertical"));
        inputdir.Normalize();

        Vector3 velocity = (transform.forward * inputdir.x + transform.right * inputdir.y) * walkspeed;

        controller.Move(velocity * Time.deltaTime);
    }
}
