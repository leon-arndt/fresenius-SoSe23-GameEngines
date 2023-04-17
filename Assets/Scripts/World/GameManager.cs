using ScriptableObjectServices;
using UnityEngine;

namespace World
{
	public class GameManager : MonoBehaviour
	{
		private void Awake()
		{
			ScriptableObjectServiceLocator.StartAll();
		}
	}
}
