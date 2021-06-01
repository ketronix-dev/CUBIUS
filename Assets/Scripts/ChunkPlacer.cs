using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public GameObject StartObjects;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;

    private List<Chunk> spawnedCnunks = new List<Chunk>();
    // Start is called before the first frame update
    void Start()
    {
        spawnedCnunks.Add(FirstChunk);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x < spawnedCnunks[spawnedCnunks.Count - 1].End.position.x + 20)
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position = spawnedCnunks[spawnedCnunks.Count - 1].End.position;
        spawnedCnunks.Add(newChunk);

        if (spawnedCnunks.Count >= 8)
        {
            spawnedCnunks[0].gameObject.SetActive(false);
            StartObjects.SetActive(false);
            spawnedCnunks.RemoveAt(0);
        }
    }
}
