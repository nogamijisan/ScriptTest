using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public class Boss
    {
        private int hp = 100;
        private int power = 20;
        private int mp = 53;

        public void attack()
        {
            Debug.Log(this.power + " damage gave!!");
        }

        public void deffence(int dmg)
        {
            Debug.Log(dmg + "damage received!!");
            this.hp -= dmg;
        }

        public void Magic()
        {
            if(mp>=5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }

        }


    }


    int Hello(int a, int b,int d)
    {
        int c = a + b + d ;
        return c;
        //Debug.Log("Hello!" + Name);
        //Debug.Log("hello");
        //Debug.Log("test");

    }
    // Start is called before the first frame update
    void Start()
    {

        //int num = 10;
        //int val = (num == 1) ? 100 : -100;

        int[] rank = { 0, 10, 20, 30, 40 };
        for(int i=0;i<rank.Length;i++)
        {
            Debug.Log(rank[i]);
        }

        for(int i=rank.Length-1;i>=0;i--)
        {
            Debug.Log(rank[i]);
        }

        Boss middleboss = new Boss();
        //middleboss.attack();
        //middleboss.deffence(30);

        for(int i=0;i<10;i++)
        {
            middleboss.Magic();
        }
        middleboss.Magic();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
