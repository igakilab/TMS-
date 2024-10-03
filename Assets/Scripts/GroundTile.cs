using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other) {
        groundSpawner.Spawnfile();
        Destroy(gameObject,2);
    }

    void Update()
    {
        
    }
}
