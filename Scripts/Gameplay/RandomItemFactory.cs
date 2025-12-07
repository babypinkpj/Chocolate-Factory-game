using UnityEngine;
using System.Collections;

public class RandomItemFactory : ItemFactory
{
    public GameObject goodItem;
    public GameObject badItem;

    [Range(0, 100)]
    public int goodChance = 70;

    public override GameObject GetItemPrefab()
    {
        int roll = Random.Range(0, 100);
        return (roll < goodChance) ? goodItem : badItem;
    }
}
