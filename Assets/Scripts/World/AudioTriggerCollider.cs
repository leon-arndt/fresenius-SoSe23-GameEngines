using UnityEngine;

namespace World
{
	[RequireComponent(typeof(Collider))]
	public class AudioTriggerCollider : MonoBehaviour
	{
		[SerializeField] private AudioSource source;
		[SerializeField] private WorldCharacterType characterType;
		[SerializeField] private bool playOnce;
		private bool isAlreadyPlayed;

		private void OnTriggerEnter(Collider other)
		{
			if (playOnce && isAlreadyPlayed)
			{
				return;
			}

			if (other.GetComponent<WorldCharacter>()?.worldCharacterType == characterType)
			{
				source.Play();
				isAlreadyPlayed = true;
			}
		}
	}
}
