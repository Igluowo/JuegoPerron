using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraVida : MonoBehaviour
{
    public GameObject player;
    public Image barraDeVida;
    public float vidaActual;
    public float vidaMaxima = 100;

    // Start is called before the first frame update
    private void Start()
    {
        if (player.CompareTag("Player1")) { 
            vidaActual = player.GetComponent<Movement>().damageTaked;
        }
    }

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }
}
