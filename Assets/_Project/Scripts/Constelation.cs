using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constelation : MonoBehaviour
{
    [SerializeField]ConstellationNames name;
    ConstellationData data;
    Star[] stars;
    

    void Awake()
    {
        data = GameManager.getInstance().GetConstellationList().getConstellationData(name);
        stars = new Star[data.numEstrellas];

    
    }

   public void AddStar(Star star)
    {
        if (stars != null)
        {
            stars[star.GetIndex()] = star;
        }
    }

    // Update is called once per frame
    public void OnClick(int index)
    {
        Debug.Log("Clicked " + index);
    }

    public void OnRelease(int index)
    {
        Debug.Log("Released " + index);
    }
}
