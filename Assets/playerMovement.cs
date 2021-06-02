using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
   // public Transform player;
    public float movingSpeed;

  //  public CharacterController controller;
    void Update()
    {

      //  float horizontal = Input.GetAxisRaw("Horizontal");
       // Vector3 direction = new Vector3(horizontal,0f,0f);

        if (Input.GetKey("d"))
        {
            
          rb.AddForce(movingSpeed * Time.deltaTime,0,0,ForceMode.Impulse);
            //transform.position += Vector3.right * Time.deltaTime * movingSpeed;
            //controller.Move(direction * movingSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {

            rb.AddForce(-(movingSpeed * Time.deltaTime), 0, 0, ForceMode.Impulse);
        }
        
    }
}
