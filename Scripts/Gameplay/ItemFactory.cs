using UnityEngine;
using System.Collections;

public abstract class ItemFactory : MonoBehaviour
{
    public abstract GameObject GetItemPrefab();
}

/* public class RandomItemFactory : ItemFactory
{
    public GameObject goodItem;
    public GameObject badItem;

    [Range(0, 100)] public int goodChance = 70; //Random chance

    public override GameObject GetItemPrefab()
    {
        int roll = Random.Range(0, 100);
        return (roll < goodChance) ? goodItem : badItem;
    }
} */