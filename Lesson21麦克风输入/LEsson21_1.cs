using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class LEsson21_1 : MonoBehaviour
{
    private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        //string[] s = Microphone.devices;
        //for (int i = 0; i < s.Length; i++)
        //{
        //    print(s[i]);
        //}

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clip = Microphone.Start(null, false, 10, 44100);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Microphone.End(null);
            AudioSource ad = this.GetComponent<AudioSource>();
            if (ad == null)
            {
                ad = this.gameObject.AddComponent<AudioSource>();
            }
            ad.clip = clip;
            ad.Play();
        }
        
        

    }
}
