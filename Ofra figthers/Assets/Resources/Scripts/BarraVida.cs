using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Text textoPorcentaje; // Referencia al objeto de texto para mostrar el porcentaje

    public Text TextoNumVidas;
    public float porcentaje;

    public int numVidas = 5; 
    private void Start() {
        numVidas= 5;
    }
    private void Update()
    {
        // Actualiza el texto del porcentaje
        textoPorcentaje.text = porcentaje.ToString("F0") + "%"; // "F0" para redondear a números enteros
        TextoNumVidas.text = "Vidas : " + numVidas.ToString() ;
        // Verifica si el porcentaje es igual a 100 para cambiar el color del texto
        if (porcentaje >= 100f)
        {
            
            // Cambia el color del texto a Rojo Vino
            textoPorcentaje.color = new Color(0.5f, 0f, 0.1f, 1f); // Rojo Vino: RGB(128, 0, 26)
        }
        if (numVidas <= 1)
        {
            TextoNumVidas.color = new Color(0.5f, 0f, 0.1f, 1f); // Rojo Vino: RGB(128, 0, 26)
        }
    }

    public void cambiarPorcentaje(float daño) {
        porcentaje = daño;
    }

    public void cambiarNumVida(int vida) {
        numVidas = vida;
    }
}
