using UnityEngine;

public class Items : MonoBehaviour
{



    public virtual void Coletar()
    {
        Efeito();
        Destroy(gameObject);
    }

    public virtual void Efeito()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Coletar();
        }
    }
}
