using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitManager : MonoBehaviour
{
    ///Este script solo esta para asignar el game manager una vez abierto el juego 
    /// y no cada vez que se vuelva al menu, evita problemas

    private void Start()
    {
        GameManager.getInstance().ChangeScene("Menu");
    }

}
