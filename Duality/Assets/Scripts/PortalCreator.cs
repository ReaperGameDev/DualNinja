using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCreator : MonoBehaviour
{
    public Transform SpawnPointPlayerRed;
    public Transform SpawnPointPlayerBlue;
    public Transform PortalRed;
    public Transform PortalBlue;
    bool portalRedActive= false;
    bool portalBlueActive = false;

 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PortalRed.position = SpawnPointPlayerRed.position;
            portalRedActive = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PortalBlue.position = SpawnPointPlayerBlue.position;
            portalBlueActive = true;
        }
    }
}
