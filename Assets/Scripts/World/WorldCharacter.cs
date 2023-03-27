using UnityEngine;

namespace World
{
	public class WorldCharacter : MonoBehaviour
	{
		public WorldCharacterType worldCharacterType;
	}

	public enum WorldCharacterType
	{
		Player,
	}
}
