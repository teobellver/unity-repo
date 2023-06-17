using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_controller : MonoBehaviour
{
    public bool canJump = true;
    public float amplifier=1f;

    void Start()
    {
        gameObject.transform.position = new Vector3((float)248.4, (float)-118.6, 0);
    }

    void Update()
    {
        //Izquierda derecha
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-16000f *amplifier* Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(16000f *amplifier* Time.deltaTime, 0));
        }
        //jump 
        if (Input.GetKeyDown("space") && canJump == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 14000f));
            canJump=false;
        };
        if (Input.GetKeyDown("w") && canJump == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 14000f));
            canJump=false;
        }
        if (canJump == false)
        {
            amplifier=1.5f;
        }
        else{
            amplifier=1f;
        }
    }
}
