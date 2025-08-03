using UnityEngine;

public class ProjetilControler : MonoBehaviour
{
    private IProjetil _projetil;
    public GameObject projetil;
    void Start()
    {

        _projetil = projetil.GetComponent<IProjetil>();
    }

    // Update is called once per frame
    void Update()
    {
        _projetil.Lancar();
    }


}
