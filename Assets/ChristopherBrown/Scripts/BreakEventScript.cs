using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakEventScript : MonoBehaviour
{
    public Sprite brokenSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Breakable"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = brokenSprite;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject);
        }
    }
}
