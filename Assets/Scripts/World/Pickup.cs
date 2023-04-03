using Data;
using UnityEngine;
using UnityEngine.Events;

namespace World
{
	public class Pickup : MonoBehaviour, IInteractable
	{
		[SerializeField] private ScriptableObject itemType;
		[SerializeField] private UnityEvent onPickup;

		public void Interact()
		{
			onPickup?.Invoke();
			switch (itemType)
			{
				case InstantPickup pickup:
					pickup.OnPickup();
					break;
			}

			Destroy(gameObject);
		}
	}
}
