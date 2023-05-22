using Data;
using UnityEngine;
using UserInterface;
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
			var dialogData = sequence.dialogData[0];
			FindObjectOfType<DialogPlayer>().PlayAudio(dialogData.audioClip);
			FindObjectOfType<DialogUi>().Set(dialogData.speaker, dialogData.contents);
		}
	}
}
