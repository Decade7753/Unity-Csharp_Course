using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_2 : MonoBehaviour
{
    GameObject obj1;
    GameObject obj2;
    GameObject obj3;
    Vector3 v1;
    Vector3 v2;
    Vector3 v3;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        v1 = new Vector3(0,0, 1);
        v2 = new Vector3(0,0, 2);
        v3 = new Vector3(0,0, 3);
        obj1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj1.transform.position = this.transform.TransformPoint(v1);
        obj2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj2.transform.position = this.transform.TransformPoint(v2);
        obj3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj3.transform.position = this.transform.TransformPoint(v3);
    }

    // Update is called once per frame
    void Update()
    {
        obj1.transform.position = this.transform.TransformPoint(v1);
        obj2.transform.position = this.transform.TransformPoint(v2);
        obj3.transform.position = this.transform.TransformPoint(v3);
        this.transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
        print(Time.deltaTime);
    }
}
