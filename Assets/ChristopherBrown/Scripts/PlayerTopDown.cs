using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    //Jumping
    private Rigidbody2D rb;
    public Animator an;
    public SpriteRenderer sr;

    public AudioClip walkS;
    public AudioSource As;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public int randomNum;
    public float timer = 40f;

    public float runSpeed = 5f;

    public bool canEnterElevator = false;
    public Transform elevatorPos;
    public bool inElevator = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        As = GetComponent<AudioSource>();
        randomNum = Random.Range(0, 10);
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down

        if(horizontal != 0 || vertical != 0)
        {
            an.SetBool("IsRunning", true);
        }
        else if(horizontal == 0 && vertical == 0)
        {
            an.SetBool("IsRunning", false);
            randomNum = Random.Range(0, 10);
            timer -= 0.01f;
            if(randomNum == 0 && timer <= 0)
            {
                an.SetTrigger("PullOutWatch");
                timer = 40f;
            }
        }

        if(horizontal > 0)
        {
            sr.flipX = false;
        }
        else if(horizontal < 0)
        {
            sr.flipX = true;
        }

        an.SetFloat("HorizontalSpeed", Mathf.Abs(horizontal));
        an.SetFloat("VerticalSpeed", vertical);

        if (canEnterElevator == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                GetComponent<BoxCollider2D>().enabled = false;
                inElevator = true;
                transform.SetParent(elevatorPos);
                transform.position = elevatorPos.position;
                elevatorPos.gameObject.GetComponent<ElevatorController>().CloseElevator();
                HidePlayer();
            }
        }
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
       
        rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    public void PlayWalkSound()
    {
        As.Stop();
        As.PlayOneShot(walkS);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Elevator"))
        {
            collision.gameObject.GetComponent<ElevatorController>().OpenElevator();
            canEnterElevator = true;
            elevatorPos = collision.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Elevator"))
        {
            collision.gameObject.GetComponent<ElevatorController>().CloseElevator();
            canEnterElevator = false;
        }
    }

    public void HidePlayer()
    {
        if(inElevator == true)
        {
            sr.sortingOrder = -100;
        }
    }

    public void ShowPlayer()
    {
        if (inElevator == true)
        {
            sr.sortingOrder = 2;
        }
    }
}
