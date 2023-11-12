using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public struct Conection
{
    public int PointA;
    public int PointB;
}

public class Constelation : MonoBehaviour
{
    [SerializeField] ConstellationNames CName;
    [SerializeField] GameObject visualConnection;
   
    
    ConstellationData data;
    Conection currentConection;
    Star[] stars;
    SolutionImage solutionSprite;

    GameObject connectingObj;
    LineRenderer line;

    private Transform tempTransform;

    [SerializeField] ConstellationsManager constellationsManager;

    void Awake() {
        data = GameManager.getInstance().GetConstellationList().getConstellationData(CName);
        stars = new Star[data.numEstrellas];
        constellationsManager = GetComponentInParent<ConstellationsManager>(includeInactive: true);
    }

    public void setSolutionImage(SolutionImage sol)
    {
        solutionSprite = sol;
    }

    public void AddStar(Star star)
    {
        if (stars != null) {
            try {
                stars[star.GetIndex()] = star;
            } catch (Exception e) {
                Debug.Log(name);
                Debug.Log(e.Message);
            }
        } else {
            Debug.Log("Stars es null");
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

    public void OnClick(int index)
    {
        currentConection = new Conection();
        currentConection.PointA = index;
    }

    public void OnRelease(int index)
    {
        currentConection.PointB = index;
        checkSolution();
    }

    private void checkSolution()
    {
        if (currentConection.PointA != -1 && currentConection.PointB != -1 && data.conexiones[currentConection.PointA, currentConection.PointB] && data.conexiones[currentConection.PointB, currentConection.PointA])
        {
            connectingObj = Instantiate(visualConnection, this.transform);
            line = connectingObj.GetComponent<LineRenderer>();

            line.SetPosition(0, stars[currentConection.PointA].transform.position);
            line.SetPosition(1, stars[currentConection.PointB].transform.position);
            data.conexiones[currentConection.PointA, currentConection.PointB] = false;
            data.conexiones[currentConection.PointB, currentConection.PointA] = false;


            if (isSolved())
            {
                solutionSprite.Show();
                constellationsManager.ConstellationFound(this);
            }
        }
        currentConection.PointA = -1;
        currentConection.PointB = -1;
        line = null;
        connectingObj = null;
    }
}
