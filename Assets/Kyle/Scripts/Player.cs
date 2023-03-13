using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Jumping
    private Rigidbody2D playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;

    //Movement 
    public float moveSpeed = 10.0f;
    public float turnSpeed;
    private float horizontalInput;
    private float verticalInput;
    //Animation
    //public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
       // animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
       verticalInput = Input.GetAxis("Vertical");
       // animator.SetFloat("verticalInput", verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
           isOnGround = false;

            
       }

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;

        //animator.SetBool("isOnGround", isOnGround);
    }
}
