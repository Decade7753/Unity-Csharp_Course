using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20_1 : MonoBehaviour
{
    AudioSource audio_D;
    // Start is called before the first frame update
    void Start()
    {
        audio_D = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio_D.Play();
        }
        else if (Input.GetMouseButtonUp(1))
        {
            audio_D.Stop();

        }
    }
}
