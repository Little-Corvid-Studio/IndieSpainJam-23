using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] int seconds_per_rotation;
    [SerializeField] float rotationAngle;
    int currentRotation = 0;
   
    private void Start()
    {
        Invoke("RotateALittle", seconds_per_rotation);
    }

    void RotateALittle()
    {
        if (currentRotation>= 360)
        {
            transform.Rotate(new Vector3(0, 0, -360));
            //GameManager.getInstance().OnTimeOver();
            currentRotation = 0;
        }
        else
        {
            currentRotation += (int)rotationAngle;
            transform.Rotate(new Vector3(0, 0, rotationAngle));

            Invoke("RotateALittle", seconds_per_rotation);
        }
    }
}
