using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_2 : MonoBehaviour
{
    Vector3 v3;
    GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v3 = Input.mousePosition;
        v3.z = 40;
        v3 = Camera.main.ScreenToWorldPoint(v3);
        
        if (Input.GetMouseButton(0))
        {
            Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Cube.transform.position = v3;
            //print(v3);
        }
        
    }
}
