using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantietes : MonoBehaviour
{
    [SerializeField] Transform[] spawnPlaces = new Transform[3];
    public GameObject[] Templates = new GameObject[1];

    private float timeBetweenRespawn = 2;
    private float _spawnTime;
    private int number = 0 ;


    void Update()
    {
        if (Time.time > _spawnTime)
        {
            Respawn();
            _spawnTime = Time.time + timeBetweenRespawn;
        }
    }

    void Respawn()
    {
        GameObject enemy = Instantiate(Templates[Random.Range(0, Templates.Length)], spawnPlaces[number].position, Quaternion.identity);
        number++;

        if (number == spawnPlaces.Length)
            number = 0;

    }
}
