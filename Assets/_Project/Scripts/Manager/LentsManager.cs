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

    }


    public void setZoomLent()
    {
        lent = Lent.Zoom;
        lentImage.sprite = sprites[1];

    }


    public void setAntiFogLent()
    {
        lent = Lent.AntiFog;
        lentImage.sprite = sprites[2];

    }

}
