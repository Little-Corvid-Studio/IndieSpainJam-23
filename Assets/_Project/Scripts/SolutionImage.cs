using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionImage : ValidatedMonoBehaviour
{
    
    [SerializeField,Self]SpriteRenderer sprite;
    Constelation constelation;
    void Start()
    {
        constelation= GetComponentInParent<Constelation>();
        constelation.setSolutionImage(this);
        sprite.enabled = false;
    }

   public void Show()
    {
        sprite.enabled= true;
    }
}
