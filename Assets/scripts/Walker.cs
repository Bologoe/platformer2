using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : Entity
{
    private float speed = 2f;
    private Vector3 dir;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        dir = -1f * transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed*Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject == Hero.Instance.gameObject)
       {
            Hero.Instance.GetDamage();
       } 
    }

}
