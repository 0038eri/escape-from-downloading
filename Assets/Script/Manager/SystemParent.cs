using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemParent : MonoBehaviour {

	void Start () {
		
        // これを消滅しない
		DontDestroyOnLoad (this);

	}

}