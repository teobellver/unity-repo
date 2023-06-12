using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public GameObject player;
    public Player_controller playerC;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Jump")
        {
            playerC.canJump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            playerC.canJump = false;
        }
    }
}
