using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public bool canJump = true;

    void Start()
    {
        gameObject.transform.position = new Vector3(324, -107, 0);
    }

    void Update()
    {
        //Izquierda derecha
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-12000f * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(12000f * Time.deltaTime, 0));
        }
        //jump 
        if (Input.GetKeyDown("space") && canJump == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7000f));
            canJump=false;
        };
        if (Input.GetKeyDown("w") && canJump == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7000f));
            canJump=false;
        }
    }
}
