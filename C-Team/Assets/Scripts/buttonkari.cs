using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class buttonkari : Base
{
	public Gage sliderController; //SliderControllerスクリプトへの参照
    public Score score;
    //public AudioClip sound;
    //AudioSource audioSource;

    void Start()
    {
        //audioSource = GetComponent<AudioSource>(); //Componentを取得
        if (sliderController == null)
        {
            sliderController = FindObjectOfType<Gage>();
            if (sliderController != null)
                Debug.Log("Gageスクリプトを自動的に取得しました");
            else
                Debug.LogError("Gageスクリプトが見つかりません！");
        }
        if (score == null)
        {
            score = FindObjectOfType<Score>();
            if (score != null)
                Debug.Log("Scoreスクリプトを自動的に取得しました");
            else
                Debug.LogError("Scoreスクリプトが見つかりません！");
        }
    }

    public void OnIncreaseButtonClick(float gauge)
    {
        Debug.Log("現在のgaugeの値：" + gauge);

        objctName = gameObject.name;                   //オブジェクトの名前を取得する
        base.IncreaseDecrease();
        score.ScoreCount();
        //audioSource.PlayOneShot(sound);
        if (sliderController != null)
        {
            
            sliderController.ChangeSliderValue(gauge); //直接渡す
            Debug.Log("増加ボタンがクリックされました。変更量: " + gauge);
        }
        else
        {
            Debug.LogError("SliderControllerの参照がありません！");
        }
    }

    // 減少ボタンがクリックされたときに呼ばれる
    public void OnDecreaseButtonClick(float gauge)
	{
        objctName = gameObject.name;                   //オブジェクトの名前を取得する
        base.IncreaseDecrease();
        score.ScoreCount();
        if (sliderController != null)
		{
            sliderController.ChangeSliderValue(gauge);
            Debug.Log(money);

            Debug.Log("減少ボタンがクリックされました。変更量: ");
		}
		else
		{
			Debug.LogError("SliderControllerの参照がありません！");
		}
	}
}
