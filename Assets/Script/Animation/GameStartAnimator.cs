using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : SingletonMonoBehaviour<GameStartAnimator> {

    private Animator gameStartAnimator;

    private void Awake()
    {
        gameStartAnimator = GetComponent<Animator>();
    }

    public void startGame()
    {
        PlayerStateManager.Instance.isPlayingMethod();
    }

    public void finishedGame()
    {
        gameStartAnimator.SetBool("judgeFlag", true);
    }

}