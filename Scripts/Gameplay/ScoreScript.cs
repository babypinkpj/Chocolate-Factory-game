using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour


{
    public int score = 0;
    //public TMP_Text scoreText;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip BadSound;

    [Header("UI")]
    public Image scoreFill;
    public int maxScore = 100; 
    public TMP_Text winText; 
    public TMP_Text loseText;
    
    [Header("Timer")]
    public float timeLeft = 30f; // เวลาทั้งหมด (วินาที)
    public TMP_Text timerText;   // UI แสดงเวลา
    private bool isWin = false;

    [Header("End Game UI")]
    public GameObject endGamePanel; // <- Panel ที่เก็บ Win/Lose + ปุ่ม
    //public TMP_Text resultText;     // <- แสดงข้อความ Win/Lose




    void Start()
    {
       // scoreText.text = "SCORE : " + score.ToString();
        endGamePanel.SetActive(false); // ปิด panel ก่อน
        winText.gameObject.SetActive(false);
        UpdateUI();

    }
    void Update()
    {
        if (timeLeft > 0 && !isWin)
        {
            timeLeft -= Time.deltaTime; // นับถอยหลัง
            if (timeLeft < 0) timeLeft = 0;
        }
        UpdateUI();
         if (score >= maxScore)
        {
            YouWin();
        }
           else if (timeLeft <= 0 && !isWin) // เวลาเหลือ 0 → แพ้
        {
            YouLose();
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        audioSource.PlayOneShot(audioClip);
        string tag = other.gameObject.tag;

        if (tag == "BallA")
        {
           ScoreManager.Instance.AddScore(1);
         Destroy(other.gameObject);
        }

        if (tag == "BallB")
        {
           ScoreManager.Instance.AddScore(2);
         Destroy(other.gameObject);
        }
        if (tag == "BallC")
        {
            ScoreManager.Instance.AddScore(3);
            Destroy(other.gameObject);
        }

        if (tag == "BallD")
        {
             ScoreManager.Instance.AddScore(-5);
            Destroy(other.gameObject);
            timeLeft -= 5f; 
             audioSource.PlayOneShot(BadSound);
             
        }
        if (tag == "BallE")
        {
            ScoreManager.Instance.AddScore(-10);
            Destroy(other.gameObject);
             timeLeft -= 8f; 
            audioSource.PlayOneShot(BadSound);
        }

        Debug.Log("score = " + score);
    }
     void UpdateUI()
    {
        //Score Text
        //scoreText.text = score.ToString();
        scoreFill.fillAmount = (float)score / maxScore; 

        //Timer
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
    public void YouWin()
    {
        isWin = true;
       endGamePanel.SetActive(true); 
        winText.text = "YOU WIN!";

        Time.timeScale = 0f; 
    }
     public void YouLose()
    {
        isWin = true;
        Time.timeScale = 0f;
        endGamePanel.SetActive(true);
        loseText.text = "YOU LOSE!";
    }

  
    public void RetryGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game"); // จะเห็นผลตอน build จริง
    }
}

   
