using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private float _cooldown;

    [SerializeField] private List<Item> _itemPrefabs;

    [SerializeField] private float _defaultValueToEffect = 5f;

    private List<Item> _createdItems;

    private float _time;

    private void Awake()
    {
        _createdItems = new List<Item>();
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _cooldown)
        {
            SpawnPoint spawnPoint = GetEmptyPoint();
            Item missingItem = GetMissingItem();

            if (spawnPoint != null && missingItem != null)
            {
                Item item = Instantiate(missingItem, spawnPoint.Position, Quaternion.identity);

                InitializeItemEffect(item);

                _createdItems.Add(item);
                spawnPoint.Occupy(item);

                item.transform.SetParent(transform);

                _time = 0;
            }
        }
    }

    private void InitializeItemEffect(Item item)
    {
        item.Effect.Initialize(_defaultValueToEffect);
    }

    private Item GetMissingItem()
    {
        List<Item> missingItems = GetMissingItems();

        if (missingItems.Count == 0)
        {
            _time = 0;
            return null;
        }

        return missingItems[Random.Range(0, missingItems.Count)];
    }

    private List<Item> GetMissingItems()
    {
        List<Item> missingItems = new List<Item>();

        foreach (Item itemPrefab in _itemPrefabs)
        {
            bool isMissing = true;

            foreach (Item instance in _createdItems)
            {
                if (instance != null && (instance.Effect.GetType() == itemPrefab.Effect.GetType()))
                {
                    isMissing = false;
                    break;
                }
            }

            if (isMissing == true)
            {
                missingItems.Add(itemPrefab);
            }
        }

        return missingItems;
    }

    private SpawnPoint GetEmptyPoint()
    {
        List<SpawnPoint> emptyPoints = GetEmptyPoints();

        if (emptyPoints.Count == 0)
        {
            _time = 0;
            return null;
        }

        return emptyPoints[Random.Range(0, emptyPoints.Count)];
    }

    private List<SpawnPoint> GetEmptyPoints()
    {
        List<SpawnPoint> emptyPoints = new List<SpawnPoint>();

        foreach (SpawnPoint point in _spawnPoints)
            if (point.IsEmpty)
                emptyPoints.Add(point);

        return emptyPoints;
    }
}