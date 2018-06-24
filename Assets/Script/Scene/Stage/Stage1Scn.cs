using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Scn : MonoBehaviour {
    
	void Start () {

        // ステージ1開始位置に移動
        GameObject.Find("Player").SendMessage("stage1Start");

	}

}