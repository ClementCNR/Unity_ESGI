using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarWave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5.0f, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Transform.Instantiate(GetComponent<CarAIControl>(), new Vector3(0, -1, 0), Quaternion.identity);
    }
}
