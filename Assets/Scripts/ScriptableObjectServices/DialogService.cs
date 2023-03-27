using Data;
using UnityEngine;

namespace ScriptableObjectServices
{
	[CreateAssetMenu(fileName = "New Dialog Service", menuName = "ScriptableObjects/Dialog Service")]
	public class DialogService : ScriptableObject
	{
		public void Play(DialogSequence dialog)
		{
			// TODO: UI
			// TODO: set current dialog sequence
			// TODO: set current dialog sequence step int
			// TODO: play audio
		}
	}
}
