using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
public Player pl;
public Shake sk;
public GameObject exp;
public int score=10;
private Transform target1;
public string s ="Earth";
    public float speed = 1;
    public float x =0f;
    public float y =0f;
    Rigidbody2D rigidbody2d;
    private Vector2 movement;
Vector3 size;
public float a,b;
float f;
    // Start is called before the first frame update
    void Start()
    {
pl= GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
sk= GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Shake>();
f =Random.Range(0,4); 
                speed =Random.Range(x,y);  
Transform target1 = GameObject.Find(s).transform;
        rigidbody2d = this.GetComponent<Rigidbody2D>();
       Vector3 direction = (target1.position - transform.position).normalized;       
        movement = direction;
float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg -180f ;
        rigidbody2d.rotation = angle;
size.x =Random.Range(a,b);
size.y= size.x;
transform.localScale=size;
    }

    // Update is called once per frame
    void Update()
    {
        
      if(rigidbody2d.position.x >= 15 ||rigidbody2d.position.y >= 12)
        {
            Destroy(gameObject);
        }
       if(rigidbody2d.position.x <= -12 || rigidbody2d.position.y <= -12)
        {
            Destroy(gameObject);
        }     
        move(movement);
    }
void move(Vector2 direction){
rigidbody2d.MovePosition((Vector2)transform.position + (direction * speed *Time.deltaTime));
}
private void OnTriggerEnter2D(Collider2D collision)
    {
Player player = collision.GetComponent<Player>();
        if (player != null)
        {
player.dam(score);
Instantiate(exp, rigidbody2d.position, Quaternion.identity);
sk.sh(f);
Destroy(gameObject);
}
Earth e = collision.GetComponent<Earth>();
        if (e != null)
        {
e.dam();
sk.sh(5);
Instantiate(exp, rigidbody2d.position, Quaternion.identity);
Destroy(gameObject);
}
Flares fla= collision.GetComponent<Flares>();
        if (fla != null)
        {
pl.dam(score);
Instantiate(exp, rigidbody2d.position, Quaternion.identity);
Destroy(gameObject);
}
}
}
