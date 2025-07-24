using UnityEngine;

[System.Serializable]
public class DropItem
{
    public GameObject itemPrefab;
    [Range(0f, 100f)] public float dropChancePercent = 100f;
}