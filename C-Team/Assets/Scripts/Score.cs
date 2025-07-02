using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : Base
{
    public buttonkari score;
    [SerializeField]Text ScoreText;
    public static int totalMoney;   //お金合計
    // Start is called before the first frame update
    void Start()
    {
        totalMoney = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreCount();
    }
    public void ScoreCount()
    {
        //Debug.Log(money);
        totalMoney += money;
        //Debug.Log(totalMoney);
        ScoreText.text = "￥" + totalMoney.ToString("0"); //スコアを表示
    }
}
