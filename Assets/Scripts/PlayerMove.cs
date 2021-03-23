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
    private float walkSpeed = 1f;
    public float jumpHeight = 1f;
    public LayerMask layerMask;
    public float groundOffset= 0.1f;
    public bool groundedPlayer;

    public Vector2 movementInput;
    public float jumpControl;
    public Vector2 lookControl;
    
    private CharacterController Controller;

    private Vector2 walkInput;
    private float sprintInput;
    private Vector2 lookInput;
    private Vector3 playerVelocity;
    private Transform CameraTransform;
    private Rigidbody rb;
   
    private float jumpInput;

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
       //    Controller = gameObject.GetComponent<CharacterController>();
        //movementControl = movementControl.action.performed += ctx => onWalk(ctx);
        CameraTransform = Camera.main.transform;
        rb = gameObject.GetComponent<Rigidbody>();

        
    }
    //enable / diable the action maps


    // Update is called once per frame
    void Update()
    {
        
        Vector3 movePosition = transform.right * movementInput.x + transform.forward * movementInput.y*walkSpeed;
        Vector3 newMovePosition = new Vector3(movePosition.x, rb.velocity.y, movePosition.z);
        
        rb.velocity = newMovePosition;
        if(movementInput == new Vector2(0f, 0f))
        {
            rb.velocity = new Vector3(0f,rb.velocity.y,0f);
        }
    }
    public void onWalk(InputAction.CallbackContext context)
    {
        walkInput = context.ReadValue<Vector2>();
        float x = walkInput.x;
        float y = walkInput.y;
        Debug.Log("walk");
        Debug.Log(x);
        Debug.Log(y);
    }
    public void onSprint(InputAction.CallbackContext context)
    {
        sprintInput = context.ReadValue<float>();
        Debug.Log("run");
        Debug.Log(sprintInput);
        
    }
    public void onJump(InputAction.CallbackContext context)
    {
        jumpInput = context.ReadValue<float>();
        Debug.Log("run");
        Debug.Log(jumpInput);
    }
    public void onRam(InputAction.CallbackContext context)
    {
        Debug.Log("HIT IT!!");
    }
}
