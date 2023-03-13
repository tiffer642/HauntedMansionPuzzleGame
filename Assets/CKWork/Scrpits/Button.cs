using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    
    public GameObject door;
    public DoorController doorController;
    public bool isWorking;


    private SpriteRenderer spriteRenderer;
    public bool isPlayerClose = false;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (door != null)
        {
            doorController = door.GetComponent<DoorController>();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isPlayerClose == true)
        {
            if(spriteRenderer.flipX == false)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }

            if(door != null)
            {
                if (doorController.isOpen)
                {
                    doorController.CloseDoor();
                }
                else
                {
                    doorController.OpenDoor();
                }
            }


            SpawnBreaker();


        }
        
   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerClose = true;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerClose = false;
        }

    }

    //spawn object to destroy breakable obj

    public GameObject breakerSpawn;
    public GameObject breakerOBJ;
    
    public void SpawnBreaker()
    {
        if(breakerSpawn != null)
        {
            Instantiate(breakerOBJ, breakerSpawn.transform.position, breakerOBJ.transform.rotation);
            breakerSpawn = null;
        }
    }




}
