using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStarManager : MonoBehaviour
{

    [SerializeField] GameObject[] cloudsObject;
    [SerializeField] int time;
    bool enable = true;
    void OnEnable()
    {
        Invoke("SpawnCloud", time);
    }

    void SpawnCloud()
    {
        if (enable)
        {
            float dir_x = Random.Range(-1, 1);
            float dir_y = Random.Range(-1, 1);




            float position_x = Random.Range(-50, 50);
            float position_y = Random.Range(-50, 50);

            int cloudIndex = (int)Random.Range(0, cloudsObject.Length);
            GameObject g = Instantiate(cloudsObject[cloudIndex], this.transform);
            ShootingStar shoot = g.GetComponent<ShootingStar>();
            shoot.dir = new Vector2(dir_x, dir_y);
            shoot.dir.Normalize();
            shoot.transform.position = new Vector3(position_x, position_y, 0.0f);
        }
        Invoke("SpawnCloud", time);
    }

    public void Hide()
    {
        var cl = GetComponentsInChildren<Cloud>();
        for (int i = 0; i < cl.Length; i++)
        {
            Destroy(cl[i].gameObject);
        }
        enable = false;
    }
    public void Show()
    {
        this.enable = true;
    }
}
