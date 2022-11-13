using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public Flare fre;
public GameObject fla;
public Health h;
public score s;
Vector2 mPos;
public float speed =1f;
Rigidbody2D rb;
Vector2 pos = new Vector2(0f,0f);
bool idle=true;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
   if (Input.GetMouseButtonDown(0)&&fre.getTime()>=100&&Main.beg){
Instantiate(fla,rb.position, Quaternion.identity);
fre.dam();
}
        mPos= Input.mousePosition;
       mPos = Camera.main.ScreenToWorldPoint(mPos);
       pos = Vector2.Lerp(transform.position, mPos,speed/20f);
if(Vector2.Distance(transform.position, mPos)<=0.1f)
idle=true;
else
idle=false;
    }
private void FixedUpdate(){
rb.MovePosition(pos);
  
}
public void dam(int score){
s.dam(score);
}
private void OnTriggerEnter2D(Collider2D collision)
    {
Boss b = collision.GetComponent<Boss>();
        if (b != null)
        {
b.dam(Vector2.Distance(transform.position, mPos));
}
Dish d = collision.GetComponent<Dish>();
        if (d != null)
        {
d.dam(Vector2.Distance(transform.position, mPos));
}
}
}
