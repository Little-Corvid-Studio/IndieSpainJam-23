using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{

    public Vector2 dir;
    [SerializeField] float speed;
    [SerializeField] float time;

    bool pointInRect = false;
    bool clicked = false;

    private void Start()
    {
        Destroy(this.gameObject, time);
    }

    private void FixedUpdate()
    {
        if (pointInRect && Input.GetMouseButtonDown(0))
        {
            clicked = true;
        }
        this.transform.position += new Vector3(dir.x, dir.y, 0.0f) * speed * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        pointInRect = true;
    }
}
