using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameParent : MonoBehaviour {

	void Awake () {
		
        DontDestroyOnLoad(this); // これを消滅しない

	}

	void Start () {

	}

}