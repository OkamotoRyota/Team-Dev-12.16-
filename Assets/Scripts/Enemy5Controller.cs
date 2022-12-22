using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5Controller : EnemyBase
{
    // Start is called before the first frame update
    [SerializeField] GameObject _bullet;
    void Start()
    {
        FindPlayer();
        GameObject k = Instantiate(_bullet);
        BulletController bc = k.GetComponent<BulletController>();
        bc.SetAttack(atk);
    }

    // Update is called once per frame
    void Update()
    {
        
        Search();
        Life();

    }
    public override void Attack()
    {
        Vector2 a_dir = -(transform.position - playerTransform.position).normalized;//normalized→単位ベクトル
        transform.up = a_dir;
        //a_dir *= movepower;

        rb.AddForce(a_dir * movepower, ForceMode2D.Force);
    }
}
