using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject youWonImg;
    private int score;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    public void UpScore()
    {
        score += 25;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void YouWon()
    {
        Time.timeScale = 0.0f;
        youWonImg.SetActive(true);        
    }

    
}
