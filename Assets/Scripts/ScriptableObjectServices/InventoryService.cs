using System;
using Data;
using UnityEngine;

namespace ScriptableObjectServices
{
	[CreateAssetMenu(fileName = "New InventoryService", menuName = "ScriptableObjects/InventoryService")]
	public class InventoryService : ScriptableObject
	{
		public void Add(object item, int amount = 1)
		{
			switch (item)
			{
				case ItemPickup itemPickup:
					AddItemPickup(itemPickup);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void AddItemPickup(ItemPickup itemPickup)
		{
			throw new NotImplementedException();
		}

		public int Count(object item)
		{
			return 0;
		}
	}
}
