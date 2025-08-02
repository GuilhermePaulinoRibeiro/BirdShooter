using UnityEngine;

public class Molotove : MonoBehaviour, IProjetil
{
    public GameObject firePrefab;
    public float velocity = 1;
    public void Lancar()
    {
        transform.position += Vector3.down * Time.deltaTime * velocity;
    }

    public void CriarFogo(GameObject fire, Vector3 position)
    {
        Instantiate(fire, position, fire.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Debug.Log("Criar Fogo");
            CriarFogo(firePrefab, gameObject.transform.position);
            Destroy(gameObject);
        }
        if (collision.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

}
