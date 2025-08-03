using UnityEngine;

public class Bird : MonoBehaviour
{
    public virtual float Health { get; set; } = 1f;
    public float speed = 1f;

    [Header("Velocidade")]
    public float minSpeed;
    public float maxSpeed;

    [Header("Item Drops")]
    public DropItem[] possibleDrops;


    public virtual void Fly()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -10)
        {
            Destroy(gameObject);

        }
    }

    public virtual void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        DropItems();
        Destroy(gameObject);
    }

    protected virtual void DropItems()
    {
        foreach (var drop in possibleDrops)
        {
            float roll = Random.Range(0f, 100f);
            if (roll <= drop.dropChancePercent)
            {
                Instantiate(drop.itemPrefab, transform.position, Quaternion.identity);
            }
        }
    }

    public virtual void Attack()
    {
        Debug.Log($"{gameObject.name} atacou!");
    }

    //Collisions
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet no Passaro");

        if (collision.gameObject.tag == "Bullet")
        {
            //sm.AdicionarPonto();
            Die();
        }
    }
}
