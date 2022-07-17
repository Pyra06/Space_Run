using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    private float spawnTime = 2f;
    public float intervalTime = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= spawnTime)
        {
            Spawner();
            spawnTime = Time.time + intervalTime;
        }
    }

    void Spawner()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
