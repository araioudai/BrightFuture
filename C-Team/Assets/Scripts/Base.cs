using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Base : MonoBehaviour
{
    protected string objctName;           //オブジェクト名
    protected static int money;                  //スコア（お金）
    protected static float timer;         //制限時間
    protected static float gauge;         //ゲージ用
    protected static bool hide;           //テキストを隠すフラグ
    protected static bool timerStart;     //タイマー用フラグ
    protected static bool gameOver;       //ゲームオーバーフラグ
    protected static bool buttonDel;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected virtual void Init()
    {
        gauge = 0.0f;
        timer = 0.0f;
        money = 0;
        gameOver = false;
        timerStart = false;
        hide = false;
        buttonDel = false;
    }
    protected virtual void IncreaseDecrease()
    {
        //switch文
        switch (objctName)
        {
            //名前が「Houzin(Clone)」のとき
            case "Houzin(Clone)":
                money = 10000;
                break;
            //名前が「Houzin(Clone)」のとき
            case "Houjin(Clone)":
                money = 3000;
                break;
            //名前が「Silyouhi(Clone)」のとき
            case "Silyouhi(Clone)":
                money = 18000;

                break;
            //名前が「Syouhi(Clone)」のとき
            case "Syouhi(Clone)":
                money = 9200;

                break;
            //名前が「Silyu(Clone)」のとき
            case "Silyu(Clone)":
                money = 750;

                break;
            //名前が「Zilyuumin(Clone)」のとき
            case "Zilyuumin(Clone)":
                money = 8300;

                break;
            //名前が「Seisaku10(Clone)」のとき
            case "Seisaku10(Clone)":
                money = -12000;

                break;
            //名前が「Seisaku5(Clone)」のとき
            case "Seisaku5(Clone)":
                money = -6000;

                break;
            //名前が「Endless」のとき
            case "Endless":
                timer = 60f;
                //Debug.Log(timer);
                hide = true; //時間テキストを隠す
               
                break;
            //名前が「Time」のとき
            case "Time":
                timer = 60f;       //タイマーセット
                //Debug.Log(timer);
                timerStart = true; //タイマーを開始

                break;
        }
    }
}


