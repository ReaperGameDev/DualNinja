using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieConsole : MonoBehaviour
{
   public void SelectLevel()
    {
        SceneManager.LoadScene("LevelManager");
    }
}
