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
        //�I�u�W�F�N�g�̖��O���擾����
        objctName = gameObject.name;
        base.IncreaseDecrease();
    }
}
