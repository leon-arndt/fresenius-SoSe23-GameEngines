using DG.Tweening;
using UnityEngine;

namespace World
{
    public class ShaderAnimation : MonoBehaviour
    {
        [SerializeField] private Material material;
        [SerializeField] private float animationDurationSeconds;
        [SerializeField] private string parameterName;

        private void Start()
        {
            material = material;
        }

        public void Play()
        {
            DOVirtual.Float(
                0f,
                1,
                animationDurationSeconds,
                (v) =>
                {
                    material.SetFloat(parameterName, v);
                });
        }
    }
}