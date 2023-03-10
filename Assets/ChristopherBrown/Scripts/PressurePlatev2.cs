using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlatev2 : MonoBehaviour
{
    //Door
    public GameObject Door;
    public Sprite OnSprite;
    public Sprite OffSprite;
    public GameObject light2D;
    public SpriteRenderer sr;

    //Methods

    private void Start()
    {
        light2D.SetActive(false);
        sr.sprite = OffSprite;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Open door
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OBJ"))
        {
            Door.GetComponent<Door>().Open();
            sr.sprite = OnSprite;
            light2D.SetActive(true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Close door
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OBJ"))
        {
            if (Door.GetComponent<Door>().SR.sprite == Door.GetComponent<Door>().open)
            {
                Door.GetComponent<Door>().Close();
                sr.sprite = OffSprite;
                light2D.SetActive(false);
            }
        }
        
    }




}
