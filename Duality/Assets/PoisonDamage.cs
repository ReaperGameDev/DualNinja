using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonDamage : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject dieScreen;
    public PlayerOneController playerOneController;
    public PlayerTwoMovement playerTwoMovement;
    bool playerOneDie = false;
    bool playerTwoDie = false;

    private void Start()
    {
        playerOneController = playerOne.GetComponent<PlayerOneController>();
        playerTwoMovement = playerTwo.GetComponent<PlayerTwoMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!playerOneDie)
        {
            if (collision.gameObject.name == playerOne.name)
            {

                playerOneController.Die(true);
                playerTwoMovement.Die(true);
                playerOneDie = true;
                playerTwoDie = true;
                Instantiate(dieScreen);

            }
        }
        if (!playerTwoDie)
        {
            if (collision.gameObject.name == playerTwo.name)
            {

                playerTwoMovement.Die(true);
                playerOneController.Die(true);
                playerOneDie = true;
                playerTwoDie = true;
                Instantiate(dieScreen);

            }
        }
    }


}
