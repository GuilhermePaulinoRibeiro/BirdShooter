using UnityEngine;

public class LifeSystem : MonoBehaviour
{
    public Player player;
    public GameObject[] Coracoes;

    private int _vidas;

    void Start()
    {
        _vidas = player.vidas;
    }

    // Update is called once per frame
    void Update()
    {
        if (_vidas != player.vidas)
        {
            _vidas = player.vidas;

            if (_vidas == 0)
            {
                Coracoes[0].gameObject.SetActive(false);
                Coracoes[1].gameObject.SetActive(false);
                Coracoes[2].gameObject.SetActive(false);


            }            
            if (_vidas == 1)
            {
                Coracoes[0].gameObject.SetActive(true);
                Coracoes[1].gameObject.SetActive(false);
                Coracoes[2].gameObject.SetActive(false);


            }
            else if (_vidas == 2)
            {
                Coracoes[0].gameObject.SetActive(true);
                Coracoes[1].gameObject.SetActive(true);
                Coracoes[2].gameObject.SetActive(false);
            }
            else if (_vidas == 3)
            {
                Coracoes[0].gameObject.SetActive(true);
                Coracoes[1].gameObject.SetActive(true);
                Coracoes[2].gameObject.SetActive(true);
            }

        }
    }

    public void AdicionarCoracao()
    {

    }
    public void RemoverCoracao()
    {

    }
}
