using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class StarNode : StarData
{
    protected StarManager manager;
    [SerializeField] public int index;
    [SerializeField] public int[] connectionsIndex; //num of index solutions

    bool mouseInRect = false;
    private void Start()
    {
        manager= FindObjectOfType<StarManager>();
        manager.AddStar(this);
    }

    private void OnMouseOver()
    {
        mouseInRect = true;
    }
    private void OnMouseExit()
    {
        mouseInRect = false;
    }

  
    public bool getMouseInSelf()
    {
        return mouseInRect;
    }

}
