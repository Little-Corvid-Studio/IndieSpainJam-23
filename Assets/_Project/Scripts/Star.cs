using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : ValidatedMonoBehaviour
{
    [Header("Indice de la estrella, ha de estar entre 0 y el num de estrellas -1 de la constelacion")]
    [SerializeField] protected int index;
    [SerializeField, Self] AudioSource source;
    [SerializeField] Constelation constelation;

    bool pointInRect = false;

    public int GetIndex() {  return index; }

    void Start()
    {
        constelation = GetComponentInParent<Constelation>();
        if (constelation == null) Debug.LogError("Constelacion nula");
        constelation.AddStar(this);
    }

    private void Update() {
        if (pointInRect && Input.GetMouseButtonUp(0)) {
            source.pitch = 3;
            source.Play();
            constelation.OnRelease(index);
        }
    }

    private void OnMouseDown() {
        source.pitch = 1;
        source.Play();
        constelation.OnClick(index);
    }

    private void OnMouseOver()
    {
        pointInRect = true;
        Debug.Log("Point In Rect True");
    }

    private void OnMouseExit()
    {
        pointInRect = false;
        Debug.Log("Point In Rect Flase");
    }
}
