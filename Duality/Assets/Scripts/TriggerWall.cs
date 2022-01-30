using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    public GameObject playerCantEnter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == playerCantEnter.name)
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
        else
        {
           GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == playerCantEnter.name)
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
        else
        {
            GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
