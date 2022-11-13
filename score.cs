using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
public Health ht;
  Text s;
    public static int sco =0;
public combo c;
public GameObject com;
public float time=1;
public Flare fla;
bool ad;
bool ad2;
    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
          s.text ="SCORE: "+ sco.ToString("000000000");
time-=Time.deltaTime;
if(time<=0){
c.setSco(0);
com.SetActive(false);
    }
if(sco>=1000000&&!ad){
ht.add();
ad=true;
}
if(sco>=100000000&&!ad2){
ht.add();
ad2=true;

}
}
public void dam(int i){
c.dam();
time=1;
if(c.getSco()>=2)
com.SetActive(true);
sco+=i*c.getSco();
fla.aTime(c.getSco()*0.01f);
}
public void hit(){
c.setSco(0);
com.SetActive(false);
}
}
