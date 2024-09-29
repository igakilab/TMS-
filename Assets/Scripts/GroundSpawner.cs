using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 nextSpawnPoint;

    void Spawnfile()
    {
        GameObject temp = Instantiate(GroundTile,nextSpawnPoint,Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1);
    }
    void Start()
    {
        
    }
}
