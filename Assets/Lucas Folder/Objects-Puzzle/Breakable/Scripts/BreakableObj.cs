using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakableObj : MonoBehaviour
{
 //Sprite Renderer
    private SpriteRenderer SR;

 //GameManager


 //SceneManager
    

 //Sprites
    //Future
    public Sprite BrokenSprite;
    public Sprite Past;

    //Past
    public Sprite Future;

    //Variables
    public bool Broken = false;
    

  //Methods


    public void ChangeSprite()
    {
        if (SceneManager.GetActiveScene().name == "Past" && SR.sprite != Past)
        {
            SR.sprite = Past;
        }
        else if (SceneManager.GetActiveScene().name == "Future" && SR.sprite != Future)
        {
            SR.sprite = Future;
        }
    }
    






    
}
