using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressManager : ValidatedMonoBehaviour
{
    [SerializeField] private Image stressImage;

    [SerializeField] private float startStress;
    [SerializeField] private float maxStress;

    [SerializeField] private StoryManager maxStressScene;

    public float ActualStress { get; private set; }
    private DialogManager dialogManager;

    private void Start() {
        dialogManager = GetComponent<DialogManager>();
        ActualStress = startStress;
        InvokeRepeating(nameof(GainStress), 1, 5);
    }

    private void Update() {
        stressImage.fillAmount = Mathf.Lerp(stressImage.fillAmount,
            ActualStress / maxStress, 10f * Time.deltaTime);
    }

    private void GainStress() {
        if (ActualStress < maxStress) {
            ActualStress += 1;
            if (ActualStress >= maxStress) {
                dialogManager.startStoryPanel(maxStressScene);
            }
        }
    }
}
