using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{

    [SerializeField] private Transform hitController;
    [SerializeField] private float hitRadius;
    [SerializeField] private float hitDamage = 5;
    [SerializeField] private int player;
    [SerializeField] Animator animator;
    [SerializeField] 

    private void Hit() {
        Collider2D[] objects = Physics2D.OverlapCircleAll(hitController.position, hitRadius);
        foreach (Collider2D obj in objects)
        {
            if (obj.CompareTag("Player" + (player + 1)) || obj.CompareTag("Player" + (player - 1))) {
                Vector2 damageDirection = (obj.transform.position - hitController.position).normalized;
                obj.transform.GetComponent<Movement>().TakeDamage(hitDamage, damageDirection);
            }
        }
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire" + player))
        {
            Hit();
                animator.SetBool("isPunching", true);
        }
        else {
            animator.SetBool("isPunching", false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(hitController.position, hitRadius);
    }
}
