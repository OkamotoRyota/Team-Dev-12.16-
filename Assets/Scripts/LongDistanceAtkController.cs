using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongDistanceAtkController : MonoBehaviour
{
    [SerializeField] EnemyBase _enemy5;
    [SerializeField] GameObject bullet;
    float shoot_timer;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject Controller = 
        if (_enemy5.atk_start)
        {
            shoot_timer = _enemy5.atk_span;
        }
    }

    // Update is called once per frame
    void Update()
    {
        shoot_timer += Time.deltaTime;
        Vector2 muzzle = transform.position;

        if (shoot_timer > _enemy5.atk_span && _enemy5.atk_start)
        {
            shoot_timer = 0;
            Instantiate(bullet, muzzle, Quaternion.identity);
            

            
        }
    }
}
