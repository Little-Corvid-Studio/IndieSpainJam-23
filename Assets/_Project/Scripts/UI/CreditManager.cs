using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreditManager : MonoBehaviour
{
    public float speed = 80.0f;
    public float limit = 2000;
    void Update()
    {
        if (transform.position.y < limit)
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        else
            GameManager.getInstance().ChangeScene("Menu");
    }
}
