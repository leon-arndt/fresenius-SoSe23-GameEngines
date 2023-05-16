using System.Collections.Generic;
using Events;
using UniRx;
using UnityEngine;
using UnityEngine.Pool;

namespace UserInterface
{
    public class Inventory : MonoBehaviour
    {
        // stack-based ObjectPool available with Unity 2021 and above
        private IObjectPool<InventoryItem> objectPool;

        private int? index;

        private List<int> things;
        // throw an exception if we try to return an existing item, already in the pool
        [SerializeField] private bool collectionCheck = true;

        // extra options to control the pool capacity and maximum size
        [SerializeField] private int defaultCapacity = 20;
        [SerializeField] private int maxSize = 100;
        [SerializeField] InventoryItem inventoryItemPrefab;
        [SerializeField] Transform inventoryLayout;

        private void Awake()
        {
            objectPool = new ObjectPool<InventoryItem>(CreatePooledItem,
                OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject,
                collectionCheck, defaultCapacity, maxSize);

            MessageBroker.Default.Receive<ItemAdded>().TakeUntilDestroy(gameObject).Subscribe(OnItemAdded);
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

        private void OnItemAdded(ItemAdded itemAdded)
        {
            var item = CreatePooledItem();
            item.transform.SetParent(inventoryLayout, false);
            item.Set(itemAdded.Pickup.icon, 1);
        }
    }
}