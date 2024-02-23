using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CambiarCuandoTermina : MonoBehaviour
{
    
    public bool SalirMenu = false;

    // Update is called once per frame
    void Update()
    {
        if (SalirMenu == true)
        {
            SceneManager.LoadScene(1);
        }
    }
}
