using System;
using System.Collections.Generic;
using Data;
using Events;
using UniRx;
using UnityEngine;
using World;

namespace ScriptableObjectServices
{
    [CreateAssetMenu(fileName = "New InventoryService", menuName = "ScriptableObjects/InventoryService")]
    public class InventoryService : ScriptableObject, IService
    {
        private Dictionary<ItemPickup, uint> itemPickups;
        
        public void Add(object item, uint amount = 1)
        {
            switch (item)
            {
                case ItemPickup itemPickup:
                    AddItemPickup(itemPickup);
                    break;
                case ItemRecipe itemRecipe:
                    HandleItemRecipe(itemRecipe);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void HandleItemRecipe(ItemRecipe itemRecipe)
        {
            foreach (var ingredient in itemRecipe.ingredients)
            {
                // TODO: error handling
                itemPickups[ingredient.item] -= ingredient.amount;
            }

            AddItemPickup(itemRecipe.result);
        }

        private void AddItemPickup(ItemPickup itemPickup)
        {
            if (itemPickups.ContainsKey(itemPickup))
            {
                itemPickups[itemPickup]++;
            }
            else
            {
                itemPickups.Add(itemPickup, 1);
            }

            MessageBroker.Default.Publish(new ItemAdded { Pickup = itemPickup });
        }

        private static bool IsFloatingPlayerCharacter(WorldCharacter worldCharacter)
        {
            return worldCharacter.worldCharacterType == WorldCharacterType.Player &&
                   worldCharacter.transform.position.y > 10;
        }

        public int Count(object item)
        {
            return 0;
        }

        public void Restart()
        {
            itemPickups = new Dictionary<ItemPickup, uint>();
        }
    }
}