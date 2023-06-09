using Data;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace UserInterface
{
    public class DialogUi : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI dialogText;
        [SerializeField] private CanvasGroup canvasGroup;

        private void Start()
        {
            gameObject.SetActive(false);
            canvasGroup.alpha = 0f;
        }

        public void Set(Speaker speakerName, string dialog, AudioClip dialogDataAudioClip)
        {
            gameObject.SetActive(true);
            canvasGroup.DOFade(1f, 1f).From(0f);
            var charactersPerSecond = 30f;
            var animationTime = dialog.Length / charactersPerSecond;
            DOVirtual.Float(
                0f,
                dialog.Length,
                animationTime,
                (v) =>
                {
                    var dialogSubText  = dialog.Substring(0, (int)v);
                    dialogText.text = $"<color=#ffff00> {speakerName.speakerName} </color> {dialogSubText}";
                });
            
            canvasGroup.DOFade(0f, 1f).SetDelay(dialogDataAudioClip.length * 1.1f);
        }
    }
}