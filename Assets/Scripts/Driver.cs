using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float slowSpeed= 11f;
    [SerializeField] float boostSpeed= 25f;
    [SerializeField] float  steerSpeed=1f;
     [SerializeField] float moveSpeed=0.01f;
   
    void Update()
    {
        float steerAmount= Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float directionAmount=Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,directionAmount,0);

    }

     void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision just happened fr");
        if(other.gameObject.tag=="Bump")
        {
            moveSpeed=slowSpeed;
        }

    }
     void OnTriggerEnter2D(Collider2D other)
    {
            if(other.gameObject.tag=="speedUp")
            {
                moveSpeed=boostSpeed;
            }

    }
}
