using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionImage : MonoBehaviour
{
    [SerializeField,Self]SpriteRenderer sprite;
    void Start()
    {
        sprite.enabled= false;
    }

   public void Show()
    {
        sprite.enabled= true;
    }
}
