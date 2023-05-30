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
		[TextArea(1, 10)]
		public string contents;
		public AudioClip audioClip;
	}
}
