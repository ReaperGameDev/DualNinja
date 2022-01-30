using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerGoto : MonoBehaviour
{
    public void GotoSceneManager()
    {
        SceneManager.LoadScene("LevelManager");
    }
}
