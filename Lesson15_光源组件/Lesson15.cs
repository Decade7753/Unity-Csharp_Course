using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    public int TimeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().transform.RotateAround(Vector3.zero, Vector3.right, Time.deltaTime * TimeSpeed);
    }
}
