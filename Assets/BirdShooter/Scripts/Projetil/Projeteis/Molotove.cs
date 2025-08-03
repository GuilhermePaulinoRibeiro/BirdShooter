using UnityEngine;

public class Molotove : MonoBehaviour, IProjetil
{
    public GameObject firePrefab;
    public float velocity = 1;
    public GameObject Player;

    public BirdRedView birdRedView;
    public bool cair = false;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag(Player.tag);


        

    }
    //Logica de Lançamento
    public void Lancar()
    {
        if (AlvoAbaixo(Player) && cair == false)
        {
            cair = true;
            transform.SetParent(null);
            birdRedView.AbrirGarra();

        }

        if (cair)
            transform.position += Vector3.down * Time.deltaTime * velocity;
    }

    public bool AlvoAbaixo(GameObject Alvo)
    {
        if (Mathf.Floor(Alvo.transform.position.x) == Mathf.Floor(transform.position.x))
        {
            return true;
        }
        else
        {
            return false;
        }
    }




    public void CriarFogo(GameObject fire, Vector3 position)
    {
        Instantiate(fire, position, fire.transform.rotation);
    }

    //Collisions 
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

        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
