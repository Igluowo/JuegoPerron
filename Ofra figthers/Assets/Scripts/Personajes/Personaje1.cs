using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : Character
{
    // Start is called before the first frame update

    public Transform child;
    public GameObject shot;
    public override void  Awake() {
        characterTypeEnum = CharacterTypeEnum.MELEE; 
        name = "Joao";
        base.Awake();
        CreateChildObject();
        AddShot();
        
    }
    public override void Start()
    {
        base.Start(); // Llama al método base Start para mantener su funcionalidad
        Debug.Log(name);
        Debug.Log(shot);
    }

    protected override void Ultimate(){
        Debug.Log($"Ultimate personjae 1 ");
    }

    protected override void ChargeAttack(){
        Debug.Log($"Cargado personjae 1 ");
        Instantiate(shot,child.position,child.rotation);
    }

    void CreateChildObject()
    {
        GameObject childObject = new GameObject("childObject");
        childObject.transform.parent = this.transform;
        childObject.transform.localPosition = Vector3.zero;
        childObject.transform.localRotation = Quaternion.identity;
        childObject.transform.localScale = Vector3.one;

        child = childObject.transform;
    }

    void AddShot()
{
    // Cargar el prefab desde la carpeta Resources
    shot = Resources.Load<GameObject>("Shot");
    
}




    
}
