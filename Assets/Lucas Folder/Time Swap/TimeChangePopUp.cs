using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class TimeChangePopUp : MonoBehaviour
{
    private GameObject InteractPopup;


    private ScenesManager SCM;


    // Start is called before the first frame update
    void Start()
    {
        InteractPopup = GameObject.Find("TimeChange PopUp");
        SCM = GameObject.Find("Scene Manager").GetComponent<ScenesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(InteractPopup.gameObject.activeSelf == true)
        {
            if (Input.GetKey(KeyCode.E) && SceneManager.GetActiveScene().name != "Past")
            {
                SCM.LoadPast();
                Debug.Log("Past");
            }
            else if (Input.GetKey(KeyCode.E) && SceneManager.GetActiveScene().name != "Future")
            {
                SCM.LoadFuture();
                Debug.Log("Future");
            }
        }
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            InteractPopup.gameObject.SetActive(true);
        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (InteractPopup.gameObject.activeSelf == true)
            {
                InteractPopup.gameObject.SetActive(true);
            }
        }
    }

}
