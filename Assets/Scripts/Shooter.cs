using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject objectToSpawn;
    private float spawnInterval = 0f;
    private float destroyInterval = 0f;

    public float spawnTimer = 2f;
    public float destroyTimer = 5f;
    public float pacerSpeed = Random.Range(1f, 5f);
    public Color pacerColour;
    public float gravity = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, transform.position, Quaternion.identity);
            spawnInterval = 0f;

            Bullet spawnedBullet = spawnedObject.GetComponent<Bullet>();
            spawnedBullet.speed = bulletSpeed - gravity;

            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
           
            Destroy(spawnedObject, destroyTimer);
        }



    }
}
