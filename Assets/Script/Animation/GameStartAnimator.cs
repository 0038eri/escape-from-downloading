using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : MonoBehaviour {

    private GameObject playerManager;
    private Animator gameStartAnimator;
    private AnimatorStateInfo startState;

    void Awake()
    {
        playerManager = GameObject.Find("PlayerManager");
        gameStartAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        startState = gameStartAnimator.GetCurrentAnimatorStateInfo(0);
        gameStartAnimator.Play(startState.fullPathHash, 0, 0.0f);
    }

    public void startGame()
    {
        playerManager.SendMessage("isPlayingMethod");
    } 

}