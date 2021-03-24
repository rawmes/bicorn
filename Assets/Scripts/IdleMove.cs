using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IdleMove : MonoBehaviour
{
    public float delayTime = 6f;
     
    public Transform player;
    public float mouseSensitivity = 6;
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
       
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((movementInput.y == 0f))
        {
            y += -lookInput.y;
            x += lookInput.x;
            x = Mathf.Clamp(x, 0, 30);
            player.transform.localRotation = Quaternion.Euler(0, y,0);
            //player.transform.localRotation = Quaternion.Euler(x, 0, 0);
        }
        if (!(movementInput.y == 0f))
        {
            //y = y - Time.deltaTime*delayTime;

            player.transform.localRotation = Quaternion.Euler(0, 0, 0);
            y = 0f;

        }
    }    
}
