using ScriptableObjectServices;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(fileName = "New ItemPickup", menuName = "Items/ItemPickup")]
	public class ItemPickup : InstantPickup
	{
		public uint amount;

		public override void OnPickup()
		{
			ScriptableObjectServiceLocator.Get<InventoryService>().Add(this, amount);
		}
	}
}
