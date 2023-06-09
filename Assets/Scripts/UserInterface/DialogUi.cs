using Data;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace UserInterface
{
    public class DialogUi : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI dialogText;

        private void Start()
        {
            gameObject.SetActive(false);
        }

        public void Set(Speaker speakerName, string dialog)
        {
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
            
            gameObject.SetActive(true);
            
        }
    }
}