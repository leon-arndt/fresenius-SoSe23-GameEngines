using Data;
using TMPro;
using UnityEngine;

namespace UserInterface
{
    public class DialogUi : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI dialogText;

        public void Set(Speaker speakerName, string dialog)
        {
            dialogText.text = $"<color=#ffff00> {speakerName.speakerName} </color> {dialog}";
        }
    }
}