using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager : MonoBehaviour
{
    [SerializeField] GameObject dialogContainer;
    Text dialogText;
    [SerializeField] Image [] historyPanel;

    int currentPanel = 0;

    private void Start()
    {
        dialogText=dialogContainer.GetComponentInChildren<Text>();
        dialogContainer.SetActive(false);
    }

    private void Update()
    {
        
    }



}
