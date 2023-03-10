using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
    //Dont destroy on load of scene
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }



    //Scene Changes
    public void LoadPast()
    {
        SceneManager.LoadScene("Past");
    }

    public void LoadFuture()
    {
        SceneManager.LoadScene("Future");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Destroy(gameObject);
    }



    //Quit Aplication-Game
    public void Quit()
    {
        Application.Quit();
    }





    //Pause Game
    //Variables
    public KeyCode PauseKey = KeyCode.Escape;

    //GameObject
    public GameObject PauseMenu;


    public void Pause()
    {
        if (Input.GetKeyDown(PauseKey) && SceneManager.GetActiveScene().name != "Main Menu")
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0; 
        }
    }

    public void Resume()
    {
        Time.timeScale = 1; 
    }







    public void Update()
    {
        Pause();
        SwapTime();
    }



    //Interact Popup
    public GameObject InteractCanvas;

    public void IntPopup(bool onOff)
    {
        if(InteractCanvas.gameObject.activeSelf == false  && onOff == true)
        {
            InteractCanvas.SetActive(true);
        }
        else
        {
            if(InteractCanvas.gameObject.activeSelf == true && onOff == false)
            {
                InteractCanvas.SetActive(false);
            }
        }
    }

    public void SwapTime()
    {
        if (Input.GetKeyDown(KeyCode.E) && InteractCanvas.activeSelf == true)
        {
            if(SceneManager.GetActiveScene().name == "Future")
            {
                LoadPast();
                //InteractCanvas.SetActive(false);
                Debug.Log("Past");
            }
            else if(SceneManager.GetActiveScene().name == "Past")
            {
                LoadFuture();
                //InteractCanvas.SetActive(false);
                Debug.Log("Future");
            }
        }
    }



}
