using UnityEngine;
using UnityEngine.UI;
public class ControlAnimacion : MonoBehaviour
{
    public Animator animator; // Referencia al componente Animator
    public bool activarAnimacion = false; // Variable para controlar si se activa la animación
    public string NombrePlayer;
    public Text textNuevo;
    void Start()
    {
        // Configurar el estado inicial del componente Animator según el valor de activarAnimacion
        animator.enabled = activarAnimacion;
    }

    void Update()
    {
        // Si activarAnimacion cambia y el componente Animator está desactivado
        if (activarAnimacion && !animator.enabled)
        {
            // Activar el componente Animator
            animator.enabled = true;
            textNuevo.text = "GANADOR \n" + NombrePlayer;
        }
        // Si activarAnimacion cambia y el componente Animator está activado
        else if (!activarAnimacion && animator.enabled)
        {
            // Desactivar el componente Animator
            animator.enabled = false;
        }
    }
}
