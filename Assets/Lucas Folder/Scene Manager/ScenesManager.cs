using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
    

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
