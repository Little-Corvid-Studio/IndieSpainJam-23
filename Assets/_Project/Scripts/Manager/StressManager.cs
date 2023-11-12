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

    [SerializeField, Tooltip("Cantidad de Estrés que se gana")] private float stressGainAmount = 1f;
    [SerializeField, Tooltip("Cada cuantos segundos se gana Estrés")] private float stressGainSpeed = 5f;

    [SerializeField] private StoryManager maxStressScene;

    public float ActualStress { get; set; }
    private DialogManager dialogManager;

    private void Start() {
        GameManager.getInstance().setStressManager(this);
        dialogManager = GetComponent<DialogManager>();
        ActualStress = startStress;
        InvokeRepeating(nameof(GainStress), 1, stressGainSpeed);
    }

    private void Update() {
        stressImage.fillAmount = Mathf.Lerp(stressImage.fillAmount,
            ActualStress / maxStress, 10f * Time.deltaTime);
    }

    private void GainStress() {
        if (ActualStress < maxStress) {
            ActualStress += stressGainAmount;
            if (ActualStress >= maxStress) {
                dialogManager.startStoryPanel(maxStressScene);
            }
        }
    }

    public void ResetStress() {
        ActualStress = startStress;
    }
}
