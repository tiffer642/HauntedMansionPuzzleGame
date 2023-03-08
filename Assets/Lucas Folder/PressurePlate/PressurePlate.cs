using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    //Door object that will open
    public GameObject Door;

    //animator 
    private Animator animator;







    //Method

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OBJ"))
        {
           // Door.GetComponent< Door Script >().  Door open function  ;
        }
        else
        {
            //if(Door.GetComponent)
           // {

           // }
        }
    }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
