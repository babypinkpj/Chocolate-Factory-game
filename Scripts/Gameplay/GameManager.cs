using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private GameState _currentState;
    public float timeLeft = 60f; 
    private bool isGameOver = false;

     void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        SetState(new PlayingState(this)); 
    }

    void Update()
    {
        if (_currentState != null)
            _currentState.Update();
        if (!isGameOver)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0) timeLeft = 0;
        }
    }
     public void StopGame()
    {
        isGameOver = true;
    }

    public void SetState(GameState newState)
    {
        _currentState = newState;
        _currentState.Start();
    }
}