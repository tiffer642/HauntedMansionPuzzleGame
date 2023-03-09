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
        //SceneManager.LoadScene("Past");
        SceneManager.LoadScene("Scene level 1 iteration 1");
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
    }
}
