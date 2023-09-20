using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] int seconds_per_rotation;
    [SerializeField] float rotationAngle;
   
    private void Start()
    {
        Invoke("RotateALittle", seconds_per_rotation);
    }

    void RotateALittle()
    {
        transform.Rotate(new Vector3(0, 0, rotationAngle));
       
        Invoke("RotateALittle", seconds_per_rotation);
    }
}
