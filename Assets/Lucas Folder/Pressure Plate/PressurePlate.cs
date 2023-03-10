using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    //Door
    public GameObject Door;






    //Methods

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Open door
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OBJ"))
        {
            Door.GetComponent<Door>().Open();
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
            }
        }
        
    }




}
