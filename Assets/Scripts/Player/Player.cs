using UnityEngine;

public class Player : MonoBehaviour
{
    public int vidas = 3;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {
        Debug.Log(vidas);
        vidas -= 1;
    }
}
