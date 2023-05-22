using UnityEngine;

namespace World
{
	public class DialogPlayer : MonoBehaviour
	{
		public void PlayAudio(AudioClip audioClip)
		{
			var audioSource = GetComponent<AudioSource>();
			audioSource.clip = audioClip;
			audioSource.Play();
		}
	}
}
