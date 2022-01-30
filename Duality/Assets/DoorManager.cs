using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Congratulations;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == Player1.name)
        {
            GetComponentInChildren<Animator>().SetBool("PlayerNear", true);
            Instantiate(Congratulations);
        }
        if (collision.gameObject.name == Player2.name)
        {
            GetComponentInChildren<Animator>().SetBool("PlayerNear", true);
            Instantiate(Congratulations);
        }
    }
}
