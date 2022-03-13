using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject[] spawnLocation;

    private void Start()
    {
        spawnLocation = GameObject.FindGameObjectsWithTag("SpawnLocation");
    }

    public void SpawnObject(GameObject obj)
    {
        foreach(var sl in spawnLocation)
        {
            if (sl.name.Equals(obj.name))
            {
                Instantiate(obj, sl.transform);
                obj.transform.parent = null;
            }
        }
    }
}
