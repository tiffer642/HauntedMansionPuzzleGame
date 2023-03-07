using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimeChangePopUp : MonoBehaviour
{
    private GameObject InteractPopup;


    private ScenesManager SCM;


    // Start is called before the first frame update
    void Start()
    {
        InteractPopup = GameObject.Find("Interact Popup");
        SCM = GameObject.Find("Scene Manager").GetComponent<ScenesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            InteractPopup.SetActive(true);
        }
        else
        {
            if(InteractPopup.activeSelf == true)
            {
                InteractPopup.SetActive(true);
            }

        }


        if (collision.gameObject.CompareTag("Player") && InteractPopup.activeSelf == true)
        {
            if (Input.GetKey(KeyCode.E) && SceneManager.GetActiveScene().name != "Past")
            {
                SCM.LoadPast();
            }
            else if(Input.GetKey(KeyCode.E) && SceneManager.GetActiveScene().name != "Future")
            {
                SCM.LoadFuture();
            }
        }

    }

}
