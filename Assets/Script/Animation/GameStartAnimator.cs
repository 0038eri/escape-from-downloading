using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartAnimator : SingletonMonoBehaviour<GameStartAnimator> {

    public void startGame()
    {
        PlayerStateManager.Instance.isPlayingMethod();
    }

}