using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public float damage;

    void Start()
    {
        
    }

    void Update()
    {
        HandleAttacks();
    }

    void HandleAttacks()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Punch();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Kick();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Ultimate();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            ChargeAttack();
        }
    }

    void Punch()
    {
        Debug.Log("Punch performed!");
        // Add logic for punch action here
    }

    void Kick()
    {
        Debug.Log("Kick performed!");
        // Add logic for kick action here
    }

    void Ultimate()
    {
        Debug.Log("Ultimate performed!");
        // Add logic for ultimate action here
    }

    void ChargeAttack()
    {
        Debug.Log("Charge Attack performed!");
        // Add logic for charge attack action here
    }
}
