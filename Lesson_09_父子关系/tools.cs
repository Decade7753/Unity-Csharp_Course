using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class tools
{
    public static Transform MyFind(this Transform obj , string objName)
    {
        Transform a = null;
        if(obj.Find(objName) == null)
        {
            for(int i = 0; i<obj.childCount; i++)
            {
                 if(obj.GetChild(i).MyFind(objName) != null)
                 {
                    a = obj.GetChild(i).MyFind(objName);
                 }
                return a;
            }
        }
        else
        {
            a = obj.Find(objName);
        }


        return a;
        

    }
}
