using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //vars are dumb
    public GameObject obj;
    public Rigidbody rb2;
    Animator animator;
    private int walkCheckHash;
    private int idleCheckHash;
    private int runCheckHash;
    private int lookBackCheckHash;
    private bool notTrue = false;
    public float magnitudeCheck;
    private bool runCheck;


    // Start is called before the first frame update
    void Start()
    {
        //Boooo
        animator = GetComponent<Animator>();
        walkCheckHash = Animator.StringToHash("isWalking");
        idleCheckHash = Animator.StringToHash("isIdle");
        runCheckHash = Animator.StringToHash("isRunning");
        lookBackCheckHash = Animator.StringToHash("isLookingBack");
        rb2 = obj.GetComponent<Rigidbody>();


        

        
    }

    // Update is called once per frame
    void Update()
    {
        runCheck = false;
        animator.SetBool(runCheckHash, false);
        

        // checking for w pressed down
        bool walkCheck = Input.GetKey("w");
        bool isAlreadyWalking = animator.GetBool(walkCheckHash);

        //checking for Lshift
        runCheck = Input.GetKey(KeyCode.LeftShift);
        bool isAlreadyRunning = animator.GetBool(runCheckHash);

        //check for backpress as in "s"
        bool backCheck = Input.GetKey("s");
        bool isAlreadyLookingBack = animator.GetBool(lookBackCheckHash);

        



        //  making walk true
        if (!isAlreadyWalking && walkCheck)
        {
            
            if (runCheck)
            {
                /*
                animator.SetBool(runCheckHash, true);
                animator.SetBool(walkCheckHash, false);
                animator.SetBool(idleCheckHash, false);
                */
            }
            else
            {
                animator.SetBool(walkCheckHash, true);
                animator.SetBool(idleCheckHash, false);
                animator.SetBool(runCheckHash, false);

            }

        }

        //making idle true
        if(!walkCheck && isAlreadyWalking)
        {
            animator.SetBool(idleCheckHash, true);
            animator.SetBool(walkCheckHash, false);
            animator.SetBool(runCheckHash, false);

        }
       


        //make look back true
        if (backCheck)
        {
            animator.SetBool(lookBackCheckHash, true);
        }
        else
        {
            animator.SetBool(lookBackCheckHash, false);
        }
        //make it run of velocity is greater than magitued
        magnitudeCheck = rb2.velocity.magnitude;
        if (runCheck)
        {
            
            if ((magnitudeCheck >= 0.06))
            {
                animator.SetBool(runCheckHash, true);
                animator.SetBool(walkCheckHash, false);
                animator.SetBool(idleCheckHash, false);

            }
            else
            {
                animator.SetBool(runCheckHash, false);
                animator.SetBool(walkCheckHash, false);
                animator.SetBool(idleCheckHash, true);

            }

        }
    }
}
