using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManager : MonoBehaviour
{
  
    [SerializeField] GameObject[] cloudsObject;
    [SerializeField] int time;
    void OnEnable()
    {
        Invoke("SpawnCloud", time);
    }

    void SpawnCloud()
    {
        float dir_x = Random.value;
        float dir_y = Random.value;

        bool random_x = (int)Random.value ==0;
        bool random_y = (int)Random.value == 0;

        if (random_x) dir_x= -dir_x;
        if(random_y) dir_y= -dir_y;

        float position_x = Random.Range(-50, 50);
        float position_y = Random.Range(-50, 50);

        int cloudIndex = (int)Random.Range(0, cloudsObject.Length);
        GameObject g= Instantiate(cloudsObject[cloudIndex], this.transform);
        Cloud cloud = g.GetComponent<Cloud>();
        cloud.dir= new Vector2 (dir_x, dir_y);
        cloud.dir.Normalize();
        cloud.transform.position= new Vector3(position_x, position_y,0.0f);
        
        Invoke("SpawnCloud", time);
    }
   
}
