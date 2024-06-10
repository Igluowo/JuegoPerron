using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : Character
{
    // Start is called before the first frame update

    public override void Start()
    {
        name = "Joao";
        base.Start(); // Llama al método base Start para mantener su funcionalidad
        Debug.Log(name);
    }

}
