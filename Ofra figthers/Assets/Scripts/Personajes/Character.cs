using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected string name;
    protected Health health; 
    protected Combat combat;
    public CharacterTypeEnum characterTypeEnum;
    public bool ultimate = false;
    public float movementSpeed = 5f;

    void Awake()
    {
        AddRigidbody();
        AddHealth();
    }

    public virtual void Start()
    {
        Debug.Log(name);
    }

    void Update()
    {
        //ActivateUltimate();  // Commented out because it is not currently being used
        MoveCharacter();

        // Handle punch and kick actions
        if (Input.GetKeyDown(KeyCode.Z))
        {
            PerformPunch();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            PerformKick();
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

    void PerformPunch()
    {
        Debug.Log("Punch performed!");
        // Add logic for punch action here, such as triggering animations, dealing damage to other characters, etc.
    }

    void PerformKick()
    {
        Debug.Log("Kick performed!");
        // Add logic for kick action here, such as triggering animations, dealing damage to other characters, etc.
    }

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
            combat = gameObject.AddComponent<Combat>();
        }
    }
}
