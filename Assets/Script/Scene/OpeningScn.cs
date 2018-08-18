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

    void Start(){
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
        } else {
            messeageText.text = message[messageCheck];
            messageCheck++;
        }
    }

}