using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
public Transform[] pos;
public GameObject meteor;
float time;
public float a,b;
int i;
    // Start is called before the first frame update
    void Start()
    {
        time= Random.Range(a,b);
        i= (int)Random.Range(0,21);
    }

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;
if(time<=0){
reset();
Instantiate(meteor, pos[i].position, pos[i].rotation);
}
    }
public void reset(){
  time= Random.Range(a,b);
        i= (int)Random.Range(0,21);
}
}
