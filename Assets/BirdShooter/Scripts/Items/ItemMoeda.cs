using UnityEngine;

public class ItemMoeda : Items
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    ScoreManager sm;

    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("ScoreManager").gameObject.GetComponent<ScoreManager>();
    }

    public override void Efeito()
    {
        sm.AdicionarPonto();

    }
    
}
