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
    public Image fadePanel;       //�t�F�[�h�p��UI�p�l���iImage�j
    public Image fadeResultPanel; //�t�F�[�h�p��UI�p�l���iImage�j
    public float fadeSpeed;       //�t�F�[�h�̊����ɂ����鎞��
    public float current;         //�Q�[�W�󂯎��p
    public string currentScene;   //�V�[�����O�擾�p�ϐ�
    private bool textCount;       //�e�L�X�g�\���񐔗p
    public const float END_CONDITiONS = 100f; //�Q�[���I�[�o�[����
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        fadeSpeed = 2.0f;
        current = 0;
        //if (fadePanel == null) Debug.LogWarning("fadePanel �����ݒ�ł��I");
        //if (fadeResultPanel == null) Debug.LogWarning("fadeResultPanel �����ݒ�ł��I");
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
        //if(Input.GetKeyDown(KeyCode.A)) { gauge = 100; }
    }

    public void OnPush()
    {
        objctName = gameObject.name; //�I�u�W�F�N�g�̖��O���擾����
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
        //gage.ChangeSliderValue(gauge); // �� ���ړn��
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
        fadePanel.enabled = true;                                                   //�p�l����L����
        float elapsedTime = 0.0f;                                                   //�o�ߎ��Ԃ�������
        Color startColor = fadePanel.color;                                         //�t�F�[�h�p�l���̊J�n�F���擾
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f); // �t�F�[�h�p�l���̍ŏI�F��ݒ�

        //�t�F�[�h�A�E�g�A�j���[�V���������s
        while (elapsedTime < fadeSpeed)
        {
            elapsedTime += Time.deltaTime;                         //�o�ߎ��Ԃ𑝂₷
            float t = Mathf.Clamp01(elapsedTime / fadeSpeed);      //�t�F�[�h�̐i�s�x���v�Z
            fadePanel.color = Color.Lerp(startColor, endColor, t); //�p�l���̐F��ύX���ăt�F�[�h�A�E�g
            yield return null;                                     //1�t���[���ҋ@
        }

        fadePanel.color = endColor;                                //�t�F�[�h������������ŏI�F�ɐݒ�
        
        SceneManager.LoadScene("GameScene");
    }
    public void ResultCoroutine()
    {
        StartCoroutine(ResultFadeOutAndLoadScene());
    }

    public IEnumerator ResultFadeOutAndLoadScene()
    {
        yield return new WaitForSeconds(5);                                             //3�b�ԑ҂�
        textCount = true;
        gameOverText.SetActive(false);                                                  //�e�L�X�g������
        fadeResultPanel.enabled = true;                                                 //�p�l����L����
        float elapsedTime2 = 0.0f;                                                      //�o�ߎ��Ԃ�������
        Color startColor2 = fadeResultPanel.color;                                      //�t�F�[�h�p�l���̊J�n�F���擾
        Color endColor2 = new Color(startColor2.r, startColor2.g, startColor2.b, 1.0f); //�t�F�[�h�p�l���̍ŏI�F��ݒ�

        //�t�F�[�h�A�E�g�A�j���[�V���������s
        while (elapsedTime2 < fadeSpeed)
        {
            elapsedTime2 += Time.deltaTime;                                //�o�ߎ��Ԃ𑝂₷
            float t = Mathf.Clamp01(elapsedTime2 / fadeSpeed);             //�t�F�[�h�̐i�s�x���v�Z
            fadeResultPanel.color = Color.Lerp(startColor2, endColor2, t); // �p�l���̐F��ύX���ăt�F�[�h�A�E�g
            yield return null;                                             //1�t���[���ҋ@
        }

        fadeResultPanel.color = endColor2;                                 //�t�F�[�h������������ŏI�F�ɐݒ�

        SceneManager.LoadScene("ResultScene");
    }
}
