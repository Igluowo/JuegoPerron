using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje2 : Character
{
    // Start is called before the first frame update
    public override void Start()
    {
        name = "Lucas";
        base.Start(); // Llama al método base Start para mantener su funcionalidad
        Debug.Log(name);
    }

    protected override void Ultimate(){
        Debug.Log($"Ultimate personjae 2 ");
    }

    protected override void ChargeAttack(){
        Debug.Log($"Cargado personjae 2 ");
    }

}
