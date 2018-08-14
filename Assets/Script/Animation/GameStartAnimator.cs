using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : MonoBehaviour {

    private Animator gameStartAnimator;
    private GameObject gameStartCanvas;

    private GameObject playerManager;

    void Awake()
    {
        gameStartAnimator = GetComponent<Animator>();
        playerManager = GameObject.Find("PlayerManager");
    }

    public void gameStartAnimation()
    {
        gameStartAnimator.enabled = true;
        //gameStartAnimator.Play("GameStart");
    }

    public void notGameStartAnimation()
    {
        gameStartAnimator.enabled = false;
    }

    public void startGame()
    {
        playerManager.SendMessage("isPlayingMethod");
    } 

}