using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : ValidatedMonoBehaviour
{
    private static GameManager mInstance_ = null;

    private DialogManager mDialogManager = null;

    [Header("Game loop params")]
    [Header("Orden de las constelaciones a encontrar")]
    [SerializeField] ConstellationNames[] levelNames;
    [Header("Nº de constelaciones a encontrar en el nivel. \n" +
        "Dejad el primero a 0 para la introduccion")]
    [SerializeField] int[] numberOfConstellationsPerLevel;
    [SerializeField] SpriteRenderer[] scenesBackground;


    [Space(10)]
    [Header("Dialog")]
    [SerializeField] string[] levelDialogue;
    [SerializeField] Image[] images; 


    public ConstellationList ConstellationList = new ConstellationList();
    protected bool[] constelationsToFind;

    Camera cam;
    int currentLevel;
    int constelationsToFindInThatLevel;
    public static GameManager getInstance() { return mInstance_; }
    public ConstellationList GetConstellationList() { return ConstellationList; }

    public void setDialogManager(DialogManager dialogManager) { mDialogManager = dialogManager; }
 
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
      
        for(int i = 0; i < constelationsToFind.Length; i++)
        {
            constelationsToFind[i] = true;
        }

        currentLevel = 0;
        cam= Camera.main;
    }

    public void OnConstellationFound(ConstellationNames name)
    {
        constelationsToFind[(int)name] = false;
        constelationsToFindInThatLevel++;
        if (numberOfConstellationsPerLevel[currentLevel] == constelationsToFindInThatLevel)
        {
            //nivel resuelto
            Debug.Log("AAAA");
        }

    }

    public void OnTimeOver()
    {
        currentLevel++;
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void OnSolvedLevel(int level)
    {

        mDialogManager.Show();
        
        switch (level)
        {
            case 0:
               
                break; 
            case 1:
        
                break;
            case 2:
                
                break;
            case 3:
                
                break;
        }

    }

    public void OnDialogFinished()
    {
        mDialogManager.Close();
        currentLevel++;

        
    }

}
