using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    //Door
    public GameObject Door;


    public bool keepOpen = false;



    //Methods

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Open door
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OBJ") && Door.gameObject != null)
        {
            Door.GetComponent<Door>().Open();


        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Close door
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OBJ") && Door.gameObject != null)
        {
            if (Door.GetComponent<Door>().SR.sprite == Door.GetComponent<Door>().open && keepOpen == false)
            {
                Door.GetComponent<Door>().Close();
            }
        }
        
    }




}
