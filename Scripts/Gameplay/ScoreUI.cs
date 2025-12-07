using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        ScoreManager.Instance.OnScoreChanged += UpdateScoreText;
    }

    void OnDestroy()
    {
        if (ScoreManager.Instance != null)
            ScoreManager.Instance.OnScoreChanged -= UpdateScoreText;
    }

    void UpdateScoreText(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
}