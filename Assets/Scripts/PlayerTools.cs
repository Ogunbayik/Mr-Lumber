using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTools : MonoBehaviour
{
    [SerializeField] private GameObject[] tools;

    private enum States
    {
        Carrying,
        Cutting,
        Minning
    }

    [SerializeField] private States currentState;


    private int toolIndex = 0;

    void Start()
    {
        tools[toolIndex].SetActive(true);
        currentState = States.Carrying;
    }

    void Update()
    {
        switch(toolIndex)
        {
            case 0: currentState = States.Carrying;
                break;
            case 1: currentState = States.Cutting;
                break;
            case 2: currentState = States.Minning;
                break;
        }

        ChangeTool();
    }

    private void ChangeTool()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tools[toolIndex].SetActive(false);
            toolIndex++;

            if (toolIndex >= tools.Length)
                toolIndex = 0;

            tools[toolIndex].SetActive(true);
        }
    }


}
