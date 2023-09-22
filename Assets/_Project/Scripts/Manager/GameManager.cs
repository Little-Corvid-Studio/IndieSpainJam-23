using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : ValidatedMonoBehaviour
{
    private static GameManager mInstance_ = null;

    [SerializeField] string[] levelDialogue;
    
    public ConstellationList ConstellationList = new ConstellationList();
    public bool[] constelationsToFind;

    Camera cam;
    int currentLevel;
    int currentDialog;
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
            constelationsToFind[i] = true;
        }

        currentLevel = 0;
        currentDialog = 0;
        cam= Camera.main;
    }

    public void OnConstellationFound(ConstellationNames name)
    {
        

    }

    public void OnTimeOver()
    {
        currentLevel++;
    }


    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void DialogChange(Text text)
    {
        text.text = levelDialogue[currentDialog];
        currentDialog++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
