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
        if ((cam.transform.position.x + move.x < 100 && cam.transform.position.x + move.x > -100)
            || (transform.position.y + move.y < 100 && transform.position.y + move.y>-100))
                cam.transform.Translate(move);
        
    }
   
}
