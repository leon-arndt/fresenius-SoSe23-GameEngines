using UnityEngine;

namespace World
{
    public class AnimateY : MonoBehaviour
    {
        [SerializeField] private AnimationCurve curve;
        private Vector3 startPosition;
        [SerializeField]
        private float animationTime = 1f;
        [SerializeField]
        private float animationFactor = 1f;

        [SerializeField]
        private bool randomStart;

        private float randomOffset;
        
        private void Start()
        {
            startPosition = transform.position;
            if (randomStart)
            {
                randomOffset = Random.value;
            } 
        }

        private void Update()
        {
            transform.position = startPosition + animationFactor *  Vector3.up * (curve.Evaluate(((Time.timeSinceLevelLoad + randomOffset)/ animationTime) % 1));
        }
    }
}