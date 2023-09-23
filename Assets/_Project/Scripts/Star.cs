using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : ValidatedMonoBehaviour
{
    [Header("Indice de la estrella, ha de estar entre 0 y el num de estrellas -1 de la constelacion")]
    [SerializeField] protected int index;
    [SerializeField, Self] AudioSource source;
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
            source.pitch = 1;
            source.Play();
            constelation.OnClick(index);
           
        }

        else if(pointInRect && Input.GetMouseButtonUp(0)) {
            source.pitch = 3;
            source.Play();
            constelation.OnRelease(index);
           

        }

        else if (!pointInRect && Input.GetMouseButtonUp(0))
        {
            constelation.OnReleaseNotClicked(index);
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
