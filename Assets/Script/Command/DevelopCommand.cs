using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevelopCommand : MonoBehaviour
{

  private void Awake()
  {
    DontDestroyOnLoad(gameObject);
  }

  void Update()
  {
    // if (Input.GetKeyDown(KeyCode.C))
    // {
    //   StageJudgeManager.stageJudge = 12;
    //   Debug.Log("全部クリアしたよ（コマンド）");
    // }

  }

}