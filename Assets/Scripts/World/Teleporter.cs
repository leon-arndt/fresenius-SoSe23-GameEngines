using UnityEngine;

namespace World
{
    public class Teleporter : MonoBehaviour
    {
        [SerializeField] private WorldCharacterType affectedType;
        [SerializeField] private Transform target;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<WorldCharacter>(out var worldCharacter) &&
                worldCharacter.worldCharacterType == affectedType)
            {
                worldCharacter.GetComponent<CharacterController>().enabled = false;
                worldCharacter.transform.position = target.position;
                worldCharacter.GetComponent<CharacterController>().enabled = true;
            }
        }
    }
}