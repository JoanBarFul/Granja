using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPos;
    public int animalIndex;
    public float ranX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 2f);
        InvokeRepeating("SpawnRandomAnimal", 61, 2f);


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnRandomAnimal()
    {
        ranX = Random.Range(-20, 20);
        spawnPos = new Vector3(ranX, 0, 37);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }


}
