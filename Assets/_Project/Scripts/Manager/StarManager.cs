using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class StarManager : ValidatedMonoBehaviour
{
    StarNode[] starDatas;
    Rect[] clickboxes;

    int numOfStars = 0;
    enum MouseState
    { 
        Iddle,
        Draging,
        Up
    }
    private void Awake()
    {
        //100 por poner un limite en memoria
        starDatas = new StarNode[100];
        clickboxes = new Rect[100];
    }

    public void AddStar(StarNode star)
    {
        starDatas[star.index] = star;
        clickboxes[star.index] = new Rect(starDatas[star.index].transform.position.x, starDatas[star.index].transform.position.y, 2*starDatas[star.index].transform.localScale.x, 2*starDatas[star.index].transform.localScale.y);

        Debug.Log(starDatas[star.index].transform.position.x + " " + starDatas[star.index].transform.position.y + " " + 2 * starDatas[star.index].transform.localScale.x + " " + 2 * starDatas[star.index].transform.localScale.y);

        numOfStars++;

    }

    private void Update()
    {
        if (starDatas[1]!=null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                int i = 1;
                bool flag = !starDatas[i].getMouseInSelf();
               
                while (i < starDatas.Length && !flag)
                {
                   
                    i++;
                    if (starDatas[i] != null)
                    {
                        flag = !starDatas[i].getMouseInSelf();
                    }
                    Debug.Log(i);
                }

              
            }
        }
    }

  

}
