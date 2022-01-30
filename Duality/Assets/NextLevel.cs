using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("NextScene");
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("LevelManager");
    }
}
