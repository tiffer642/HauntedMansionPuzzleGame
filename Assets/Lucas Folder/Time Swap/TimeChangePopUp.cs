using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class TimeChangePopUp : MonoBehaviour
{


    public ScenesManager SM;


    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("Scene Manager").GetComponent<ScenesManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SM.IntPopup(true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SM.IntPopup(false);
        }
    }


}
