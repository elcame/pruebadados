using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dado1 : MonoBehaviour
{
    public GameObject dado;
    private int num;

    private int x;
    private int y;
    private int z;
    private Vector3 n1;
    private Vector3 n2;
    private Vector3 n3;
    private Vector3 n4;
    private Vector3 n5;
    private Vector3 n6;


    
    // Start is called before the first frame update
    void Start()
    {   
        x=0;
        y=0;
        z=0;
        n1= new Vector3(0,-180,0);
        n2= new Vector3(0,90,90);
        n3= new Vector3(90,-90,0);
        n4= new Vector3(90,90,0);
        n5= new Vector3(-90,90,-90);
        n6= new Vector3(0,0,-90);

    }

    // Update is called once per frame
    void Update()
    {
        if(num == 0)
        {
            dado.transform.Rotate (x, y, z);
        }
        if(num == 1)
        {
            dado.transform.rotation=Quaternion.Euler(n1.x,n1.y,n1.z);
        }
        if(num == 2)
        {
            dado.transform.rotation=Quaternion.Euler(n2.x,n2.y,n2.z);
        }
        if(num == 3)
        {
            dado.transform.rotation=Quaternion.Euler(n3.x,n3.y,n3.z);
        }
        if(num == 4)
        {
            dado.transform.rotation=Quaternion.Euler(n4.x,n4.y,n4.z);
        }
        if(num == 5)
        {
            dado.transform.rotation=Quaternion.Euler(n5.x,n5.y,n5.z);
        }
        if(num == 6)
        {
            dado.transform.rotation=Quaternion.Euler(n6.x,n6.y,n6.z);
        }

        
    }
    public void Dado()
    {
        num = 0;
        x=10;
        y=10;
        z=10;
        Invoke("Dado1", 1f);
    }
    void Dado1()
    {
        num = Random.Range(1,7);
      
    }
    public int Getnum()
    {
        return num;
    }
   
}
