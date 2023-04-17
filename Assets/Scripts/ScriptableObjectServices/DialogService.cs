using Data;
using UnityEngine;
using World;

namespace ScriptableObjectServices
{
	public class DialogService : ScriptableObject, IService
	{
		private DialogSequence currentSequence;
		private int currentStep;

		public void Restart()
		{
			currentSequence = null;
		}

		public void Play(DialogSequence sequence)
		{
			if (currentSequence != null && !sequence.shouldInterrupt)
			{
				return;
			}

			currentSequence = sequence;
			currentStep = 0;
			FindObjectOfType<DialogPlayer>().PlayAudio(sequence.dialogData[0].audioClip);
		}
	}
}
