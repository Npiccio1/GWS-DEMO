using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 movedirection;
    public float projectilespeed;
    private void Start()
    {
        movedirection.x = Mathf.Cos(Mathf.Deg2Rad * (transform.rotation.z + 90));
        movedirection.y = Mathf.Sin(Mathf.Deg2Rad * (transform.rotation.z + 90));
    }
    private void Update()
    {
        transform.Translate(movedirection.normalized);
    }
    private void OnCollisionEnter2d(Collision2D collision)
   
    {
        Destroy(gameObject);
    //Make this hit the enemy 
    //Make this damage the enemy 
    
    }
}
