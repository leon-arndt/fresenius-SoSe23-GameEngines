using ScriptableObjectServices;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(fileName = "New ItemPickup", menuName = "Items/ItemPickup")]
	public class ItemPickup : InstantPickup
	{
		public override void OnPickup()
		{
			ScriptableObjectServiceLocator.Get<InventoryService>().Add(this);
		}
	}
}
