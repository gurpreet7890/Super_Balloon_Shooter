using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public ObjectPooler objectPooler;
    public float spawnRate = 1.0f;       
    public Vector2 spawnPositionRange;   

    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnBalloon();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnBalloon()
    {
        
        GameObject balloon = objectPooler.GetFromPool("Balloon");

        
        float randomX = Random.Range(spawnPositionRange.x, spawnPositionRange.y);
        balloon.transform.position = new Vector3(randomX, transform.position.y, 0);
    }
}
