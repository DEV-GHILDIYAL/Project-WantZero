using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LevelGenerator : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;


    private void Start()
    {
        for(int i=0; i<15; i++)
        {
            SpawnTile();
        }
    }


    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(0).transform.position;
    }
    public void SpawnEndlessTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
    }
}
