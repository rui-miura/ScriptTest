using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53;
    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }
    public void majic()
    {
        if (mp >= 5)
        { mp = mp - 5;

        
            Debug.Log("���@�U���������B�c��mp��" + mp);
        }
        else
        {
            Debug.Log("mp������Ȃ����߁A���@�U�����g���Ȃ��B");
        }
           
    }
}

public class Test : MonoBehaviour
{ 
    void Start ()
    {
       
        int[] array = new int[5];

       
        array[0] = 30;
        array[0] = 20;
        array[1] = 17;
        array[2] = 2;
        array[3] = 27;
        array[4] = 36;
                
         for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        
        
        
        for (int i = 4; i != -1; i--)
        {
            Debug.Log(array[i]);
        }
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        for (int i = 0; i < 11; i++) 
        { lastboss.majic(); }

        
            
                    
    }

        
    void Update()
    {

    }
}
