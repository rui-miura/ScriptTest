using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;
    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    public void majic()
    {
        if (mp >= 5)
        { mp = mp - 5;

        
            Debug.Log("魔法攻撃をした。残りmpは" + mp);
        }
        else
        {
            Debug.Log("mpが足りないため、魔法攻撃が使えない。");
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

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        for (int i = 0; i < 11; i++) 
        { lastboss.majic(); }

        
            
                    
    }

        
    void Update()
    {

    }
}
