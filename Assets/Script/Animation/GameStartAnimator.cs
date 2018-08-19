using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : SingletonMonoBehaviour<GameStartAnimator> {

    private Animator gameStartAnimator;

    private void Awake()
    {
        gameStartAnimator = GetComponent<Animator>();
    }

    //public void startGameAnimation()
    //{
    //    //gameStartAnimator.SetBool("gameStart", true);
    //}

    //public void readyStartAnimation()
    //{
    //    gameStartAnimator.SetBool("gameStart", false);
    //}

    public void startGame()
    {
        PlayerStateManager.Instance.isPlayingMethod();
    }

    public void playStartAnimation()
    {
        //gameStartAnimator.Play("GameStart");
    }

}