using TMPro;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace UserInterface
{
    public class InventoryItem : MonoBehaviour

    {
        [SerializeField] private TextMeshProUGUI amount;
        [SerializeField] private Image icon;

        public void Set(Sprite sprite, uint newAmount)
        {
            icon.sprite = sprite;
            amount.text = newAmount.ToString();
        }
    }
}