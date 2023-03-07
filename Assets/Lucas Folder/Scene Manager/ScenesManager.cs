using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
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




}
