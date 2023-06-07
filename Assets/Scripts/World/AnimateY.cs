using System;
using UnityEngine;
using Random = UnityEngine.Random;

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

        [SerializeField]
        private bool playOnce;
        
        private float randomOffset;
        private float timeOffset;

        private void Start()
        {
            startPosition = transform.position;
            if (randomStart)
            {
                randomOffset = Random.value;
            } 
        }

        private void OnEnable()
        {
            timeOffset = Time.timeSinceLevelLoad;
        }

        private void Update()
        {
            var curvePosition = (Time.timeSinceLevelLoad - timeOffset + randomOffset) / animationTime;
            if (!playOnce)
            {
                curvePosition %= 1;
            }
            transform.position = startPosition + animationFactor *  Vector3.up * curve.Evaluate(curvePosition);
        }
    }
}