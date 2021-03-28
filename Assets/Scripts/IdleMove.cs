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
    public float z = 0;
    public float scrollInput;

    PlayerMovement playerControls;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerMovement();
            playerControls.Movement.walk.performed += context => movementInput = context.ReadValue<Vector2>();
            playerControls.Movement.scrollY.performed += context => scrollInput = context.ReadValue<float>();

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
        if (scrollInput != 0)
        {
            float zz = scrollInput / 120; 
            Debug.Log(zz);
            Vector3 oldPos = player.transform.localPosition;
            if (scrollInput < 0)
                z += 0.01f;
            if (scrollInput > 0)
                z += -0.01f;
            z = Mathf.Clamp(z, 0.08F, -0.08f);
            Vector3 newPos = new Vector3(oldPos.x, oldPos.y, z);
            player.transform.localPosition = newPos;
           
        }
        y += -lookInput.y * 0.022f * mouseSensitivity;
        y = Mathf.Clamp(y, 0, 30);

        if ((movementInput.y == 0f))
        {
            
            x += lookInput.x * 0.022f * mouseSensitivity;
            
            player.transform.localRotation = Quaternion.Euler(y, x,0);
            //player.transform.localRotation = Quaternion.Euler(y, 0, 0);
            //player.transform.localRotation = Quaternion.Euler(x, 0, 0);
        }
        if (!(movementInput.y == 0f))
        {
            //y = y - Time.deltaTime*delayTime;
            
            
            player.transform.localRotation = Quaternion.Euler(y, 0, 0);
            x = 0f;
            //  Debug.Log(player.transform.localRotation);

        }
    }    
}
