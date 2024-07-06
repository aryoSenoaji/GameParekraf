using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnedBall;

    Vector3 spawnPosition = new Vector3(3.46f,1.76f,0);

    Quaternion spawnRotation = Quaternion.Euler(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnedBall, spawnPosition, spawnRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
