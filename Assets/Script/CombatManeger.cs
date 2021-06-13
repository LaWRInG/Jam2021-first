using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CombatManeger : MonoBehaviour
{
    public static CombatManeger ins;

    public Animator anim;

    public bool canReceiveInput = true;

    public bool inputReceived;

    // Start is called before the first frame update
    void Awake()
    {
        ins = this;
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackR(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("yes");
            if (canReceiveInput == true)
            {
                Debug.Log("Receive");
                inputReceived = true;
                canReceiveInput = false;
            }
            else
            {
                return;
            }
        }
    }

    public void InputManager()
    {
        if (!canReceiveInput)
        {
            canReceiveInput = true;
        }
        else
        {
            canReceiveInput = false;
        }
    }
}
