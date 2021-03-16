using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // variables are stupid
    private Rigidbody rb;
    private float groundOffsetChecker=0.4f;
    public LayerMask layermask;
    public float walkSpeed = 6;
    public float runSpeed = 10;
    public float jumpforce = 6;
    public bool runToggle = false;
    public float MoveSpeed;
    private float jumpforce2;
    public bool Grounded;
    private bool slow;
    

    // Start is called before the first frame update
    void Start()
    {
        // wheeeee get nae naed
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        slow = false;
        float vel = rb.velocity.magnitude;
        //running
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            runToggle = !runToggle;

        }
        if (runToggle)
        {
            MoveSpeed = runSpeed;

            
            jumpforce2 = jumpforce + 0.1f*vel;
           

        
            
        }
        else
        {
            MoveSpeed = walkSpeed;
            jumpforce2 = jumpforce + 0.1f*vel ;
        }

        //inputs

        float x = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        float y = Input.GetAxisRaw("Vertical") * MoveSpeed;

        //grounded check
        Grounded = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y-1, transform.position.z), groundOffsetChecker, layermask);
        
        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && Grounded) 
             rb.velocity = new Vector3(rb.velocity.x, jumpforce2, rb.velocity.y);



        //moving here
        if (Input.GetKey(KeyCode.A))
            slow = true;
        if (Input.GetKey(KeyCode.D))
            slow = true;
        if (Input.GetKey(KeyCode.S))
            slow = true;
        
        if (slow)
            MoveSpeed = walkSpeed-1;



        // moving herE

        //MAYBE UNCOMMENT IF I FIGURE OUT RIGIDBODY MOVEMENT 
        /*
        rb.velocity = new Vector3(x, rb.velocity.y, y)*MoveSpeed;
        */
      
        //using transform because u are a pussy
        Vector3 movePosition = transform.right * x + transform.forward * y;
        Vector3 newMovePosition = new Vector3(movePosition.x, rb.velocity.y, movePosition.z);
            rb.velocity = newMovePosition;
        

    }
    private void FixedUpdate()
    {
        //wtf is this doing here.. gtfo ... shit.. dont delete.. looks like a correction code
        
        Vector3 oldPos = rb.position;
        rb.position += Vector3.back * MoveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(oldPos);
        


    }
}
