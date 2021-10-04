using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger4 : MonoBehaviour
{
   private BoxCollider2D bc;

   private void Awake(){
       bc = GetComponent<BoxCollider2D>();
       bc.isTrigger = true; 
   }

   void OnTriggerEnter2D(Collider2D collision){
       //Debug.Log("A collision has happened.", gameObject);
       if(collision.CompareTag("Player")){
            GameObject.Find("Main Camera").transform.position = new Vector3(50, -66, -10);
       }

   }
}
