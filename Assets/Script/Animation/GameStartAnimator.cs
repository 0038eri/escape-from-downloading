using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : MonoBehaviour {

    private Animator gameStartAnimator;
    private GameObject playerManager;

    private void Awake()
    {
        gameStartAnimator = GetComponent<Animator>();
    }

    public void startGameAnimation()
    {
        gameStartAnimator.SetBool("gameStart", true);
    }

    public void readyStartAnimation()
    {
        gameStartAnimator.SetBool("gameStart", false);
    }

    public void startGame()
    {
        playerManager.SendMessage("isPlayingMethod");
    } 

}