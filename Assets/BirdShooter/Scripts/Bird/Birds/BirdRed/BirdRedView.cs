using UnityEngine;

public class BirdRedView : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    

    public void AbrirGarra()
    {
        animator.SetBool("garraFechada", false);


    }

    public void FecharGarra()
    {
        animator.SetBool("garraFechada", true);


    }
}
