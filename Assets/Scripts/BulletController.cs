using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float b_speed;
    [SerializeField] float b_extime;
    Transform playerTransform = null;
    
    Rigidbody2D rigidbody = null;
    float b_timer;
    public int atk { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody2D>();
        Vector2 dir = -(transform.position - playerTransform.position).normalized;//normalized→単位ベクトル
        transform.up = dir;
        rigidbody.velocity = dir * b_speed;
    }

    // Update is called once per frame
    void Update()
    {
        b_timer += Time.deltaTime; 
        if(b_timer >= b_extime)
        {
            Destroy(gameObject);
        }
    }

    public void SetAttack(int a)
    {
        atk = a;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
