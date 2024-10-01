using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    Transform Up;
    // Start is called before the first frame update    
    void Start()
    {
        Up = this.transform.Find("Up");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }  
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -speed * Time.deltaTime * 10, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, speed * Time.deltaTime * 10, Space.Self);
        }
        Up.Rotate(Vector3.up, Input.GetAxis("Mouse X")* speed* Time.deltaTime * 10 , Space.World);
    }
}
