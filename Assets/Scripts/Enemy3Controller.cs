using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Controller : EnemyBase
{
    [SerializeField] GameObject explosion;
    float e_timer;
    // Start is called before the first frame update
    void Start()
    {
        FindPlayer();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Search()
    {
        base.Search();
    }
}
