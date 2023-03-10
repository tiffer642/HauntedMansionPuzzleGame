using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorController : MonoBehaviour
{
    public SpriteRenderer SR;
    public Sprite OpenSprite;
    public Sprite ClosedSprite;
    public bool isOpen;

    private Collider2D collider_;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        collider_ = GetComponent<Collider2D>();
    }

    
    public void OpenDoor()
    {
        collider_.enabled = false;
        SR.sprite = OpenSprite;
        isOpen = true;

    }
    public void CloseDoor()
    {
        collider_.enabled = true;
        SR.sprite = ClosedSprite;
        isOpen = false;
    }
}
