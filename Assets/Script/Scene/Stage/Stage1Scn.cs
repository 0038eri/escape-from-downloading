using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Scn : MonoBehaviour {
    
	void Start () {

        GameObject.Find("Player").SendMessage("stage1Start");

	}

}