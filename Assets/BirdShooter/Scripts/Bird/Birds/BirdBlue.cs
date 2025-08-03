using UnityEngine;

public class BirdBlue : Bird
{
    public override float Health { get; set; } = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fly();
    }

}
