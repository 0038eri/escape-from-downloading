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
        gameStartCanvas = GameObject.Find("GameStartCanvas");
        playerManager = GameObject.Find("PlayerManager");
    }

    public void gameStartAnimation()
    {
        gameStartCanvas.SetActive(true);
        gameStartAnimator.enabled = true;
        //gameStartAnimator.Play("GameStart");
    }

    public void notGameStartAnimation()
    {
        gameStartCanvas.SetActive(false);
        gameStartAnimator.enabled = false;
    }

    public void startGame()
    {
        playerManager.SendMessage("isPlayingMethod");
    } 

}