using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-70, 20, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //Izquierda derecha
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10000f * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(10000f * Time.deltaTime, 0));
        }
        //jump 
        if (Input.GetKeyDown("space")){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5000f));
        }
        //salto
    }
}
