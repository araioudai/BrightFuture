using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gage : Base
{
	public Slider slider;  // UI Sliderコンポーネントへの参照
	public Image fillImage;  // Fill Area Imageへの参照
	public float val;
	private Color orange = new Color(1f, 0.65f, 0f);  // オレンジ色の定義

	void Start()
	{
		// 設定されていない場合、スライダーコンポーネントを取得
		if (slider == null)
		{
			slider = GetComponent<Slider>();
			Debug.Log("自動的にSliderコンポーネントを取得しています");
		}

		// 設定されていない場合、fillイメージを取得
		if (fillImage == null && slider != null)
		{
			fillImage = slider.fillRect.GetComponent<Image>();
			Debug.Log("自動的にFill Imageを取得しています");
		}

		if (slider == null)
		{
			Debug.LogError("Sliderの参照がありません！");
		}

		if (fillImage == null)
		{
			Debug.LogError("Fill Imageの参照がありません！");
		}
		else
		{
			UpdateFillColor();  // 初期の塗りつぶし色を設定
			Debug.Log("初期スライダー値: " + slider.value);
		}
        
    }

    void Update()
    {
        
    }

    public void ChangeSliderValue(float value)
    {
        if (slider != null)
        {
            float newValue = slider.value + value;
            newValue = Mathf.Clamp(newValue, slider.minValue, slider.maxValue);
			//val = newValue;
            slider.value = newValue;

            //Debug.Log("スライダーの値が変更されました: " + slider.value);
            UpdateFillColor();
        }
        else
        {
            Debug.LogError("スライダー値を変更できません - スライダーの参照がnullです");
        }
    }

    // スライダーの値に基づいて塗りつぶし色を更新
    private void UpdateFillColor()
	{
		if (fillImage != null && slider != null)
		{
			float normalizedValue = (slider.value - slider.minValue) / (slider.maxValue - slider.minValue);
			float value = normalizedValue * 100f;  // 0-100の範囲にスケーリング

			if (value <= 80f)
			{
				// 緑からオレンジへ (0-50)
				fillImage.color = Color.Lerp(Color.green, orange, value / 50f);
			}
			else if (value <= 90f)
			{
				// オレンジから赤へ (50-70)
				fillImage.color = Color.Lerp(orange, Color.red, (value - 50f) / 20f);
			}
			else
			{
				// 赤 (70-100)
				fillImage.color = Color.red;
			}
            //Debug.Log(timer);
            //Debug.Log("値:" + value + "に対して塗りつぶし色を更新しました");
		}
	}
    public float GetGaugeValue()
    {
        return slider != null ? slider.value : 0f;
    }
}
