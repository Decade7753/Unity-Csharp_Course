using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson14_1 : MonoBehaviour
{
    Vector3 v3;
    // Start is called before the first frame update
    void Start()
    {
        v3 = this.transform.position;
        v3 = Camera.main.WorldToScreenPoint(v3);
        
    }

    // Update is called once per frame
    void Update()
    {
        print("世界坐标在屏幕坐标的位置是"+v3);
        print("鼠标的位置是" + Input.mousePosition);
    }
}
