using UnityEngine;

namespace World
{
	public class InteractorCamera : MonoBehaviour
	{
		[SerializeField] private float maxDistance = 2f;

		private void Update()
		{
			if (Input.GetButtonDown("Fire1"))
			{
				RaycastHit hit;
				if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit,
					    maxDistance))
				{
					IInteractable foundInteractable = hit.collider.GetComponent<IInteractable>();
					if (foundInteractable != null)
					{
						foundInteractable.Interact();
					}
				}
			}
		}
	}
}
