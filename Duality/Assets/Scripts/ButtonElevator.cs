using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonElevator : MonoBehaviour
{
    public GameObject elevator;
    public GameObject player1;
    public GameObject player2;
    bool buttonPressed = false;
    

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == player1.name)
        {
          GetComponent<Animator>().SetBool("IsPressed", true);
          elevator.GetComponent<Animator>().SetBool("ButtonPressed", true);
          elevator.GetComponent<Animator>().SetFloat("Speed", 1);      
        }
    }
}
