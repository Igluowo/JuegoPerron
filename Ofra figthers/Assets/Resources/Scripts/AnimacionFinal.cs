using UnityEngine;

public class AnimacionFinal : MonoBehaviour
{
    public Animation animacion; // Referencia al componente Animation
    public string nombreClip = "NombreDeTuAnimacion"; // Nombre del clip de animación que deseas reproducir

    // Método para iniciar la animación
    public void Iniciar()
    {
        // Verificar si la animación está configurada y si no se está reproduciendo actualmente
        if (animacion != null && !animacion.isPlaying)
        {
            // Reproducir la animación con el nombre especificado
            animacion.Play(nombreClip);
        }
    }

    void Update()
    {
        // Verificar si la condición es verdadera para iniciar la animación
        if (tuCondicionEsTrue)
        {
            Iniciar(); // Llamar al método para iniciar la animación
        }
    }
}
