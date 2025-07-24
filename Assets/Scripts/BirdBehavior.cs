using UnityEngine;

public class BirdBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Speed = 3;
    GameObject spawnItem;
    public string spawnItemPath;
    public GameObject spawnItemParent;
    
    [Header("Item Drops")]
    public DropItem[] possibleDrops;
    void Start()
    {
        //spawnItem = GameObject.FindGameObjectWithTag("Moeda");
        spawnItem = Resources.Load<GameObject>(spawnItemPath);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;

        if (transform.position.x < -10)
        {
            Destroy(gameObject);

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet no Passaro");
        
        if (collision.gameObject.tag == "Bullet")
        {
            //sm.AdicionarPonto();
            Instantiate(spawnItem, transform.position, transform.rotation, spawnItemParent.transform);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }


}
