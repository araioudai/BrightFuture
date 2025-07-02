using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitch : Base
{
    public Gage gage;
    [SerializeField]GameObject gameOverText;
    public Image fadePanel;       //フェード用のUIパネル（Image）
    public Image fadeResultPanel; //フェード用のUIパネル（Image）
    public float fadeSpeed;       //フェードの完了にかかる時間
    public float current;         //ゲージ受け取り用
    public string currentScene;   //シーン名前取得用変数
    private bool textCount;       //テキスト表示回数用
    public const float END_CONDITiONS = 100f; //ゲームオーバー条件
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        fadeSpeed = 2.0f;
        current = 0;
        //if (fadePanel == null) Debug.LogWarning("fadePanel が未設定です！");
        //if (fadeResultPanel == null) Debug.LogWarning("fadeResultPanel が未設定です！");
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
        //if(Input.GetKeyDown(KeyCode.A)) { gauge = 100; }
    }

    public void OnPush()
    {
        objctName = gameObject.name; //オブジェクトの名前を取得する
        base.IncreaseDecrease();

        if (currentScene == "TitleScene")
        {
            gameOver = false;
            Coroutine();
            //SceneManager.LoadScene("GameScene");
        }

        if (currentScene == "ResultScene")
        {
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void GameOver()
    {
        current = gage.GetGaugeValue();
        //Debug.Log(gage.val);
        //gage.ChangeSliderValue(gauge); // ← 直接渡す
        if ((gameOver == true && currentScene == "GameScene") || (current == END_CONDITiONS))
        {
            buttonDel = true;
            if (textCount == false)
            {
                gameOverText.SetActive(true);
            }
            ResultCoroutine();
            //SceneManager.LoadScene("ResultScene");
        }
    }
    public void Coroutine()
    {
        StartCoroutine(FadeOutAndLoadScene());
    }

    public IEnumerator FadeOutAndLoadScene()
    {
        fadePanel.enabled = true;                                                   //パネルを有効化
        float elapsedTime = 0.0f;                                                   //経過時間を初期化
        Color startColor = fadePanel.color;                                         //フェードパネルの開始色を取得
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f); // フェードパネルの最終色を設定

        //フェードアウトアニメーションを実行
        while (elapsedTime < fadeSpeed)
        {
            elapsedTime += Time.deltaTime;                         //経過時間を増やす
            float t = Mathf.Clamp01(elapsedTime / fadeSpeed);      //フェードの進行度を計算
            fadePanel.color = Color.Lerp(startColor, endColor, t); //パネルの色を変更してフェードアウト
            yield return null;                                     //1フレーム待機
        }

        fadePanel.color = endColor;                                //フェードが完了したら最終色に設定
        
        SceneManager.LoadScene("GameScene");
    }
    public void ResultCoroutine()
    {
        StartCoroutine(ResultFadeOutAndLoadScene());
    }

    public IEnumerator ResultFadeOutAndLoadScene()
    {
        yield return new WaitForSeconds(5);                                             //3秒間待つ
        textCount = true;
        gameOverText.SetActive(false);                                                  //テキストを消す
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
    }
}
