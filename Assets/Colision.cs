using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    GameObject obj1, obj2;
    public float v1x = -2.0f, v2x = 5.0f, x1 = 6.0f, x2 = -6.0f, h = 0.1f, r1 = 1.0f, r2 = 1.0f, Masa_1 = 10.0f, Masa_2 = 3.0f, e = 0.9f;
    public float dis = 0.0f;
    public float nv1 = 0.0f, nv2 = 0.0f;
    //Start is called before the first frame update
    public void asignarmasa1(string m1)
    {
        Masa_1 = 0.0f;
        Masa_1 = float.Parse(m1);
    }
    public void asignarmasa2(string m2)
    {
        Masa_2 = 0.0f;
        Masa_2 = float.Parse(m2);
    }
    public void xinicial1(string xini1)
    {
        x1 = 0.0f;
        x1 = float.Parse(xini1);
    }
    public void xinicial2(string xini2)
    {
        x2 = 0.0f;
        x2 = float.Parse(xini2);
    }
    public void velocidad1(string vel1)
    {
        v1x = 0.0f;
        v1x = float.Parse(vel1);
    }
    public void velocidad2(string vel2)
    {
        v2x = 0.0f;
        v2x = float.Parse(vel2);
    }
    public void radio1(string radio1)
    {
        r1 = 0.0f;
        r1 = float.Parse(radio1);
    }
    public void radio2(string radio2)
    {
        r2 = 0.0f;
        r2 = float.Parse(radio2);
    }
    public void coeficienterestitu(string cresti)
    {
        e = 0.0f;
        e = float.Parse(cresti);
    }
    void Start()
    {
       
        obj1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj1.transform.localScale = new Vector3(2 * r1, 2 * r1, 2 * r1);
        obj2= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj2.transform.localScale = new Vector3(2*r2, 2*r2, 2*r2);
        nv1 = ((Masa_1 - (e) * (Masa_2) * v1x) / (Masa_1 + Masa_2)) + ((1 + e) * (Masa_2) * v2x) / (Masa_1 + Masa_2);
        nv2 = (((1 + e) * (Masa_1) * v1x) / (Masa_1 + Masa_2)) + (((Masa_2 - (e) * (Masa_1) * v2x) / (Masa_1 + Masa_2)));
    }

    // Update is called once per frame
    void Update()
    {
        obj1.transform.position = new Vector3(x1, 0f, 0f);
        obj2.transform.position = new Vector3(x2, 0f, 0f);
        dis = Mathf.Abs(x1 - x2);
        if(dis>r1+r2)
        {
            movrectiliniounif();
        }
        else if (dis <= r1+r2)
        {
            colision();
            v1x = nv1;
            v2x = nv2;
        }
    }
    void movrectiliniounif()
    {
            //vx = -vx;
       x1 = v1x * h + x1;
       x2 = v2x * h + x2;
    }
    void colision()
    {
       x1 = nv1 * h + x1; 
       x2 = nv2 * h + x2;
    }
}
