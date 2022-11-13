using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
public GameObject over;
public GameObject health;
public GameObject spawn;
public GameObject but;
public GameObject lev;
public float time =5;
public static bool beg =false;
public static int level=1;
public GameObject[] met;
bool boss;
public static bool fin;
float fTime=3;
public GameObject end;
public GameObject[] bg;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
level=1;
Health.h=3;
fin=false;
beg=false;
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown("escape"))
Application.Quit();   
if(beg)
if(!boss)
time-=Time.deltaTime;
if(time<=0){
met[level].SetActive(true);
met[level-1].SetActive(false);
time=30;
level+=1;
lev.SetActive(true);
}
if(Health.h<=0){
over.SetActive(true);
met[10].SetActive(false);
Time.timeScale=0;
}
if(level==10&&!boss){
time=30;
met[level].SetActive(true);
bg[0].SetActive(false);
bg[1].SetActive(true);
boss=true;
}
if(fin)
fTime-=Time.deltaTime;
if(fTime<=0){
end.SetActive(true);
met[10].SetActive(false);
}
    }
public void Play(){
bg[0].SetActive(true);
beg= true;
level=1;
Health.h=3;
fin=false;
health.SetActive(true);
spawn.SetActive(true);
but.SetActive(false);
}
}
