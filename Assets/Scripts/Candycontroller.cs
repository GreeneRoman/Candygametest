using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candycontroller : MonoBehaviour
{
    
    

     void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //increase score
            GameManager._instance.IncrementScore();
            Destroy(gameObject);
        }
        else if (collider.gameObject.CompareTag("Boundary"))
        {
            //decrease live
            GameManager._instance.DecreaseLife();
            Destroy(gameObject);
        }
    }
}
