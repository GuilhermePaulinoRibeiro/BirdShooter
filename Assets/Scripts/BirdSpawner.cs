using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public float spawnRate = 2;
    float _SpawnRate;
    public GameObject[] birds;
    public GameObject parent;
    public GameObject spawnItemParent;
    Collider2D collider;
    GameObject lastInstance;


    float RandomY, RandomSpeed;

    float minY, maxY;
    float minSpeed = 2, maxSpeed = 5;
    void Start()
    {
        _SpawnRate = spawnRate;
        collider = gameObject.GetComponent<Collider2D>();
        minY = collider.bounds.min.y;
        maxY = collider.bounds.max.y;


    }

    // Update is called once per frame
    void Update()
    {
        RandomY = Random.Range(minY, maxY);
        RandomSpeed = Random.Range(minSpeed, maxSpeed);

        spawnRate -= Time.deltaTime;
        if (spawnRate <= 0)
        {
            spawnRate = _SpawnRate;
            lastInstance = Instantiate(birds[0], new Vector3(transform.position.x, RandomY, transform.position.z), birds[0].transform.rotation, parent.transform);
            // lastInstance.gameObject.GetComponent<BirdBehavior>().Speed = RandomSpeed;
            // lastInstance.gameObject.GetComponent<BirdBehavior>().spawnItemParent = spawnItemParent;
        }
    }
}
