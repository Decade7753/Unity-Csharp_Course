using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       b B = GetComponent<b>();
        B.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
