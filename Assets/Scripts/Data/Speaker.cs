using UnityEngine;

namespace Data
{
	[CreateAssetMenu(fileName = "New Speaker", menuName = "ScriptableObjects/Speaker")]
	public class Speaker : ScriptableObject
	{
		public Sprite speakerSprite;
		public string speakerName;
	}
}
