using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class TrueF
{
    public static void Sort(this Transform a)
    {
        List<Transform> list = new List<Transform>();
        for (int i = 0; i < a.childCount; i++)
        {
            list.Add(a.GetChild(i));
        }
        //����List.sort�������չ ����һ������ ����ֵΪ1����-1 
        list.Sort((a, b) => 
        { 
            if(a.name.Length > b.name.Length)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        });
        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetSiblingIndex(i);
        }

    }
    
}

