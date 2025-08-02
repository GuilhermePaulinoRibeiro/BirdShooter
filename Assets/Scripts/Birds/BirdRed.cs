using UnityEngine;
using UnityEngine.Timeline;

public class BirdRed : Bird
{
    public override float Health { get; set; } = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fly();
    }

    public override void Attack()
    {
        //Implementação do attack    
    } 

}
