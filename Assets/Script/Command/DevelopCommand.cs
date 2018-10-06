using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevelopCommand : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}