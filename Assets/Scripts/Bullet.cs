using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   private void OnCollisionEnter2d(Collision2D collision)
    {
        Destroy(gameObject);
    //Make this hit the enemy 
    //Make this damage the enemy 
    
    }
}
