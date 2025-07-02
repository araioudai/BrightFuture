using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Threading;

public class RandomButton : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform buttonParent;
    public int button;

    public Vector2[] positions = new Vector2[]
    {
        new Vector2(-250, -100),
        new Vector2(-250, -350),
        new Vector2(250, -100),
        new Vector2(250, -350)
    };


    public List<string> textList = new List<string> {
        "消費税",
        "法人税",
        "酒税",
        "住民税",
        "所得税",
        "贈与税"
    };
    public int buttonCount = 4;
    void SpawnButtons()
    {
        // ランダムに4つ選ぶ
        List<string> selectedTexts = textList.OrderBy(x => Random.value).Take(buttonCount).ToList();

        for (int i = 0; i < buttonCount; i++)
        {
            GameObject buttonInstance = Instantiate(buttonPrefab, buttonParent);
            buttonInstance.GetComponent<RectTransform>().anchoredPosition = positions[i];

            // Textを設定（TextまたはTextMeshPro）
            Text label = buttonInstance.GetComponentInChildren<Text>();
            if (label != null)
            {
                label.text = selectedTexts[i];
            }
        }
    }

    public void OnClick()
    {
        Debug.Log("押された");
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnButtons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
