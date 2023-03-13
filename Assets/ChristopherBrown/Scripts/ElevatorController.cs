using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public GameObject door;
    public Transform endPoint;
    public Transform startPoint;
    public Animator an;
    public GameObject player;
    public float speed;
    public bool canGo = false;

    private void Start()
    {
        transform.position = startPoint.position;
        an = door.GetComponent<Animator>();
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;
        if (player.GetComponent<PlayerTopDown>().inElevator == true && an.GetBool("isOpen") == false && an.GetCurrentAnimatorStateInfo(0).IsName("ElevatorIdleAni") && canGo == true)
        {
            if(transform.position != endPoint.position)
            {
                transform.position = Vector2.MoveTowards(startPoint.position, endPoint.position, step);
            }
            else
            {
                canGo = false;
                OpenElevator();
            }
        }
        else if(player.GetComponent<PlayerTopDown>().inElevator == true && an.GetBool("isOpen") == true && an.GetCurrentAnimatorStateInfo(0).normalizedTime < 1 && canGo == false)
        {
            player.transform.parent = null;
            player.GetComponent<PlayerTopDown>().ShowPlayer();
            player.GetComponent<PlayerTopDown>().inElevator = false;
        }
    }

    public void OpenElevator()
    {
        Debug.Log("Open");
        an.SetTrigger("OpenElevator");
        an.SetBool("isOpen", true);
    }

    public void CloseElevator()
    {
        Debug.Log("Close");
        an.SetTrigger("CloseElevator");
        an.SetBool("isOpen", false);
        canGo = true;
    }
}
