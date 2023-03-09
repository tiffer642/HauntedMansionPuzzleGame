using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveableObj : MonoBehaviour
{
    //Sprite Renderer
    private SpriteRenderer SR;

    //Sprites
    public Sprite Past;
    public Sprite Future;

    //Locations
        //IN PAST
        public Vector3 PastLocation;
        //IN Present
        public Vector3 PresentLocation;

    //Grab
    public GameObject Player;
    private Rigidbody2D RB;

    private void Start()
    {
        Player = GameObject.Find("Player");
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Past" && SR.sprite != Past)
        {
            SR.sprite = Past;
        }
        else if(SceneManager.GetActiveScene().name == "Future" && SR.sprite != Future)
        {
            SR.sprite = Future;
        }


    }

    public void UpdatePastLocation()
    {
        if (SceneManager.GetActiveScene().name == "Past")
        {
            PastLocation = transform.position;
        }
    }

    public void UpdatePresentLocation()
    {
        if (SceneManager.GetActiveScene().name == "Future")
        {
            PresentLocation = transform.position;
        }
    }
    

    public void TimeChange()
    {
        if (SceneManager.GetActiveScene().name == "Past")
        {
            transform.position = PastLocation;
        }
      /*  else if (SceneManager.GetActiveScene().name == "Future")
        {
            transform.position = PresentLocation;
        }*/
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.parent = Player.transform;
                RB.isKinematic = true;
            }
            else
            {
                transform.parent = null;
                RB.isKinematic = false;
            }
            
        }
    }


}
