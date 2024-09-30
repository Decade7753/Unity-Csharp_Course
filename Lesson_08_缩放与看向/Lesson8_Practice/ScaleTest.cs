using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTest : MonoBehaviour
{
    public float Speed = 1.0f;
    GameObject Ca;
    // Start is called before the first frame update
    void Start()
    {
        Ca = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Ca.transform.LookAt(this.transform);
        this.transform.Translate(Vector3.forward * Time.deltaTime *Speed , Space.World);
    }
}
