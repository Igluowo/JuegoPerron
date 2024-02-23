using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float speed = 8;
    [SerializeField] private float alturaSalto = 25;
    [SerializeField] private float health = 5;
    [SerializeField] private KeyCode jumpKey = KeyCode.W;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;
    [SerializeField] private float forceMagnitude = 5f;
    public float damageTaked = 0f;
    public Respawn respawn;
    [SerializeField] private Transform firePoint;
    public Bullet bullet;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.drag = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            RealizarSalto();
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }

    void HandleMovementInput()
    {
        float horizontalInput = 0f;

        if (Input.GetKey(leftKey))
        {
            horizontalInput = 1f;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (Input.GetKey(rightKey))
        {
            horizontalInput = 1f;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        Vector3 movementDirection = new Vector3(horizontalInput, 0f, 0f);
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

    void RealizarSalto()
    {
        isJumping = true;
        rb.velocity = new Vector2(rb.velocity.x, alturaSalto);
    }

    public void TakeDamage(float damage, Vector2 damageDirection)
    {
        damageTaked += damage;
        forceMagnitude += damageTaked;
        Vector2 invertedDirection = damageDirection.normalized;
        rb.AddForce(invertedDirection * forceMagnitude, ForceMode2D.Impulse);
    }

    void OnBecameInvisible()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
        else {
            respawn.DeadPlayer();
            health--;
            damageTaked = 0f;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Street"))
        {
            ApplyForceUpward();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {
            OnLand();
        }
    }

    void ApplyForceUpward()
    {
        damageTaked += 10;
        rb.AddForce(Vector2.up * damageTaked, ForceMode2D.Impulse);
    }

    void OnLand()
    {
        isJumping = false;
    }

}
