using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float delayTime = 6;
    public float mouseSensitivity = 6;
    public Vector2 lookInput;
    public Vector2 movementInput;

    //private float x = 0;
    private float y = 0;

    PlayerMovement playerControls;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerMovement();
            playerControls.Movement.walk.performed += context => movementInput = context.ReadValue<Vector2>();

            playerControls.Movement.look.performed += context => lookInput = context.ReadValue<Vector2>();
            playerControls.Enable();
        }
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //input
        //x += lookInput.x;
        
        //Debug.Log(lookInput);
        //clamping the inputs
        //x= Mathf.Clamp(x, -90, 90);
        //y = Mathf.Clamp(y,)
        // y = Mathf.Clamp(y)

        //rotation 
        //player.transform.localRotation = Quaternion.Euler(x, 0, 0);
        if(!( movementInput.y == 0f))
        {
            y += -lookInput.y;
            player.transform.localRotation = Quaternion.Euler(0, y, 0);
        }
       /* if ((movementInput.y == 0f))
        {
            y = y - Time.deltaTime * delayTime;
            player.transform.localRotation = Quaternion.Euler(0, y, 0);

        }*/
    }





    //unlock the camera from the window



}

