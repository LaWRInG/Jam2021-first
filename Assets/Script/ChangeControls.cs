using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeControls : MonoBehaviour
{
    PlayerInput control;

    private enum mode { WASD, Arrow }

    [SerializeField] private mode Mode;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            control = collision.gameObject.GetComponent<PlayerInput>();
        
            switch (Mode)
            {
            case mode.WASD:
                    control.actions.FindActionMap("Normal").Disable();
                    control.actions.FindActionMap("Swicth").Enable();
                break;
            case mode.Arrow:
                    control.actions.FindActionMap("Swicth").Disable();
                    control.actions.FindActionMap("Normal").Enable();
                break;
            default:
                    control.actions.FindActionMap("Normal").Disable();
                    control.actions.FindActionMap("Swicth").Enable();
                break;
            }
        }
    }


}
