using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
    

    // Methods
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    //Methods

    public void LoadPast()
    {
        SceneManager.LoadScene("Past");
    }

    public void LoadFuture()
    {
        SceneManager.LoadScene("Future");
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
