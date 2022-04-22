using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarWave : MonoBehaviour
{

    public GameObject objectToClone;
    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Transform.Instantiate(objectToClone, new Vector3(0, -1, 0), Quaternion.identity);
        //Transform.Instantiate(myPrefab, new Vector3(0, -1, 0), Quaternion.FromToRotation(Vector3.zero, player.transform.position);

    }
}
