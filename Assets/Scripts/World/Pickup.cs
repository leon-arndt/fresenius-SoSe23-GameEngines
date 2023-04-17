using Data;
using UnityEngine;

namespace World
{
	public class Pickup : MonoBehaviour, IInteractable
	{
		[SerializeField] private ScriptableObject itemType;

		public void Interact()
		{
			switch (itemType)
			{
				case InstantPickup instantPickup:
					instantPickup.OnPickup();
					break;
			}

			Destroy(gameObject);
		}
	}
}
