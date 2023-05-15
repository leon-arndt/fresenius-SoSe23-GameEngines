using UnityEngine;
using UnityEngine.Pool;

namespace UserInterface
{
    public class RevisedProjectile : MonoBehaviour
    {
        // deactivate after delay
        [SerializeField] private float timeoutDelay = 3f;

        private IObjectPool<RevisedProjectile> objectPool;

        // public property to give the projectile a reference to its ObjectPool
        public IObjectPool<RevisedProjectile> ObjectPool { set => objectPool = value; }

        public void Deactivate()
        {
            gameObject.SetActive(false);
        }
        
    }
}