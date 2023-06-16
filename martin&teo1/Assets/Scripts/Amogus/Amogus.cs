using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amogus : MonoBehaviour
{
    public Transform PlayerT;
    public Player_controller playerC;

    private void Update()
    {
        if (PlayerT.position.x >= transform.position.x)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(12000f * Time.deltaTime, 0));
        }
        else if (PlayerT.position.x <= transform.position.x)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-12000f * Time.deltaTime, 0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            Collider.Destroy(collision.gameObject);
        }
    }
}
