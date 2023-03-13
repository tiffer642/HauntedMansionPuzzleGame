using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveableObj : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }



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


    //Time swap
    public bool InPast = false;



    private void Start()
    {
        Player = GameObject.Find("Player");
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player == null)
        {
            Player = GameObject.Find("Player");
        }
        //Change Sprite From Scene
        if(SceneManager.GetActiveScene().name == "Past" && SR.sprite != Past)
        {
            //Change Sprite to Past Sprite
            SR.sprite = Past;
        }
        else if(SceneManager.GetActiveScene().name == "Future" && SR.sprite != Future)
        {
            //Change Sprite to Present Sprite
            SR.sprite = Future;
        }

        if(Player == null)
        {
            Player = GameObject.Find("Player");
        }


       // UpdatePastLocation();
        UpdatePresentLocation();
        //move to past location when time changed
        if(SceneManager.GetActiveScene().name == "Past" && InPast == false)
        {
            InPast = true;
            TimeChange();
            
        }
    }
    
    public void UpdatePastLocation()
    {
            PastLocation = transform.position;
    }

    public void UpdatePresentLocation()
    {
        if (SceneManager.GetActiveScene().name == "Future")
        {
            if(InPast == true)
            {
                UpdatePastLocation();
            }
            PresentLocation = transform.position;
            InPast = false;
        }
    }
    

    public void TimeChange()
    {
        if (SceneManager.GetActiveScene().name == "Past")
        {
            Debug.Log(PastLocation);
            transform.position = PastLocation;
        }
    }


    //Grabed by Player
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
                DontDestroyOnLoad(this);
            }
            
        }
    }


}
