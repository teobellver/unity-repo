using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_movement : MonoBehaviour
{
    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(302 , -107, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //Izquierda derecha
        if (Input.GetKey("a"))
        {   

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-20000f * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(20000f * Time.deltaTime, 0));
        }
        //jump 
        if (Input.GetKeyDown("space") && canJump){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 14000f));
            canJump = false;
        }
        //salto
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Jump")
        {
            canJump = true;
        }
    }
}
