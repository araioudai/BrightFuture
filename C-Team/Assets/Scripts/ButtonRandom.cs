using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ButtonRandom : MonoBehaviour
{
    //ボタンのプレハブを配列で登録
    public GameObject[] randombuttonPrefabs;
    public Transform buttonParent;
    public GameObject buttonPare;

    public Vector2[] positions = new Vector2[]
    {
        new Vector2(-150, -100),
        new Vector2(-150, -250),
        new Vector2(150, -100),
        new Vector2(150, -250)
    };

    public List<GameObject> activeButtons = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomButtons();
    }
    void Update()
    {
        if (Base.gameOver == false)
        {
            buttonPare.SetActive(true);
        }
    }

    public void SpawnRandomButtons()
    {
        //ボタンの削除
        foreach (var btn in activeButtons)
        {
            //Debug.Log("Destroying: " + btn.name);
            Destroy(btn);
        }
        activeButtons.Clear();

        //ランダムで選ぶ
        var randomButtons = randombuttonPrefabs.OrderBy(x => Random.value).Take(4).ToList();

        for (int i = 0; i < randomButtons.Count; i++)
        {
            var button = Instantiate(randomButtons[i], buttonParent);
            button.GetComponent<RectTransform>().anchoredPosition = positions[i];
            button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => OnButtonClick(button));
            activeButtons.Add(button);
        }
    }

    void OnButtonClick(GameObject button)
    {
        // イベントが発生したときの処理
        //Debug.Log("Button clicked: " + button.name);

        // 新しいボタンを生成
        SpawnRandomButtons();
    }
}
