using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class a1 : MonoBehaviour
{
    public b1 b1;
    // Start is called before the first frame update
    void Start()
    {
        b1 bb = b1.GetComponent<b1>();
        bb.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
