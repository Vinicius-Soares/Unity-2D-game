using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public int TotalScore;
    public Text scoreText;
    public static Game_Controller instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = TotalScore.ToString();
    }
}
