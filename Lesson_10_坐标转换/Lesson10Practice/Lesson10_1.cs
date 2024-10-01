using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_1 : MonoBehaviour
{
    GameObject game;
    Vector3 v1;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
       
        game = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        v1 = this.transform.position + this.transform.TransformPoint(new Vector3(2, 0, 2));
        game.transform.position = v1;
       
    }

    // Update is called once per frame
    [ContextMenu("左前方创建新物体")]
    void TestFUn1()
    {
        this.transform.Rotate(Vector3.up , speed * Time.deltaTime , Space.World);
        //print(this.transform.position);
        v1 = this.transform.InverseTransformPoint(this.transform.position) + new Vector3(2, 0, 2);
        //print(this.transform.InverseTransformPoint(this.transform.position));
        game.transform.position = this.transform.TransformPoint(v1);
    
    }
}
