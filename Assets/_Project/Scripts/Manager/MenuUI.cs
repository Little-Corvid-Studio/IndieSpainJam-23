using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{

    [Header("Credits")]
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject credits;
    [SerializeField] private float speed = 80.0f;
    [SerializeField] private float limit = 2000;

    [Header("Controls")]
    [SerializeField] private GameManager controlsPanel;

    private Vector3 creditsDefaultPos;

    private void Update() {
        if (creditsPanel.activeSelf) {
            if (credits.transform.position.y < limit) {
                credits.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            } else {
                creditsPanel.SetActive(false);
                credits.transform.position = creditsDefaultPos;
            }
        }
    }

    public void enableCreditsPanel() {
        creditsDefaultPos = credits.transform.position;
        creditsPanel.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
    }
}
