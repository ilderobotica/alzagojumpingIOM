using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movHor; /*NUEVO*/
    [SerializeField] float speed = 5f; /*NUEVO*/

    Rigidbody2D rb; /*NUEVO*/
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); /*NUEVO*/
    }

    // Update is called once per frame
    void Update()
    {
        movHor = Input.GetAxisRaw("Horizontal"); /*NUEVO*/
    
    } /*NUEVO*/
    void FixedUpdate()
    }

        rb.velocity = new Vector2(movHor, rb.velocity.y);  /*NUEVO*/
    }/*NUEVO*/
}

