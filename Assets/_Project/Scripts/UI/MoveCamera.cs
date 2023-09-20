using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Camera cam;

    [SerializeField] Vector2 move;
    private void Awake()
    {
        cam= Camera.main;
    }
    public void Move()
    {
        cam.transform.Translate(move);
        
    }
   
}
