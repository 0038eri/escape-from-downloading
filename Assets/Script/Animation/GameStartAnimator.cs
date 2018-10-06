using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : SingletonMonoBehaviour<GameStartAnimator> {

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    public void trueAnimation()
    {
        animator.enabled = true;
    }

    public void falseAnimation()
    {
        animator.enabled = false;
    }

    public void startGame()
    {
        PlayerStateManager.Instance.isPlayingMethod();
    }

}