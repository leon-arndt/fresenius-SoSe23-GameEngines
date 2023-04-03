using Data;
using UnityEngine;

namespace World
{
	public class Pickup : IInteractable
	{
		[SerializeField] private ScriptableObject itemType;

		public void Interact()
		{
			switch (itemType)
			{
				case InstantPickup pickup:
					pickup.OnPickup();
					break;
			}
		}
	}
}
