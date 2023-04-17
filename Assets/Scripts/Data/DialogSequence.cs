using UnityEngine;

namespace Data
{
	[CreateAssetMenu(fileName = "New Dialog Sequence", menuName = "ScriptableObjects/Dialog Sequence")]
	public class DialogSequence : ScriptableObject
	{
		public Dialog[] dialogData;
		public bool shouldInterrupt;
	}

	[System.Serializable]
	public struct Dialog
	{
		public Speaker speaker;
		public string contents;
		public AudioClip audioClip;
	}
}
