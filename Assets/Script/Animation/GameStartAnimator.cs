using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : MonoBehaviour {

    private Animator gameStartAnimator;

    void Awake()
    {
        gameStartAnimator = GameObject.Find("GameStart").GetComponent<Animator>();
    }

    public void gameStartAnimation()
    {
        gameStartAnimator.enabled = true;
    }

    public void notGameStartAnimation()
    {
        gameStartAnimator.enabled = false;
    }

}