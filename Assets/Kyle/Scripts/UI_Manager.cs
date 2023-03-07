using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class UI_Manager : MonoBehaviour
{
    public KeyCode pauseMenu;
    public KeyCode miniMap;
    public bool pause;
    public bool map;
    public GameObject bigmap;
    public GameObject pauseScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseMenu) && pause == false) 
        {
            Debug.Log("Pause");
            pauseScreen.GetComponent<Canvas>().enabled = true;           
            pause = true;
        }
        else if (Input.GetKeyDown(pauseMenu) && pause == true)
        {
            Debug.Log("Unpause");
            pauseScreen.GetComponent<Canvas>().enabled = false;
            pause = false;

        }
        

        if (Input.GetKeyDown(miniMap) && map == false)
        {
            bigmap.GetComponent<Canvas>().enabled = true;
            map = true;
        }
        else if (Input.GetKeyDown(miniMap) && map == true)
        {
            bigmap.GetComponent<Canvas>().enabled = false;
            map = false;
        }
        if(pause == true)
        {
            Time.timeScale = 0;
        }
        if(pause == false)
        {
            Time.timeScale = 1;
        }
    }
}
