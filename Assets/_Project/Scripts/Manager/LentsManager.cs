using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LentsManager : ValidatedMonoBehaviour
{
    enum Lent { Normal, Zoom, AntiFog};

    [Header("Lent params")]
    [SerializeField]
    Image lentImage;
    [SerializeField]
    Sprite[] sprites;

    [SerializeField]
    CloudManager cloudManager;

    Lent lent;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        lent = new Lent();
    }

    public void setNormalLent()
    {
        lent = Lent.Normal;
        lentImage.sprite = sprites[0];
        cam.orthographicSize = 20;
        cloudManager.Show();
    }


    public void setZoomLent()
    {
        lent = Lent.Zoom;
        lentImage.sprite = sprites[1];
        cam.orthographicSize = 10;
        cloudManager.Show();
    }


    public void setAntiFogLent()
    {
        lent = Lent.AntiFog;
        lentImage.sprite = sprites[2];
        cloudManager.Hide();
    }

}
