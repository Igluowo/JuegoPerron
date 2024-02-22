using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class CambiarNivel : MonoBehaviour
{
    public bool pasarNivel;
    public int indiceNivel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Cambiar(indiceNivel);
        }
    }

    public void Cambiar(int indice){
        SceneManager.LoadScene(indice);
    }
}
