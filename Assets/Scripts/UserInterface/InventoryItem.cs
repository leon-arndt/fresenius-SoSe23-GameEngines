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

        // deactivate after delay
        [SerializeField] private float timeoutDelay = 3f;

        private IObjectPool<InventoryItem> objectPool;
        
        public IObjectPool<InventoryItem> ObjectPool { set => objectPool = value; }
        
        public void Set(Sprite sprite, uint newAmount)
        {
            icon.sprite = sprite;
            amount.text = newAmount.ToString();
        }

        public void Deactivate()
        {
            gameObject.SetActive(false);
        }
        
    }
}