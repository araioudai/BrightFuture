using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Base
{
    void Update()
    {
       
    }
    public void Push() 
    {
        //オブジェクトの名前を取得する
        objctName = gameObject.name;
        base.IncreaseDecrease();
    }
}
