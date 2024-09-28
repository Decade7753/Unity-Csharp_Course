using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class A_41 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject o = GameObject.Find("B");
        B_41 b = o.GetComponent<B_41>();
        b.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
