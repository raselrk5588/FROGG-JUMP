using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameWin : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Score.currentSore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
