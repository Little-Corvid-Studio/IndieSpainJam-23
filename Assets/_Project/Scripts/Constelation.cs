using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
    SolutionImage solutionSprite;

    GameObject connectingObj;
    LineRenderer line;
    void Awake()
    {
        data = GameManager.getInstance().GetConstellationList().getConstellationData(name);
        stars = new Star[data.numEstrellas];
      
        Debug.Log(solutionSprite!=null);
    
    }

    public void setSolutionImage(SolutionImage sol)
    {
        solutionSprite = sol;
    }
    public void AddStar(Star star)
    {
        if (stars != null)
        {
            stars[star.GetIndex()] = star;
        }

        for(int i=0;i<stars.Length; i++) {
            Debug.Log(name +" "+stars[i] != null);
        }
    }

    

    bool isSolved()
    {
        
        for(int i=0; i<stars.Length; i++)
        {
            for(int j = 0; j < stars.Length; j++)
            {
                if (data.conexiones[i, j]) return false;
            }
        }
       
        return true;

        
    }

    // Update is called once per frame
    public void OnClick(int index)
    {

        currentConection = new Conection();
        currentConection.PointA = index;

        connectingObj = Instantiate(visualConnection, this.transform);
        line= connectingObj.GetComponent<LineRenderer>();

        line.SetPosition(0, stars[index].transform.position);
        line.SetPosition(1, stars[index].transform.position);

        Debug.Log("Clicked " + index);
        
    }

    public void OnReleaseNotClicked(int index)
    {
    }

    public void OnRelease(int index)
    {
        currentConection.PointB= index;
        Debug.Log("Released " + index);

        checkSolution();

    }

    private void checkSolution()
    {
        Debug.Log(currentConection.PointA + " " + currentConection.PointB);
        if (currentConection.PointA != -1 && currentConection.PointB != -1 && data.conexiones[currentConection.PointA, currentConection.PointB] && data.conexiones[currentConection.PointB, currentConection.PointA])
        {
        
            line.SetPosition(0, stars[currentConection.PointA].transform.position);
            line.SetPosition(1, stars[currentConection.PointB].transform.position);
            data.conexiones[currentConection.PointA, currentConection.PointB] = false;
            data.conexiones[currentConection.PointB, currentConection.PointA] = false;


            if (isSolved())
            {
                Debug.Log("Hiii");
                solutionSprite.Show();
                GameManager.getInstance().OnConstellationFound(name);
            }



        }
        currentConection.PointA = -1;
        currentConection.PointB = -1;
        line = null;
        connectingObj = null;

    }
       



    
}
