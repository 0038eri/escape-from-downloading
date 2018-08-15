using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToStartAnimator : MonoBehaviour {

    private Animator thisAnimator;
    private AnimatorStateInfo thisAnimatorState;

    private void Awake()
    {
        thisAnimator = GetComponent<Animator>();
        thisAnimatorState = thisAnimator.GetCurrentAnimatorStateInfo(0);
    }

    private void Start()
    {
        thisAnimator.Play(thisAnimatorState.fullPathHash, 0, 0.0f); 
    }

}