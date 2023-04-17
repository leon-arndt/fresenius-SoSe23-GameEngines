using UnityEngine;

namespace Data
{
	public class DialogSequence : ScriptableObject
	{
		public bool shouldInterrupt;
		public DialogData[] dialogData;
	}

	[System.Serializable]
	public struct DialogData
	{
		public SpeakerData speaker;
		public string contents;
		public AudioClip audioClip;
	}
}
