using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string axis;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxisRaw(axis) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y);

    }

}    
  
