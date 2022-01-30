using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTp : MonoBehaviour
{
    public GameObject playerRed;
    public GameObject playerBlue;
    public GameObject anotherPortal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == playerRed.name)
        {
            playerRed.transform.position = anotherPortal.transform.position;
        }
        if (collision.gameObject.name == playerBlue.name)
        {
            playerBlue.transform.position = anotherPortal.transform.position;
        }
    }
}
