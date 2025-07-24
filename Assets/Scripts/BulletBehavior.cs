using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 4;
    ScoreManager sm;

    Vector3 direcao;
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("ScoreManager").gameObject.GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move para frente na direção que o objeto está olhando
        direcao = transform.right; // ou transform.up dependendo da orientação
        direcao.z = 0f; // trava o eixo Z (se for 2D)
        transform.position += direcao.normalized * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
          if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
