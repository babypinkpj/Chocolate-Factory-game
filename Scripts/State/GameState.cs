using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class GameState
{
    protected GameManager _system;
    public GameState(GameManager system) { _system = system; }
    
    public virtual void Start() { }
    public virtual void Update() { }
}

public class PlayingState : GameState
{
    public PlayingState(GameManager system) : base(system) { }

    public override void Update()
    {
        _system.timeLeft -= Time.deltaTime;
        if (_system.timeLeft <= 0)
        {
            _system.SetState(new GameOverState(_system));
        }
    }
}

public class GameOverState : GameState
{
    public GameOverState(GameManager system) : base(system) { }

    public override void Start()
    {
        EventManager.TriggerGameOver(); // แจ้งเตือนทั้งเกมว่าจบแล้ว
        Time.timeScale = 0; // หยุดเวลา
    }
}