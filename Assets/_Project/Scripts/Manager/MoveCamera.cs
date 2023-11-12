using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    private Camera mainCamera;

    private void Awake() {
        mainCamera = Camera.main;
    }
    
    public void MoveUp() {
        mainCamera.transform.Translate(new Vector2(0, 2));
    }

    public void MoveDown() {
        mainCamera.transform.Translate(new Vector2(0, -2));
    }

    public void MoveRight() {
        mainCamera.transform.Translate(new Vector2(2, 0));
    }

    public void MoveLeft() {
        mainCamera.transform.Translate(new Vector2(-2, 0));
    }
}
