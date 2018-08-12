using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour {

    public GameObject playerUi;

    public void openPlayerUi()
    {
        playerUi.SetActive(true);
    }

    public void closePlayerUi()
    {
        playerUi.SetActive(false);
    }

}