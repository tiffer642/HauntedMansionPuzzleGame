using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsGearIcon : MonoBehaviour
{
    //image component
    private Image Image;

    //Sprites
    public Sprite Past;
    public Sprite Future;






    // Start is called before the first frame update
    void Start()
    {
        Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Past")
        {
            Image.sprite = Past;
        }
        else if (SceneManager.GetActiveScene().name == "Future")
        {
            Image.sprite = Future;
        }
    }
}
