using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneSwitch : Base
{
   /* public Image fadeResultPanel; //フェード用のUIパネル（Image）
    public string current; //シーンチェンジ用
    // Start is called before the first frame update
    void Start()
    {
        current = SceneManager.GetActiveScene().name;
        fadeSpeed = 2.0f;
        //if (fadeResultPanel == null) Debug.LogWarning("fadeResultPanel が未設定です！");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        //Debug.Log(Timeer.gameOver);
        if (gameOver == true && current == "GameScene")
        {
            ResultCoroutine();
            //SceneManager.LoadScene("ResultScene");
        }
    }

    public void ResultCoroutine()
    {
        StartCoroutine(ResultFadeOutAndLoadScene());
    }

    public IEnumerator ResultFadeOutAndLoadScene()
    {
        if (fadeResultPanel == null)
        {
            Debug.LogError("fadeResultPanel が null です！");
        }
        else
        {
            Debug.Log("fadeResultPanel は正常にセットされています。");
        }
        fadeResultPanel.enabled = true;                                                 //パネルを有効化
        float elapsedTime2 = 0.0f;                                                      //経過時間を初期化
        Color startColor2 = fadeResultPanel.color;                                      //フェードパネルの開始色を取得
        Color endColor2 = new Color(startColor2.r, startColor2.g, startColor2.b, 1.0f); //フェードパネルの最終色を設定

        //フェードアウトアニメーションを実行
        while (elapsedTime2 < fadeSpeed)
        {
            elapsedTime2 += Time.deltaTime;                                //経過時間を増やす
            float t = Mathf.Clamp01(elapsedTime2 / fadeSpeed);             //フェードの進行度を計算
            fadeResultPanel.color = Color.Lerp(startColor2, endColor2, t); // パネルの色を変更してフェードアウト
            yield return null;                                             //1フレーム待機
        }

        fadeResultPanel.color = endColor2;                                 //フェードが完了したら最終色に設定

        SceneManager.LoadScene("ResultScene");
    }*/
}
