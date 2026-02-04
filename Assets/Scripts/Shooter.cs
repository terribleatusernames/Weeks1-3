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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(objectToSpawn, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f), 0f), Quaternion.identity);
            spawnInterval = 0f;

            Pacer spawnedPacer = spawnedObject.GetComponent<Pacer>();
            spawnedPacer.speed = pacerSpeed;

            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColour;

            Destroy(spawnedObject, destroyTimer);
        }



    }
}
