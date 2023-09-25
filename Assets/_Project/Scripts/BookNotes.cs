using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookNotes : ValidatedMonoBehaviour
{
    [SerializeField, Self] Image img;
    [SerializeField] ConstellationNames initConstellation;
    [SerializeField] int numConstelations;
    int current = 0;
    void Start()
    {
        img.sprite = GameManager.getInstance().getNote((int)initConstellation);
    }

    public void OnClick()
    {
        current++;
        img.sprite = GameManager.getInstance().getNote((int)initConstellation + current % numConstelations);
    }
}
