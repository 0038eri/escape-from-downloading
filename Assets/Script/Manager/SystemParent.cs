using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemParent : MonoBehaviour {

	void Awake () {
	
        DontDestroyOnLoad (this); // これを消滅しない

	}

}