using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : EnemyBase
{
    // Start is called before the first frame update
    void Start()
    {
        FindPlayer();
    }

    void Update()
    {
        Life();
        Search();
        
    }

    //private void OnCollisionEnter2D(Collision2D collision) // �h���b�v�m�F�p
    //{
    //    hp -= 10;
    //}
}
