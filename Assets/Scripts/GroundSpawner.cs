using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GroundSpawner : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 nextSpawnPoint;

    public void Spawnfile()
    {
        GameObject temp = Instantiate(GroundTile,nextSpawnPoint,Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for(int i = 0;i < 10;i++) {
            Spawnfile();
        }
    }
}
