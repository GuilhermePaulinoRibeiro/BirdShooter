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
    void Start()
    {
        _SpawnRate = spawnRate;
        collider = GetComponent<Collider2D>();
        minY = collider.bounds.min.y;
        maxY = collider.bounds.max.y;


    }

    // Update is called once per frame
    void Update()
    {
       

        spawnRate -= Time.deltaTime;
        if (spawnRate <= 0)
        {
            SpawnBird();
        }
    }

    public void SpawnBird()
    {
        spawnRate = _SpawnRate;

        //Posição
        RandomY = Random.Range(minY, maxY);
        Vector3 position = new Vector3(transform.position.x, RandomY, transform.position.z);

        //Instanciar
        lastInstance = Instantiate(SelectRandomBird(birds), position, birds[0].transform.rotation, parent.transform);

        //Definir Velocidade
        Bird bird = lastInstance.GetComponent<Bird>();
        RandomSpeed = Random.Range(bird.minSpeed, bird.maxSpeed);
        bird.speed = RandomSpeed;
    }

    public GameObject SelectRandomBird(GameObject[] birdList)
    {
        int randomBird = Random.Range(0, birds.Length);
        return birds[randomBird];
    }
}
