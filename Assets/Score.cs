using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int currentSore = 0;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentSore.ToString();
    }

}
