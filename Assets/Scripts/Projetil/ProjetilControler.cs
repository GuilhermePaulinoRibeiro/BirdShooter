using UnityEngine;

public class ProjetilControler : MonoBehaviour
{
    private IProjetil _projetil;
    public GameObject projetil;

    public GameObject Alvo;

    public bool cair = false;
    void Start()
    {

        _projetil = projetil.GetComponent<IProjetil>();
        Alvo = GameObject.FindGameObjectWithTag(Alvo.tag).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (AlvoAbaixo() && cair == false)
        {
            cair = true;
            projetil.transform.SetParent(null);

        }

        if (cair)
            _projetil.Lancar();
    }

    public bool AlvoAbaixo()
    {
        if (Mathf.Floor(Alvo.transform.position.x) == Mathf.Floor(projetil.transform.position.x))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
