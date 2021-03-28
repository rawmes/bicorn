using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(CharacterController))]

public class PlayerMove : MonoBehaviour
{

    //private PlayerMovement movementControl;
    PlayerMovement playerControls;
    public Transform player;
    private float walkSpeed = 0.6f;
    public float jumpForce = 10f;
    private float jumpForceProxy;
    public LayerMask layerMask;
    public float groundOffset= 0.01f;
    public bool groundedPlayer;
    public Rigidbody rb;

    public Vector2 movementInput;
    public float jumpControl;
    public Vector2 lookControl;
    
    private CharacterController Controller;

    private Vector2 walkInput;
    private float sprintInput;
    private Vector2 lookInput;
    private Vector3 playerVelocity;
    private Transform CameraTransform;
    private float moveSpeed;
    private bool jumpPressed = false;
    
    
   
    public float jumpInput;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerMovement();
            playerControls.Movement.walk.performed += context => movementInput = context.ReadValue<Vector2>();
            
            playerControls.Movement.look.performed += context => lookInput = context.ReadValue<Vector2>();
            playerControls.Movement.jump.performed += context => jumpInput = context.ReadValue<float>();
            playerControls.Movement.run.performed += context => sprintInput = context.ReadValue<float>();
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
       //    Controller = gameObject.GetComponent<CharacterController>();
        //movementControl = movementControl.action.performed += ctx => onWalk(ctx);
        CameraTransform = Camera.main.transform;
        rb = gameObject.GetComponent<Rigidbody>();

        
    }
    //enable / diable the action maps


    // Update is called once per frame
    void Update()
    {

        // giving movespeed and jumpspeed here

        if (movementInput != new Vector2(0f, 0f) && sprintInput != 0f)
        {
            moveSpeed = walkSpeed + 1;
            jumpForceProxy = jumpForce*10f;
        }
        else
        {
            moveSpeed = walkSpeed;
            jumpForceProxy = jumpForce*5f;
        }

        //moving the character here
        Vector3 movePosition = transform.right * movementInput.x*moveSpeed + transform.forward * movementInput.y*moveSpeed;
        Vector3 newMovePosition = new Vector3(movePosition.x, rb.velocity.y, movePosition.z);
        rb.velocity = newMovePosition;


        // checking if player is grounded
        groundedPlayer = Physics.CheckSphere(player.position, groundOffset, layerMask);

        //jumping if grounded and jumpinput is triggerd else jump input is discarded.
        if (jumpInput == 1f && groundedPlayer)
        {
            //Debug.Log(jumpPressed);
            if (jumpPressed)
            {
                rb.AddForce(0, jumpForceProxy, 0);

                Debug.Log("jumpVelocity");
                
                Debug.Log(jumpForceProxy);
                jumpPressed = false;


            }
            jumpPressed =false;
           

        }
        else
        {
            jumpPressed =true;
        }

        //stopping the player completely if the move key is released except for the vertical velocity which will be taken care by gravity
        
        if (movementInput == new Vector2(0f, 0f))
        {
            
            rb.velocity = new Vector3(0f, rb.velocity.y, 0f);

        }
        else
        {
           // Debug.Log(rb.velocity);

        }
        
        
    }
   
}
