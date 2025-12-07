using UnityEngine;
using System;

public static class EventManager
{
    public static event Action<int> OnItemCollected;
    public static event Action OnGameOver;
    //public static event Action OnGameStart;

    public static void TriggerItemCollected(int itemId)
    {
        if (OnItemCollected != null) OnItemCollected(itemId);
    }

    public static void TriggerGameOver()
    {
        if (OnGameOver != null) OnGameOver();
    }
    
   /*  public static void TriggerGameStart()
    {
        OnGameStart?.Invoke();
    } */
}