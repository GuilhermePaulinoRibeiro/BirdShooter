using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    public List<GameObject> others;
    private List<string> othersList = new List<string>();

    // Evento que é chamado quando este objeto recebe dano
    [Serializable]
    public class DamageEvent : UnityEvent<GameObject> { }

    public DamageEvent OnDamage;

    void Start()
    {
        foreach (GameObject obj in others)
        {
            othersList.Add(obj.gameObject.tag);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Aqui você pode customizar a lógica, ex: checar se o collider pertence a algo que causa dano
        Debug.Log($"{gameObject.name} recebeu colisão de {collision.gameObject.name}");
        Debug.Log(othersList.Contains(collision.gameObject.tag));

        // Dispara o evento de dano
        if (OnDamage != null && othersList.Contains(collision.gameObject.tag))
        {
            OnDamage.Invoke(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Aqui você pode customizar a lógica, ex: checar se o collider pertence a algo que causa dano
        Debug.Log($"{gameObject.name} recebeu colisão de {collision.gameObject.name}");
        Debug.Log(othersList.Contains(collision.gameObject.tag));

        // Dispara o evento de dano
        if (OnDamage != null && othersList.Contains(collision.gameObject.tag))
        {
            OnDamage.Invoke(collision.gameObject);
        }
    }
}

