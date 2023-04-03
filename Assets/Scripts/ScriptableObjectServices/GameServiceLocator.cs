using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ScriptableObjectServices
{
	public static class GameServiceLocator
	{
		private static Object[] _cachedServices;
		private const string Path = "ScriptableObjectServices";

		public static T Get<T>() where T : ScriptableObject
		{
			return (T)_cachedServices.First(x => x is T);
		}

		public static void StartAll()
		{
			var scriptableObjects = Resources.LoadAll(Path, typeof(ScriptableObject));
			foreach (var scriptableObject in scriptableObjects)
			{
				if (scriptableObject is IService service)
				{
					service.Restart();
				}
			}

			_cachedServices = scriptableObjects;
		}
	}
}
