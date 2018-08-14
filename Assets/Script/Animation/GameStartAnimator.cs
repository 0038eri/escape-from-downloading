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
        
    }

    public void notGameStartAnimation()
    {
        
    }

    public void startGame()
    {
        playerManager.SendMessage("isPlayingMethod");
    } 

}