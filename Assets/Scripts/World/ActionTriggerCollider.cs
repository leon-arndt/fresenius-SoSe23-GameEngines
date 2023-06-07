using UnityEngine;
using UnityEngine.Events;

namespace World
{
    public class ActionTriggerCollider : MonoBehaviour
    {
        [SerializeField] private WorldCharacterType characterType;
        [SerializeField] private bool playOnce;
        [SerializeField] private UnityEvent callback;

        private bool isAlreadyPlayed;

        private void OnTriggerEnter(Collider other)
        {
            if (playOnce && isAlreadyPlayed)
            {
                return;
            }

            if (other.GetComponent<WorldCharacter>()?.worldCharacterType == characterType)
            {
                callback?.Invoke();
                isAlreadyPlayed = true;
            }
        }
    }
}