using UnityEngine;
using System;
using System.Collections;

public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

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
    // 魔法用の関数
    public void Magic(int m)
    {
        if (this.mp > 4 ){
            // 残りmpを5減らす   
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");                     
        }
        else{
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す
        for (int m = 0; m < 11; m++){
            lastboss.Magic(m);
        }  

        // 要素数5の配列を初期化する
        int[] points = { -1, 53, 21, 16, 4 };

        // 配列の各要素を順番に全て表示する
        foreach (int point in points)
        {
            Debug.Log(point);
        }

        // 配列の要素をすべて逆順に表示する
        for (int i = points.Length - 1; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}