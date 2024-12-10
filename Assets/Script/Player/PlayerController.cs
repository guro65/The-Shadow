using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private int vida;
    [SerializeField] private int dano;
    [SerializeField] private float speed = 3f;
    [SerializeField] private Animator animator;
    [SerializeField] private bool facada;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private SpriteRenderer sprite;
    private float horizontal;
    private float vertical;
    private void Awake()
    {
        facada = false;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
            animator.SetBool("Andar", true);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            sprite.flipX = true;
            animator.SetBool("Andar", true);
        }
        else
        {

        }
        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            facada = true;
            animator.SetTrigger("Facada");
            Atacar();
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Andar", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Andar", true);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Andar", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Facada");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 1f);
            if(hit.collider != null)
            {
                if (hit.collider.CompareTag("Destrutivel"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }

        }
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");



        transform.position += new Vector3(speed * Time.fixedDeltaTime * horizontal, speed * Time.fixedDeltaTime * vertical, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnCollisionStay2D(Collision2D collision)
    {

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

    }
}