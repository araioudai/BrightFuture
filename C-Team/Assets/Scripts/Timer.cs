using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Timer : Base
{
    [SerializeField]Text TimerText;
    [SerializeField]GameObject button;//�{�^�������悤
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Count();
        if (hide == true)
        {
            Hidden();
        } 
    }

    public void Count()
    {
        //Debug.Log(timer);
        if (timerStart == true && gameOver == false)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0;
            }
        }
        //Debug.Log(timer);
        TimerText.text = timer.ToString("F0");//�c�莞�Ԃ𐮐��ŕ\��
        if(timer == 0 && gameOver == false)
        {
            gameOver = true;
        }
        if(buttonDel == true)
        {
            button.SetActive(false);
        }
    }
    public void Hidden(){
        TimerText.enabled = false;
    }
}
