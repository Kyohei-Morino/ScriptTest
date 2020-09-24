using UnityEngine;
using System.Collections;



public class Boss
{
     //Start is called before the first frame update
    private int hp = 100;
    private int power = 25;
    
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    
}

public class Test : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();
        //Boss midboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        
        

        int[] array = { 100, 200, 300, 400, 500 };


        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}