using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScn : MonoBehaviour {

    // メッセージ表示テキスト
    public Text messeageText;
    // メッセージ格納変数
    private string[] message={"こんにちは","これはテストです","スキップしてください"};

    // スタートシーン Background Color
    private Color bgColor = new Color(36.0f / 255.0f, 186.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f);
    // Player Camera
    private Camera playerCam;

    //// 最大文字数
    //private int maxTextNumber;
    //// 現在の文字数
    //private int nowTextNumber;
    //// メッセージの最大行数
    //private int maxLine;
    //// 現在の行数
    //private int nowLine;
    //// メッセージスピード
    //private float messageSpeed=30.0f;
    //// 経過時間
    //private float messageTime;

    // メッセージ判定変数
    private int messageCheck = 0;

    //// メッセージ表示完了判定
    //private bool isOneMessage = false;
    //// 全メッセージ表示完了判定
    //private bool isAllMessage = false;

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
        }else{
        messeageText.text = message[messageCheck];
        messageCheck++;
        }
    }

}