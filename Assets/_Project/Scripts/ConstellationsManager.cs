using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstellationsManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] int numConstellationsTotal;
    [SerializeField] string nextScene;
    bool[] constellationsCompletes;
    void Start()
    {
        constellationsCompletes = new bool[numConstellationsTotal];
    }

    void Update()
    {
    }

    public void CheckConditionLevel(int numConstellation)
    {
        constellationsCompletes[numConstellation] = true;
        int cont = 0;
        for (int i = 0; i < numConstellationsTotal; i++)
        {
            if (constellationsCompletes[i] == true)
            {
                cont++;
            }
        }

        if (cont == numConstellationsTotal) {gameManager.ChangeScene(nextScene);}
    }
}
