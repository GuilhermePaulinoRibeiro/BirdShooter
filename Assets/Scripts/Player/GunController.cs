using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject rotacao;

    public GameObject bulletParent;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("Atirou");
            Instantiate(bullet, transform.position, rotacao.transform.rotation,bulletParent.transform);
        }

    }
}
