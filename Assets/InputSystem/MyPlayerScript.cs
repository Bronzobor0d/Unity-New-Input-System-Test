using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyPlayerScript : MonoBehaviour
{
    PlayerInput playerInput;



    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        //InputSystem.actions.Disable();
        playerInput.currentActionMap?.Enable();
    }
}
