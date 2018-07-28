using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour {

    public GameObject[] tilePrefab;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 6f;
    private int amnTilesOnScreen=7;
    private int safeZone = 9;
    private int lastPrefabIndex = 0;

    private List<GameObject> activeTiles;
	// Use this for initialization
	void Start () {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();

            deleteTile();
        }

    }

    private void SpawnTile(int prefabIndex = -1)
    {

        GameObject gameObject = Instantiate(tilePrefab[RandomPrefabIndex()]) as GameObject;
        gameObject.transform.SetParent(transform);
        gameObject.transform.position = Vector3.forward * spawnZ;
        //TODO
        Transform t = gameObject.transform;
        foreach (Transform tr in t)
        {
            if (tr.tag == "validNote")
            {
                tr.GetComponent<noteBehaviour>().noteCode = Random.Range(50, 70);
            }
        }

        spawnZ += tileLength;
        activeTiles.Add(gameObject);
    }

    private void deleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefab.Length <= 1)
        {
           return 0;
        }
        else
        {
           return Random.Range(0, tilePrefab.Length);
        }
        
    }
}
