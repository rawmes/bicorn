using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //vars are not dum
    //public GameObject referenceObj;
    public GameObject obj;
    //public Rigidbody rb;
    Animator animator;
    private int walkCheckHash;
    public bool walkCheckHash2;
    PlayerMove move;
    public float counter;
    



    void Start()
    {
        //get value from playercontrols


        //get animator component form gameobj and start hashing actions
        animator = GetComponent<Animator>();
        walkCheckHash = Animator.StringToHash("isWalking");

        //get rigidbody cus why not and f u
        //rb = obj.GetComponent<Rigidbody>();

        //get script from player
        move = obj.GetComponent<PlayerMove>();
       


    }

    // Update is called once per frame
    void Update()
    {
        //get the movement state from the player move script
        walkCheckHash2 = move.moving;

        //get the movement state from animator component
        bool isAlreadyWalking = animator.GetBool(walkCheckHash);

        //make it go brrrrr or sssss or whatever
        if (walkCheckHash2)
        {
            animator.SetBool(walkCheckHash, true);
            counter = 0f;
        }
        else
        {
            float delaytime = 0.25f;                        // here lies the delay time for animation
            counter += 0.01f;
            if (counter > delaytime)
            {
                //Debug.Log("triggered");
                counter = 0f;
                animator.SetBool(walkCheckHash, false);

            }
            
        }

        
        
    }
}
