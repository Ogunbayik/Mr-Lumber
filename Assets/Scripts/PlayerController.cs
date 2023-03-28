using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerAnimation animator;


    [SerializeField] private GameInput gameInput;

    [SerializeField] private float movementSpeed;
    private Vector3 movementDirection;

    private bool isRun;

    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        var inputVector = gameInput.GetInputVectorNormalized();
        movementDirection = new Vector3(inputVector.x, 0f, inputVector.y);

        if(movementDirection.magnitude != 0)
        {
            isRun = true;
        }
        else
        {
            isRun = false;
            animator.RunAnimation(false);
        }

        if(isRun)
        {
            animator.RunAnimation(true);
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
        }
    }

}
