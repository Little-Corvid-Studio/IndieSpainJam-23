using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class NodeConnector : ValidatedMonoBehaviour
{
    [SerializeField, Self] protected LineRenderer lineRenderer;
    Camera cam;
    void Start()
    {
        
        cam= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //rectangulo de clickado (clickbox)
        Rect dest = new Rect();
        dest.x= transform.position.x;
        dest.y= transform.position.y;
        dest.width= this.transform.localScale.x;
        dest.height= this.transform.localScale.y;


        Vector3 screen = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
            // y mirar que el raton esta dentro de unos limites)
        {
            lineRenderer.SetPosition(0, this.transform.position);
            lineRenderer.SetPosition(1,cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)));
        }
    }
}
