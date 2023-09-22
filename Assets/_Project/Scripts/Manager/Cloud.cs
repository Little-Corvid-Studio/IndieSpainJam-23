using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : ValidatedMonoBehaviour
{
    public Vector2 dir;
    [SerializeField] float speed;
    [SerializeField] float time;

    private void Start()
    {
        Destroy(this.gameObject,time);
    }

    private void FixedUpdate()
    {
        this.transform.position += new Vector3(dir.x, dir.y,0.0f) * speed;
    }
}
