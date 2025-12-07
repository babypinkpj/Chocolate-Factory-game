using UnityEngine;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; 
    public int score = 0;
    
    public event Action<int> OnScoreChanged;

    void Awake() { Instance = this; }

    public void AddScore(int amount)
    {
        score += amount;
        OnScoreChanged?.Invoke(score); 
    }
}