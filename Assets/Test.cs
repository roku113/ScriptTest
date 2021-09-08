using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int mp = 53;
    private int power = 25;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void MagicAttack()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else if(this.mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    public void Defence(int damege)
    {
        Debug.Log(damege + "のダメージを受けた");
        this.hp -= damege;
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] five = { 10, 20, 30, 40, 50 };

        for(int i = 0; i < five.Length; i++)
        {
            Debug.Log(five[i]);
        }

        for(int i = five.Length -1; 0 <= i; i--)
        {
            Debug.Log(five[i]);
        }


        Boss lastboss = new Boss();

        for (int i = 0; i <11; i++)
        {
            lastboss.MagicAttack();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
