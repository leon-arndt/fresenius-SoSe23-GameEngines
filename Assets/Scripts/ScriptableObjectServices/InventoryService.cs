using UnityEngine;

namespace ScriptableObjectServices
{
	[CreateAssetMenu(fileName = "New InventoryService", menuName = "Services/InventoryService")]
	public class InventoryService : ScriptableObject, IService
	{
		public uint startingGold;

		public void Add(object item, uint amount)
		{
			// TODO
		}

		public void Restart()
		{
			// TODO
		}
	}
}
