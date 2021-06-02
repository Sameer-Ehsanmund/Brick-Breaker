using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    [Header("Bricks")]
    public GameObject brick;
    public GameObject brick2;
    public GameObject brick3;
    public GameObject brick4;
    public GameObject brick5;
    public GameObject brick6;
    public GameObject brick7;
    public GameObject brick8;
    public GameObject brick9;
    [Space]
    public GameObject panel;
    public GameObject panel2;
    public GameObject roof;
    [Space]
    public Rigidbody rb;
    [Space]
    [Header("Speeds")]
    [Range(50f,100f)] public float movingSpeed;
    public float afterhitSpeed;
    public float Wallhitspeed;
    public float PtoWSpeed;

    bool leftwallhit = false;
    bool rightwallhit = false;

    bool PtoLWHit = false;
    bool PtoRWHit = false;

    // [Space]
    // [Header("List Elemets")]
    // public List<GameObject> bricks = new List<GameObject>();

    //  void Start()
    // {

    // bricks.RemoveAt(8);



    //}

    public void OnCollisionEnter(Collision info)
    {

        
        #region CollidingWithBrick

        if (info.gameObject.transform == brick.transform)
        {          
              // rb.isKinematic = true;
                rb.velocity = Vector3.zero;
                movingSpeed = 0f;
                brick.SetActive(false);
                gainSpeedafterCollision();
        
          //                 
          //  rb.AddForce(-(afterhitSpeed * Time.deltaTime), -(afterhitSpeed * Time.deltaTime), 0, ForceMode.Impulse);
          //  Time.timeScale = 0;
        }
        if (info.gameObject.transform == brick2.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick2.SetActive(false);
            gainSpeedafterCollision();

        }
        if (info.gameObject.transform == brick3.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick3.SetActive(false);
            gainSpeedafterCollision();

        }
        if (info.gameObject.transform == brick4.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick4.SetActive(false);
            gainSpeedafterCollision();

        }
        if (info.gameObject.transform == brick5.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick5.SetActive(false);
            gainSpeedafterCollision();

        }
        if (info.gameObject.transform == brick6.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick6.SetActive(false);
            gainSpeedafterCollision();

        }
        if (info.gameObject.transform == brick7.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick7.SetActive(false);
            gainSpeedafterCollision();

        }
        if (info.gameObject.transform == brick8.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick8.SetActive(false);
            gainSpeedafterCollision();

        }
        if (info.gameObject.transform == brick9.transform)
        {

            rb.velocity = Vector3.zero;
            movingSpeed = 0f;
            brick9.SetActive(false);
           // brick9.SetActive(false);

          //  if (GameObject.Find("brick9") == null)
           // {
           //     Debug.Log("destroyed");
           // }

            gainSpeedafterCollision();

        }

        #endregion

        



        if (info.collider.tag == "player")
        {
            //movingSpeed = 50f;
           // Debug.Log("hitted");
            movingSpeed = 50f;
            Wallhitspeed = 0f;
            PtoWSpeed = 0f;
            rb.AddForce(0, movingSpeed * Time.deltaTime, 0, ForceMode.Impulse);
            PtoLWHit = true;
            PtoRWHit = true;
        }
        if (info.collider.tag == "roof")
        {
            movingSpeed = 0f;
            Wallhitspeed = 0f;
            afterhitSpeed = 200f;
            rb.AddForce(0, -(afterhitSpeed * Time.deltaTime), 0, ForceMode.Impulse);
            leftwallhit = true;
            rightwallhit = true;
        }

        if (leftwallhit == true && info.collider.tag == "leftwall")
            {
               // movingSpeed = 0f;
                afterhitSpeed = 0f;
              //  PtoLWSpeed = 0f;
                Wallhitspeed = 200f;
                rb.AddForce((Wallhitspeed * Time.deltaTime), -(Wallhitspeed * Time.deltaTime), 0, ForceMode.Impulse);
            }

        if (rightwallhit == true && info.collider.tag == "rightWall")
        {
            // movingSpeed = 0f;
            afterhitSpeed = 0f;
          //  PtoRWSpeed = 0f;
            Wallhitspeed = 200f;
            rb.AddForce(-(Wallhitspeed * Time.deltaTime), -(Wallhitspeed * Time.deltaTime), 0, ForceMode.Impulse);
        }
        if (PtoLWHit == true && info.collider.tag == "leftwall")
        {
            movingSpeed = 0f;
            afterhitSpeed = 0f;
            Wallhitspeed = 0f;
            rb.AddForce((PtoWSpeed * Time.deltaTime), (PtoWSpeed * Time.deltaTime), 0, ForceMode.Impulse);
        }
        if (PtoRWHit == true && info.collider.tag == "rightWall")
        {
            movingSpeed = 0f;
            afterhitSpeed = 0f;
            Wallhitspeed = 0f;
            rb.AddForce(-(PtoWSpeed * Time.deltaTime), (PtoWSpeed * Time.deltaTime), 0, ForceMode.Impulse);
        }
        if (info.collider.tag == "floor")
        {

            Time.timeScale = 0;
            panel.SetActive(true);
        }
    
    }
    void gainSpeedafterCollision()
    {
        
        rb.AddForce(0 , -(afterhitSpeed * Time.deltaTime), 0, ForceMode.Impulse);      
    }
    void FixedUpdate()
    {
      //  if (Input.GetKeyDown(KeyCode.Space))
        //{

        //    int bricksIndex = 5;
        //    var bricksChosen = bricks[bricksIndex];
        //    bricks.RemoveAt(bricksIndex);
       //     GameObject.Destroy(bricksChosen);
        //    Debug.Log(bricksIndex);
       // }

        if(GameObject.FindWithTag("brick") == null){

            Time.timeScale = 0;
            panel2.SetActive(true);
        }
  
        rb.AddForce(0, movingSpeed * Time.deltaTime, 0, ForceMode.Impulse); 

    }

    
}
