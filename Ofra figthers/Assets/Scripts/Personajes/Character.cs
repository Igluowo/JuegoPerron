using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected string name;
    protected Health health; 
    protected Combat combat;
    protected CharacterTypeEnum characterTypeEnum;
    public bool ultimate = false;
    public float movementSpeed = 5f;

    public virtual void Awake()
    {
        AddRigidbody();
        AddHealth();
        AddCombat();
    }

    public virtual void Start()
    {
        Debug.Log(name);
    }

    void Update()
    {
        //ActivateUltimate();  // Commented out because it is not currently being used
        MoveCharacter();
        HandleAttacks();
       
    }

void HandleAttacks()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Ultimate();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            ChargeAttack();
        }
    }
    void ActivateUltimate()
    {
        if (ultimate)
        {
            Debug.Log("Ultimate on");
        }
        else
        {
            Debug.Log("Ultimate off");
        }
    }

    void MoveCharacter()
    {
        // Get the horizontal movement direction from the player's input
        float horizontalMovement = Input.GetAxis("Horizontal");

        // Define the movement speed in the horizontal direction
        float horizontalSpeed = horizontalMovement * movementSpeed;

        // Create a velocity vector based on the horizontal speed and maintain the current vertical speed
        Vector2 newMovementVelocity = new Vector2(horizontalSpeed, GetComponent<Rigidbody2D>().velocity.y);

        // Apply the new velocity to the character's Rigidbody2D
        GetComponent<Rigidbody2D>().velocity = newMovementVelocity;
    }
    //abstracto metodos
    protected abstract void Ultimate();

    protected abstract void ChargeAttack();

  
    void AddRigidbody()
    {
        if (GetComponent<Rigidbody2D>() == null)
        {
            gameObject.AddComponent<Rigidbody2D>();
        }
    }

    void AddHealth()
    {
        health = GetComponent<Health>();
        if (health == null)
        {
            health = gameObject.AddComponent<Health>();
        }
    }

    void AddCombat()
    {
        combat = GetComponent<Combat>();
        if (combat == null)
        {
            Debug.Log($"Es nulo");
            combat = gameObject.AddComponent<Combat>();
        }
    }
}
