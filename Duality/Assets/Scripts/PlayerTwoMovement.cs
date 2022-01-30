using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float speed;
    public GameObject smoke;
    float horizontalMove;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal2") * speed;
        if (Input.GetButtonDown("Jump2"))
        {
            jump = true;
        }

    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, false, jump);
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
