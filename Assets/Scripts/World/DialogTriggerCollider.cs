using Data;
using ScriptableObjectServices;
using UnityEngine;

namespace World
{
	[RequireComponent(typeof(Collider))]
	public class DialogTriggerCollider : MonoBehaviour
	{
		[SerializeField] private DialogSequence dialogSequence;
		[SerializeField] private WorldCharacterType characterType;
		[SerializeField] private bool playOnce;
		[SerializeField] private DialogService dialogService;

		private bool isAlreadyPlayed;

		private void OnTriggerEnter(Collider other)
		{
			if (playOnce && isAlreadyPlayed)
			{
				return;
			}

			if (other.GetComponent<WorldCharacter>()?.worldCharacterType == characterType)
			{
				dialogService.Play(dialogSequence);
				isAlreadyPlayed = true;
			}
		}
	}
}
