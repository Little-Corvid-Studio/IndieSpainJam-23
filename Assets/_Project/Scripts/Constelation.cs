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
    SolutionImage solutionSprite;

    GameObject connectingObj;
    LineRenderer line;
    void Awake()
    {
        data = GameManager.getInstance().GetConstellationList().getConstellationData(name);
        stars = new Star[data.numEstrellas];
        solutionSprite= GetComponentInChildren<SolutionImage>();
        Debug.Log(solutionSprite!=null);
    
    }
    private void Update()
    {
        if (line != null)
        {
            line.SetPosition(1, GameManager.getInstance().getMousePoint());
        }
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

        connectingObj = Instantiate(visualConnection, this.transform);
        line= connectingObj.GetComponent<LineRenderer>();

        line.SetPosition(0, stars[index].transform.position);
        line.SetPosition(1, stars[index].transform.position);

        Debug.Log("Clicked " + index);
        
    }

    public void OnReleaseNotClicked(int index)
    {
        currentConection.PointA = -1;
        currentConection.PointB = -1;

        Destroy(connectingObj.gameObject);
        connectingObj = null;
        line = null;
    }

    public void OnRelease(int index)
    {
        currentConection.PointB= index;
        Debug.Log("Released " + index);
        line.SetPosition(1, stars[index].transform.position);
        line = null;
        connectingObj = null;

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
