using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScn : MonoBehaviour {

    private void Awake()
    {
        PlayerStateManager.Instance.beforeGameMethod();
        GameStartAnimator.Instance.playStartAnimation();
    }

}