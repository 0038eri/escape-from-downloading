using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScn : MonoBehaviour {

    // メッセージ判定変数
    private int messageCheck = 0;
    // メッセージ表示テキスト
    public Text messeageText;
    // メッセージ格納変数
    private string[] message = { "こんにちは", "これはテストです", "スキップしてください" };

    // スタートシーン Background Color
    private Color bgColor = new Color(0.0f / 255.0f, 188.0f / 255.0f, 90.0f / 255.0f, 255.0f / 255.0f);
    // Player Camera
    private Camera systemCam;

    void Awake()
    {
        systemCam = GameObject.Find("SystemCamera").GetComponent<Camera>();
    }

    void Start(){
        systemCam.backgroundColor = bgColor;
        typeMessage();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            typeMessage();
        }
    }

    void typeMessage () {
        if(messageCheck==3){
            GameObject.Find("SkipObj").SendMessage("skipToStage1");
        }else{
        messeageText.text = message[messageCheck];
        messageCheck++;
        }
    }

}