using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amogus : MonoBehaviour
{
    public bool player_can_die=true;
    public Transform PlayerT;
    public Player_controller playerC;

    private void Update()
    {
        try{
        if (PlayerT.position.x >= gameObject.transform.position.x)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(12000f * Time.deltaTime, 0));
        }
        else if (PlayerT.position.x <= gameObject.transform.position.x)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-12000f * Time.deltaTime, 0));
        }} catch (MissingReferenceException){
            Debug.Log("inexistente Personaje");
    }}

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if(collision.collider.tag =="Finish"){
            player_can_die=false;
            Debug.Log("finish");
        }
        if(collision.collider.tag == "Player" && player_can_die)
        {
            Collider.Destroy(collision.gameObject);
            Debug.Log("Player Killed");
        }
    }
}
