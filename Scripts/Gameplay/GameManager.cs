using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameState _currentState;
    public float timeLeft = 60f; 

    void Start()
    {
        SetState(new PlayingState(this)); 
    }

    void Update()
    {
        if (_currentState != null)
            _currentState.Update();
    }

    public void SetState(GameState newState)
    {
        _currentState = newState;
        _currentState.Start();
    }
}