using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(-9, 3,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
