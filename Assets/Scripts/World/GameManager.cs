using System;
using ScriptableObjectServices;
using UnityEngine;

namespace World
{
	public class GameManager : MonoBehaviour
	{
		private void Awake()
		{
			GameServiceLocator.StartAll();
		}
	}
}
