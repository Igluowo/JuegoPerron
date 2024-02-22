using UnityEngine;

public class DestruirCanvas : MonoBehaviour
{
    public bool destruirCanvas = false; // Esta variable indica si se debe destruir el canvas

    void Update()
    {
        if (destruirCanvas)
        {
            // Busca el componente Canvas del objeto actual
            Canvas canvas = GetComponent<Canvas>();

            // Si se encuentra el componente Canvas, destruye el objeto
            if (canvas != null)
            {
                Destroy(canvas.gameObject);
            }
            else
            {
                Debug.LogWarning("El objeto no tiene un componente Canvas adjunto.");
            }
        }
    }
}
