using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide_sky : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(330,-111,50 );
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1,0));      
if (gameObject.transform.position>1000){gameObject.transform.position=0};
    }}
