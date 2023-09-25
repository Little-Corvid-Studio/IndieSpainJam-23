using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : Singleton<DialogManager>
{
    [SerializeField] private GameObject dialogPanel;
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI text;

    [SerializeField] private GameManager gameManager;

    private bool animatedDialog;

    public void startStoryPanel(StoryManager story) {
        openCloseStoryPanel(true);
        loadSequence(story);

        nextSequence();
    }

    private void Start() {
        gameManager.setDialogManager(this);
        gameManager.OnSolvedLevel(0);
        storySequence = new Queue<StoryScene>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            if (animatedDialog) {
                nextSequence();
            }
        }
    }

    private Queue<StoryScene> storySequence;

    private void nextSequence() {

        if (storySequence.Count == 0) {
            gameManager.OnDialogFinished();
            return;
        }

        StoryScene nextSequence = storySequence.Dequeue();
        image.sprite = nextSequence.image;

        if (nextSequence.isItalic) {
            text.fontStyle = FontStyles.Italic;
        } else {
            text.fontStyle = FontStyles.Normal;
        }

        ShowAnimatedText(nextSequence.text);
    }

    private void loadSequence(StoryManager story) {
        if (story.scene == null || story.scene.Length <= 0) {
            return;
        }

        for (int i = 0; i < story.scene.Length; i++) {
            storySequence.Enqueue(story.scene[i]);
        }
    }

    public void openCloseStoryPanel(bool state) {
        dialogPanel.SetActive(state);
    }

    private IEnumerator TextAnimator(string unAnimatedText) {
        animatedDialog = false;

        text.text = "";
        char[] lyrics = unAnimatedText.ToCharArray();
        for (int i = 0; i < lyrics.Length; i++) {
            text.text += lyrics[i];
            yield return new WaitForSeconds(0.04f);
        }

        animatedDialog = true;
    }

    private void ShowAnimatedText(string unAnimatedText) {
        StartCoroutine(TextAnimator(unAnimatedText));
    }
}
