using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 30;
    
    void Start()
    {
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
