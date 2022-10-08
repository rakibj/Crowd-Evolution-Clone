using System;
using RakibJahan;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Modifiers
{
    public class ModifierCrowd : ModifierBase
    {
        [SerializeField] private Image backgroundImage;
        [SerializeField] private TMP_Text amountText;
        [SerializeField] private int crowdModifyAmount = 2;
        [SerializeField] private Color positiveColor;
        [SerializeField] private Color negativeColor;
        private bool _isPositive;

        private void Start()
        {
            _isPositive = crowdModifyAmount > 0;
            backgroundImage.color = _isPositive ? positiveColor : negativeColor;
            amountText.text = _isPositive ? "+" + crowdModifyAmount : "" + crowdModifyAmount;
        }

        public override void Modify(PlayerController playerController)
        {
            var playerCrowd = playerController.GetComponent<PlayerCrowd>();
            for (int i = 0; i < Mathf.Abs(crowdModifyAmount); i++)
            {
                if(_isPositive) playerCrowd.AddShooter();
                else playerCrowd.RemoveShooter();
            }
        }
    }
}