using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputAction;

    private Vector2 inputVector;
    void Start()
    {
        playerInputAction = new PlayerInputActions();
        playerInputAction.Player.Enable();
    }

    public Vector2 GetInputVectorNormalized()
    {
        inputVector = playerInputAction.Player.Movement.ReadValue<Vector2>();

        inputVector = inputVector.normalized;
        return inputVector;
    }

}
