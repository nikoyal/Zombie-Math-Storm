using UnityEngine;
public class SpawnZombies : MonoBehaviour
{
    public GameObject tallZombie;
    public GameObject shortZombie;
    public GameObject girlZombie;
    void Start()
    {
        InvokeRepeating("SpawnZombie", 3f, 8f);
    }


    void SpawnZombie()
    {
        int zombieRandomizer = Random.Range(0, 3);
        if (zombieRandomizer == 0)
        {
            float spawnPointX = Random.Range(0f, 2.047f);
            float spawnPointY = Random.Range(-0.9f, -1.163f);
            zombieRandomizer = Random.Range(0, 3);
            Data.ZombieCount += 0.1f;
            Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, -20 + Data.ZombieCount);
            Instantiate(tallZombie, spawnPosition, Quaternion.identity);
        }

        if(zombieRandomizer == 1)
        {
            float spawnPointX = Random.Range(2f, 2.047f);
            float spawnPointY = Random.Range(-0.9f, -1.163f);
            zombieRandomizer = Random.Range(0, 3);
            Data.ZombieCount += 0.1f;
            Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, -20 + Data.ZombieCount);
            Instantiate(shortZombie, spawnPosition, Quaternion.identity);
        }

        if (zombieRandomizer == 2)
        {
            float spawnPointX = Random.Range(2f, 2.047f);
            float spawnPointY = Random.Range(-0.9f, -1.163f);
            zombieRandomizer = Random.Range(0, 3);
            Data.ZombieCount += 0.1f;
            Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, -20 + Data.ZombieCount);
            Instantiate(girlZombie, spawnPosition, Quaternion.identity);
        }
    }
}
