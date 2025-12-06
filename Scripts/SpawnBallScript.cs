using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallScript : MonoBehaviour
{
     public float delay = 1.5f;
    public Transform spawnPoint;
    public GameObject ball;
    // Start is called before the first frame update

     [Header("Items to Spawn")]
    public GameObject goodItem; // ของได้คะแนน
    public GameObject badItem;  // ของเสียคะแนน

    [Header("Spawn Chances")]
    [Range(0, 100)] public int goodChance = 70; // %
    [Range(0, 100)] public int badChance = 30;  // %

    void Start()
    {
        InvokeRepeating(nameof(SpawnOne), delay, delay);
    }

    void SpawnOne()
    {
        int roll = Random.Range(0, 100); // สุ่ม 0-99
        GameObject prefabToSpawn;

        if (roll < goodChance) 
            prefabToSpawn = goodItem;   // โอกาส + คะแนน
        else
            prefabToSpawn = badItem;    // โอกาส - คะแนน

        GameObject clone = Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
        Destroy(clone, 60f);
    }
}
