using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeAnimation : MonoBehaviour {

    public string[] paragraphDeta;
    public int paragraphNumber = 0;
    private string currentText;
    public Text serif;
    int lastUpdate;
    float clickTime = Time.time;
    float displayTime = 2.0f;
    bool displayTextFlag = false;

    private void Start()
    {
        //currentText = paragraphDeta[0];
        //serif.text = currentText;
        readyClick();
    }

    void Update () {
        //if(Input.GetMouseButtonDown(0)){
        //    displayTextFlag = false;
        //}
        //if (displayTextFlag == false)
        //{
            int displayCount = (int)(Mathf.Clamp01((Time.time - clickTime) / displayTime) * currentText.Length);
        if (displayCount != lastUpdate)
        {
            currentText = paragraphDeta[paragraphNumber];
            serif.text = currentText.Substring(0, displayCount);
            lastUpdate = displayCount;
            if (displayCount == currentText.Length)
            {
                displayTextFlag = true;
                readyClick();
            }
        }
        //}
	}

    void readyClick()
    {
        currentText = paragraphDeta[paragraphNumber];
        paragraphNumber++;
    }

}