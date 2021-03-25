using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float delayTime = 6;
    public float mouseSensitivity = 3;
    public Vector2 lookInput;
    public Vector2 movementInput;

    private float x = 0;
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
        //look around when walking
        if (!(movementInput.y == 0f))
        {
            x = y;
            y += -lookInput.y*mouseSensitivity;

            //x = Mathf.Clamp(x, -45, 45);
            Mathf.Lerp(y, x, Time.deltaTime);
            player.transform.localRotation = Quaternion.Euler(0f, y , 0f);
            
        }
    }
  




    //unlock the camera from the window



}

