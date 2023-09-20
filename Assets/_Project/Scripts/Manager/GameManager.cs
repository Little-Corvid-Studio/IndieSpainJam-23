using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : ValidatedMonoBehaviour
{
    private static GameManager mInstance_ = null;

    [SerializeField] string[] scenes;

    public ConstellationList ConstellationList = new ConstellationList();
    public bool[] constelationsToFind;


    public static GameManager getInstance() { return mInstance_; }
    public ConstellationList GetConstellationList() { return ConstellationList; }


    void Awake()
    {
        if (mInstance_ == null)
        {
            mInstance_ = this;
            
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    /// <summary>
    /// Generamos una lista de las constelaciones a buscar de modo que no sea la misma
    /// y así dar rejugabilidad
    /// </summary>
    public void OnGameStart()
    {
        constelationsToFind= new bool[(int)ConstellationNames.NUM_CONSTELLATIONS];
        //50% cada una de 
        for(int i = 0; i < constelationsToFind.Length; i++)
        {
            constelationsToFind[i] = (int)Random.Range(-1, 2) == 1;
            Debug.Log(i + " " + constelationsToFind[i]);
        }
    }
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
