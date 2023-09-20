using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [Header("Indice de la estrella, ha de estar entre 0 y el num de estrellas -1 de la constelacion")]
    [SerializeField] protected int index;
   
    Constelation constelation;

    bool pointInRect = false;

    public int GetIndex() {  return index; }
    void Start()
    {
        constelation= GetComponentInParent<Constelation>();
        if (constelation == null) Debug.LogError("Constelacion nula");
        constelation.AddStar(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(pointInRect && Input.GetMouseButtonDown(0)) {
            constelation.OnClick(index);
        }

        else if(pointInRect && Input.GetMouseButtonUp(0)) {
            constelation.OnRelease(index);
        }
        
    }

    private void OnMouseOver()
    {
        pointInRect = true;
    
    }

    private void OnMouseExit()
    {
        pointInRect = false;
    }
}
