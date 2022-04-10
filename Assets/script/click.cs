using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class click : MonoBehaviour
{
    private bool C = false;
    GameObject DICE1 ;
    GameObject DICE2 ;
    void Start()
    {
       C = false; 
       DICE1 = GameObject.Find("dado1");
       DICE2 = GameObject.Find("dado2");
    }
     void tirardado(){
        DICE1.SendMessage("Dado");
        DICE2.SendMessage("Dado");
    }
    public  void OnClick()
    {   Debug.Log("click");
        if(C == false)
        {
            C = true;
            Invoke("llamada",0.5f);
            tirardado();
            Invoke("suma",1f);
                
          
        }
        
        

    }
    void suma(){
        int suma=DICE1.GetComponent<dado1>().Getnum()+DICE2.GetComponent<dado1>().Getnum();
        Debug.Log(suma);
    }

    
    public void llamada(){
        C = false;
    }

}
