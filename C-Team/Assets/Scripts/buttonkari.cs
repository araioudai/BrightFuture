using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class buttonkari : Base
{
	public Gage sliderController; //SliderController�X�N���v�g�ւ̎Q��
    public Score score;
    //public AudioClip sound;
    //AudioSource audioSource;

    void Start()
    {
        //audioSource = GetComponent<AudioSource>(); //Component���擾
        if (sliderController == null)
        {
            sliderController = FindObjectOfType<Gage>();
            if (sliderController != null)
                Debug.Log("Gage�X�N���v�g�������I�Ɏ擾���܂���");
            else
                Debug.LogError("Gage�X�N���v�g��������܂���I");
        }
        if (score == null)
        {
            score = FindObjectOfType<Score>();
            if (score != null)
                Debug.Log("Score�X�N���v�g�������I�Ɏ擾���܂���");
            else
                Debug.LogError("Score�X�N���v�g��������܂���I");
        }
    }

    public void OnIncreaseButtonClick(float gauge)
    {
        Debug.Log("���݂�gauge�̒l�F" + gauge);

        objctName = gameObject.name;                   //�I�u�W�F�N�g�̖��O���擾����
        base.IncreaseDecrease();
        score.ScoreCount();
        //audioSource.PlayOneShot(sound);
        if (sliderController != null)
        {
            
            sliderController.ChangeSliderValue(gauge); //���ړn��
            Debug.Log("�����{�^�����N���b�N����܂����B�ύX��: " + gauge);
        }
        else
        {
            Debug.LogError("SliderController�̎Q�Ƃ�����܂���I");
        }
    }

    // �����{�^�����N���b�N���ꂽ�Ƃ��ɌĂ΂��
    public void OnDecreaseButtonClick(float gauge)
	{
        objctName = gameObject.name;                   //�I�u�W�F�N�g�̖��O���擾����
        base.IncreaseDecrease();
        score.ScoreCount();
        if (sliderController != null)
		{
            sliderController.ChangeSliderValue(gauge);
            Debug.Log(money);

            Debug.Log("�����{�^�����N���b�N����܂����B�ύX��: ");
		}
		else
		{
			Debug.LogError("SliderController�̎Q�Ƃ�����܂���I");
		}
	}
}
