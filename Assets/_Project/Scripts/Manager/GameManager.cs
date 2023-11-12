using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : ValidatedMonoBehaviour
{
    private static GameManager mInstance_ = null;

    private DialogManager mDialogManager = null;
    private StressManager mStressManager = null;
    private ConstellationsManager mConstellationsManager = null;

    [Header("Game loop params")]
   
    [SerializeField] SpriteRenderer[] scenesBackground;


    [Space(10)]
    [Header("Dialog")]
    [SerializeField] public StoryManager[] storyManagers;
    [SerializeField] Sprite[] images; 


    public ConstellationList ConstellationList = new ConstellationList();
    protected bool[] constelationsToFind;

    Camera cam;
    private int currentLevel;
    public static GameManager getInstance() { return mInstance_; }
    public ConstellationList GetConstellationList() { return ConstellationList; }

    public Sprite getNote(int index) { return images[index]; }
    public void setDialogManager(DialogManager dialogManager) { mDialogManager = dialogManager; }
    public void setStressManager(StressManager stressManager) { mStressManager = stressManager; }
    public void setConstellationManager(ConstellationsManager constellationsManager) { mConstellationsManager = constellationsManager; }

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

    public void OnGameStart()
    {
/*        constelationsToFind = new bool[(int)System.Enum.GetValues(typeof(ConstellationNames)).Length];
      
        for (int i = 0; i < constelationsToFind.Length; i++)
        {
            constelationsToFind[i] = true;
        }*/

        currentLevel = 1;
        cam = Camera.main;

        SceneManager.LoadScene("Game");
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LevelSolved()
    {
        currentLevel++;
        mDialogManager.startStoryPanel(storyManagers[currentLevel]);
    }

    public void OnDialogFinished()
    {
        mStressManager.ResetStress();
        mConstellationsManager.nextLevel();
        mConstellationsManager.HideConstellations();
        mDialogManager.openCloseStoryPanel(false);
    }

    public int getCurrentLevel() { return currentLevel; }
}
