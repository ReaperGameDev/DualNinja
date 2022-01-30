using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour
{
    public CharacterController2D controller;
    public GameObject smoke;
    public float speed;
    float horizontalMove;
    bool jump = false;
    
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal")*speed;
        if (Input.GetButtonDown("Jump"))
        {          
            jump = true;
        }          
            //Mi input manger no me funcionaba con el jump, asi que hice esto
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.deltaTime, false,jump);
        jump = false;
    }
    public void Die(bool iDie)
    {
        if (iDie)
        {
            var smokee = Instantiate(smoke);
            smokee.transform.position = this.transform.position;
            iDie = false;
            Destroy(this.gameObject);
        }
    }
}