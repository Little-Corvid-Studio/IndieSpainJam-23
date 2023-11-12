using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum LentType { 
    Normal, 
    Zoom,
    CloudBypass,
    AntiContamination 
};

public class LentManager : MonoBehaviour
{

    private LentType currentLent;
    private Camera mainCamera;
    private CinemachineVirtualCamera virtualCamera;

    private void Start() {
        currentLent = LentType.Normal;
        mainCamera = Camera.main;
        virtualCamera = mainCamera.GetComponent<CinemachineVirtualCamera>();
    }

    public void ZoomLent() {
        if (currentLent != LentType.Zoom) {
            currentLent = LentType.Zoom;
            virtualCamera.m_Lens.OrthographicSize = 10;
        } else {
            currentLent = LentType.Normal;
            virtualCamera.m_Lens.OrthographicSize = 18;
        }
    }

    public void CloudsLent() {
        if (currentLent != LentType.CloudBypass) {
            currentLent = LentType.CloudBypass;
            virtualCamera.m_Lens.OrthographicSize = 18;
        } else {
            currentLent = LentType.Normal;
            virtualCamera.m_Lens.OrthographicSize = 18;
        }
    }

    public void ContaminationLent() {
        if (currentLent != LentType.AntiContamination) {
            currentLent = LentType.AntiContamination;
            virtualCamera.m_Lens.OrthographicSize = 18;
        } else {
            currentLent = LentType.Normal;
            virtualCamera.m_Lens.OrthographicSize = 18;
        }
    }
}
