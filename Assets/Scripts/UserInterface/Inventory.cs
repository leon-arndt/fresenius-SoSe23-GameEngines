using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Serialization;
using UserInterface;

public class Inventory : MonoBehaviour
{
    // stack-based ObjectPool available with Unity 2021 and above
    private IObjectPool<InventoryItem> objectPool;

    // throw an exception if we try to return an existing item, already in the pool
    [SerializeField] private bool collectionCheck = true;

    // extra options to control the pool capacity and maximum size
    [SerializeField] private int defaultCapacity = 20;
    [SerializeField] private int maxSize = 100;
    [FormerlySerializedAs("projectilePrefab")] [SerializeField] InventoryItem inventoryItemPrefab;

    private void Awake()
    {
        objectPool = new ObjectPool<InventoryItem>(CreatePooledItem,
            OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject,
            collectionCheck, defaultCapacity, maxSize);
    }

    // invoked when creating an item to populate the object pool
    private InventoryItem CreatePooledItem()
    {
        InventoryItem poolInstance = Instantiate(inventoryItemPrefab);
        poolInstance.ObjectPool = objectPool;
        return poolInstance;
    }

    // invoked when returning an item to the object pool
    private void OnReleaseToPool(InventoryItem pooledObject)
    {
        pooledObject.gameObject.SetActive(false);
    }

    // invoked when retrieving the next item from the object pool
    private void OnGetFromPool(InventoryItem pooledObject)
    {
        pooledObject.gameObject.SetActive(true);
    }

    // invoked when we exceed the maximum number of pooled items (i.e. destroy the pooled object)
    private void OnDestroyPooledObject(InventoryItem pooledObject)
    {
        Destroy(pooledObject.gameObject);
    }
}