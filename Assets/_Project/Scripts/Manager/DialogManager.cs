using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager : ValidatedMonoBehaviour
{
    [SerializeField] GameObject dialogContainer;
    Text dialogText;
    [SerializeField] Image scene;

    int currentPanel = 0;

    private void Awake()
    {
        GameManager.getInstance().setDialogManager(this);
    }
    private void Start()
    {

        dialogText=dialogContainer.GetComponentInChildren<Text>();
        dialogContainer.SetActive(false);
        dialogText.text = "text";
    }

    public void Show()
    {
        dialogContainer.SetActive(true);
    }

    public void Close()
    {
        dialogContainer.SetActive(false);
    }

    public void setDialog(string msg)
    {
        dialogText.text = msg;
    }

    public void setImage(Image img)
    {
        scene.sprite = img.sprite;
    }


}
