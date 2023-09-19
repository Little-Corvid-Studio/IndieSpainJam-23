using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class StarManager : ValidatedMonoBehaviour
{
    [SerializeField] public StarData[] starDatas;

    private void Start()
    {
        //DEBUG
        for(int i = 0; i < starDatas.Length; i++)
        {
            StarNode starData =(StarNode)starDatas[i];
            for(int j=0;j<starData.getConnections().Length;j++)
            {
                if (starData.getConnections()[j])
                {
                    Debug.Log(i+","+j);
                    
                }
            }
        
        }
    }

}
