using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class NodeConnector : ValidatedMonoBehaviour
{
    [SerializeField, Self] protected LineRenderer lineRenderer;
    
    public LineRenderer GetLineRenderer() { return lineRenderer; }

    private void Awake()
    {
        
    }

    private void OnMouseDown()
    {
        
    }
}
