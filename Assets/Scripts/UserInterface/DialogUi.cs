using Data;
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
            gameObject.SetActive(true);
            dialogText.text = $"<color=#ffff00> {speakerName.speakerName} </color> {dialog}";
        }
    }
}