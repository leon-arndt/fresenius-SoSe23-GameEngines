using System.Collections.Generic;
using ScriptableObjectServices;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(fileName = "New ItemPickup", menuName = "Items/ItemRecipe")]
	public class ItemRecipe : InstantPickup
	{
		public List<Ingredient> ingredients;
		public ItemPickup result;

		public override void OnPickup()
		{
			ScriptableObjectServiceLocator.Get<InventoryService>().Add(this);
		}

		[System.Serializable]
		public struct Ingredient
		{
			public ItemPickup item;
			public uint amount;
		}
	}
}
