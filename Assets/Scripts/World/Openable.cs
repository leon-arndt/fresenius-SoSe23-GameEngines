using UnityEngine;

namespace World
{
	public class Openable : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;
		private static readonly int IsOpen = Animator.StringToHash("IsOpen");

		public void Open()
		{
			anim.SetBool(IsOpen, true);
		}

		public void Close()
		{
			anim.SetBool(IsOpen, false);
		}
	}
}
