using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ConstellationsManager : MonoBehaviour
{
    [SerializeField] private int startConstellations = 4;
    [SerializeField] private int secondLevelConstellations = 4;
    [SerializeField] private int thirdLevelConstellations = 5;

    private Constelation[] allConstelations, currentConstelations, discoveredConstelations;
    private int totalConstelationsFound = 0;
    private int actualLevelConstellations;
    private int actualLevelConstellationsFound = 0;

    void Start()
    {
        GameManager.getInstance().setConstellationManager(this);
        allConstelations = new Constelation[FindObjectsOfType<Constelation>().Length];
        discoveredConstelations = new Constelation[allConstelations.Length];
        currentConstelations = new Constelation[startConstellations];

        allConstelations = FindObjectsOfType<Constelation>();

        generateConstellations(startConstellations);
    }

    private void generateConstellations(int amount) {

        for (int i = 0; i < amount;) {
            var randomIndex = UnityEngine.Random.Range(0, allConstelations.Length);
            Constelation c = allConstelations[randomIndex];
            if (currentConstelations.Contains(c) || discoveredConstelations.Contains(c)) {
                // Repeat
            } else {
                Debug.Log(c.name);
                currentConstelations[i] = c;
                i++;
            }
        }

        actualLevelConstellations = amount;
    }

    public void nextLevel() {
        foreach (var c in allConstelations) {
            c.gameObject.SetActive(true);    
        }

        switch (GameManager.getInstance().getCurrentLevel()) {
            case 2:
                currentConstelations = new Constelation[secondLevelConstellations];
                generateConstellations(secondLevelConstellations);
                break;
            case 3:
                currentConstelations = new Constelation[thirdLevelConstellations];
                generateConstellations(thirdLevelConstellations);
                break;
            default: break;
        }
    }

    public void HideConstellations() {
        foreach (var c in allConstelations) {
            if (!currentConstelations.Contains(c)) {
                c.gameObject.SetActive(false);
            }
        }
    }

    public void ConstellationFound(Constelation cons) {
        actualLevelConstellationsFound++;
        discoveredConstelations[totalConstelationsFound] = cons;
        totalConstelationsFound++;
        CheckConditionLevel();
    }

    private void CheckConditionLevel()
    {
        if (actualLevelConstellationsFound == actualLevelConstellations) {
            actualLevelConstellationsFound = 0;
            GameManager.getInstance().LevelSolved();
        }
    }
}
