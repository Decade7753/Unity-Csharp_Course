using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum E_DoSomething
{
    Rename,
    DisActive,
    Active,
    RemoveDelay,
    RemoveIm,
}
public class A_43 : MonoBehaviour
{
    public E_DoSomething a1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject BB = GameObject.Find("B");
        switch (a1)
        {
            case E_DoSomething.Rename:
                BB.name = "ÒÑ¸ÄÃû!";
                break;
            case E_DoSomething.DisActive:
                BB.SetActive(false);
                break;
            case E_DoSomething.Active:
                BB.SetActive(true);
                break;
            case E_DoSomething.RemoveDelay:
                GameObject.Destroy(BB,5);
                break;
            case E_DoSomething.RemoveIm:
                GameObject.DestroyImmediate(BB);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
