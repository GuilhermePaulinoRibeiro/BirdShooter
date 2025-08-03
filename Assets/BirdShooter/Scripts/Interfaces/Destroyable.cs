using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Destroyable : MonoBehaviour
{
    public List<GameObject> others;
    private List<string> othersList = new List<string>();
    void Start()
    {
        foreach (GameObject obj in others)
        {
            othersList.Add(obj.gameObject.tag);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (othersList.Contains(collision.gameObject.tag))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (othersList.Contains(collision.gameObject.tag))
        {
            Destroy(gameObject);
        }
    }
}

