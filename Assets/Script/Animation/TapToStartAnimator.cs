using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToStartAnimator : MonoBehaviour {

    private Animator thisAnimator;

    private void Awake()
    {
        thisAnimator = GetComponent<Animator>();
    }

    public void animatorBool()
    {
        thisAnimator.SetBool("tapToStart", false);
    }

}