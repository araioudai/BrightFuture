using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneSwitch : Base
{
   /* public Image fadeResultPanel; //�t�F�[�h�p��UI�p�l���iImage�j
    public string current; //�V�[���`�F���W�p
    // Start is called before the first frame update
    void Start()
    {
        current = SceneManager.GetActiveScene().name;
        fadeSpeed = 2.0f;
        //if (fadeResultPanel == null) Debug.LogWarning("fadeResultPanel �����ݒ�ł��I");
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
            Debug.LogError("fadeResultPanel �� null �ł��I");
        }
        else
        {
            Debug.Log("fadeResultPanel �͐���ɃZ�b�g����Ă��܂��B");
        }
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
    }*/
}
