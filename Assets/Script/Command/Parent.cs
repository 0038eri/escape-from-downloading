using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

}