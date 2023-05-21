using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
=======
        
    gameObject.transform.position = new Vector3(-70, 20, 0);
    }
>>>>>>> 12c27d2778d4e0c93b60ddaf863ae600bff04820

    }
    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        //Izquierda derecha
=======
        //mover player Izquierda 
>>>>>>> 12c27d2778d4e0c93b60ddaf863ae600bff04820
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10000f * Time.deltaTime, 0));
        }
<<<<<<< HEAD
=======
        //mover player Derecha
>>>>>>> 12c27d2778d4e0c93b60ddaf863ae600bff04820
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(10000f * Time.deltaTime, 0));
        }
        //salto
    }
}
