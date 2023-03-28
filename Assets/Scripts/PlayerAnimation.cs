using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private const string PLAYER_RUN_ANIMATOR_PARAMETER = "isRun";


    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void RunAnimation(bool isRun)
    {
        animator.SetBool(PLAYER_RUN_ANIMATOR_PARAMETER, isRun);
    }

}
