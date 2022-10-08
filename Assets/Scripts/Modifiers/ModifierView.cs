using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Modifiers
{
    public class ModifierView : MonoBehaviour
    {
        [SerializeField] private Image backgroundImage;
        [SerializeField] private TMP_Text amountText;
        [SerializeField] private Color positiveColor;
        [SerializeField] private Color negativeColor;
        
        public void SetVisuals(bool isPositive, int amount)
        {
            backgroundImage.color = isPositive ? positiveColor : negativeColor;
            amountText.text = isPositive ? "+" + amount : "" + amount;
        }
    }
}