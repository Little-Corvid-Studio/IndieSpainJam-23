using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Conection
{
    public int PointA;
    public int PointB;
}
public class Constelation : MonoBehaviour
{
    [SerializeField]ConstellationNames name;
    [SerializeField] GameObject visualConnection;
   
    ConstellationData data;
    Conection currentConection;
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

        currentConection = new Conection();
        currentConection.PointA = index;


        Debug.Log("Clicked " + index);
        
    }

    public void OnRelease(int index)
    {
        currentConection.PointB= index;
        Debug.Log("Released " + index);


    }

    private void checkSolution()
    {
        bool isSol = false;
        for (int i = 0; i < stars.Length&&!isSol; i++) {
            for (int j = 0; j < data.conexiones.GetLength(1) &&!isSol; j++) {
                if ((currentConection.PointA == stars[i].GetIndex() && currentConection.PointB == stars[j].GetIndex()) 
                    ||(currentConection.PointB == stars[i].GetIndex() && currentConection.PointA == stars[j].GetIndex()))
                {
                    isSol = true; 
                } 
            }
        }
        if (isSol)
        {
            //Unir aqui
        }
    }
}
