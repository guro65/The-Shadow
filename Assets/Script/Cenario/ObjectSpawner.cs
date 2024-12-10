using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnerInterval = 2f;
    public float spawnerPositionY = 10f;
    public float spawnerPositionX = 0f;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnerInterval)
        {
            timer = 0f;
            Vector3 spawnPosition = new Vector3(spawnerPositionX, spawnerPositionY, 0f);
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
