using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] public int hp, atk;
    [SerializeField] public int difficulty;
    [SerializeField] public float atk_range, atk_e_range, atk_span;
    [SerializeField] public float movepower = 1;
    [SerializeField] GameObject DropItem;
    public bool atk_start = false;
    
    
    protected Transform playerTransform;
    protected Rigidbody2D rb;
    //Vector2 nm = Random.insideUnitCircle;

    
    public void FindPlayer()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        
    }
    public virtual void Life()
    {

        if(hp == 0)
        {
            Vector2 _grave = transform.position; 
            Instantiate(DropItem,_grave,Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public virtual void Search()
    {
        Vector2 dir = -(transform.position - playerTransform.position).normalized;//normalized���P�ʃx�N�g��
        transform.up = dir;
        if ((transform.position - playerTransform.position).magnitude <= atk_range) //�v���C���[�ƃG�l�~�[�̋�����atk_range�ȉ��̂Ƃ��U��
        {
            atk_start = true;
            Attack();
        }
        else
        {
            //   rigidbody2d.AddForce((1f,1f)* movepower, ForceMode2D.Force);
            atk_start = false;
        }
    }
    public virtual void Attack()
    {
        Vector2 a_dir = -(transform.position - playerTransform.position).normalized;//normalized���P�ʃx�N�g��
        transform.up = a_dir;
        //a_dir *= movepower;
        rb.velocity = a_dir * movepower;
        //rb.AddForce(a_dir * movepower, ForceMode2D.Force);
    }
}
