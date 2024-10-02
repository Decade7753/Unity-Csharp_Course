using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15_1 : MonoBehaviour
{
    public int Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(Vector3.zero , Vector3.right , Time.deltaTime * Speed);
    }
}
