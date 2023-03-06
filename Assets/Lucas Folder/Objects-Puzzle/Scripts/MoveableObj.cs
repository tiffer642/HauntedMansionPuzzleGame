using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveableObj : MonoBehaviour
{
    //Sprite Renderer
    private SpriteRenderer SR;

    //Sprites
    public Sprite Past;
    public Sprite Future;



    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Past" && SR.sprite != Past)
        {
            SR.sprite = Past;
        }
        else if(SceneManager.GetActiveScene().name == "Future" && SR.sprite != Future)
        {
            SR.sprite = Future;
        }
    }
}
