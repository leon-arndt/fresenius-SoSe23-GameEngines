using UnityEngine;

namespace Dialog
{
	[CreateAssetMenu(fileName = "New Dialog Sequence", menuName = "ScriptableObjects/Dialog Sequence")]
	public class DialogSequence : ScriptableObject
	{
		public Dialog[] dialogs;
		public bool interruptCurrent;
	}

	[System.Serializable]
	public struct Dialog
	{
		public Speaker speaker;
		public string contents;
		public AudioClip audioClip;
	}
}
