using UnityEngine;

namespace Dialog
{
	[CreateAssetMenu(fileName = "New Speaker Sequence", menuName = "ScriptableObjects/Speaker Sequence")]
	public class Speaker : ScriptableObject
	{
		public Sprite speakerSprite;
		public string speakerName;
	}
}
