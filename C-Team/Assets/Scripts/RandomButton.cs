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
        "�����",
        "�@�l��",
        "���",
        "�Z����",
        "������",
        "���^��"
    };
    public int buttonCount = 4;
    void SpawnButtons()
    {
        // �����_����4�I��
        List<string> selectedTexts = textList.OrderBy(x => Random.value).Take(buttonCount).ToList();

        for (int i = 0; i < buttonCount; i++)
        {
            GameObject buttonInstance = Instantiate(buttonPrefab, buttonParent);
            buttonInstance.GetComponent<RectTransform>().anchoredPosition = positions[i];

            // Text��ݒ�iText�܂���TextMeshPro�j
            Text label = buttonInstance.GetComponentInChildren<Text>();
            if (label != null)
            {
                label.text = selectedTexts[i];
            }
        }
    }

    public void OnClick()
    {
        Debug.Log("�����ꂽ");
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
