using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    private PlayerMovement cursorState;
    private float buttonInput;
    private bool look;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
    private void Awake()
    {
       
    }
    private void OnEnable()
    {
        if (cursorState == null)
        {
            cursorState= new PlayerMovement();
            cursorState.UserInterface.cursorLock.performed += context => buttonInput = context.ReadValue<float>();

           
            cursorState.Enable();
        }
    }
    private void OnDisable()
    {
        cursorState.Disable();
    }
    private void Update()
    {
        Debug.Log(buttonInput);
        if(buttonInput != 0f)
        {
            Cursor.lockState=CursorLockMode.None;
        }
    }
    
}
