using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : MonoBehaviour {

    public Animator gamestartAnimator;

    private void Awake()
    {
        gamestartAnimator = GetComponent<Animator>();
    }

    public void goPlayerUi()
    {
        gamestartAnimator.SetBool("playerUi", true);
        GameObject.Find("StageManager").SendMessage("startTimer");
    }

}