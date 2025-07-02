using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Base : MonoBehaviour
{
    protected string objctName;           //�I�u�W�F�N�g��
    protected static int money;                  //�X�R�A�i�����j
    protected static float timer;         //��������
    protected static float gauge;         //�Q�[�W�p
    protected static bool hide;           //�e�L�X�g���B���t���O
    protected static bool timerStart;     //�^�C�}�[�p�t���O
    protected static bool gameOver;       //�Q�[���I�[�o�[�t���O
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
        //switch��
        switch (objctName)
        {
            //���O���uHouzin(Clone)�v�̂Ƃ�
            case "Houzin(Clone)":
                money = 10000;
                break;
            //���O���uHouzin(Clone)�v�̂Ƃ�
            case "Houjin(Clone)":
                money = 3000;
                break;
            //���O���uSilyouhi(Clone)�v�̂Ƃ�
            case "Silyouhi(Clone)":
                money = 18000;

                break;
            //���O���uSyouhi(Clone)�v�̂Ƃ�
            case "Syouhi(Clone)":
                money = 9200;

                break;
            //���O���uSilyu(Clone)�v�̂Ƃ�
            case "Silyu(Clone)":
                money = 750;

                break;
            //���O���uZilyuumin(Clone)�v�̂Ƃ�
            case "Zilyuumin(Clone)":
                money = 8300;

                break;
            //���O���uSeisaku10(Clone)�v�̂Ƃ�
            case "Seisaku10(Clone)":
                money = -12000;

                break;
            //���O���uSeisaku5(Clone)�v�̂Ƃ�
            case "Seisaku5(Clone)":
                money = -6000;

                break;
            //���O���uEndless�v�̂Ƃ�
            case "Endless":
                timer = 60f;
                //Debug.Log(timer);
                hide = true; //���ԃe�L�X�g���B��
               
                break;
            //���O���uTime�v�̂Ƃ�
            case "Time":
                timer = 60f;       //�^�C�}�[�Z�b�g
                //Debug.Log(timer);
                timerStart = true; //�^�C�}�[���J�n

                break;
        }
    }
}


