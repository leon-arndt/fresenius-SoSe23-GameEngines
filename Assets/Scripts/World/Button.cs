using UnityEngine;
using UnityEngine.Events;

namespace World
{
	public class Button : MonoBehaviour, IInteractable
	{
		public UnityEvent OnInteract;

		public void Interact()
		{
			OnInteract?.Invoke();
		}
	}
}
