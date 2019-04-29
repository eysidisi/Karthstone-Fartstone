using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fartstone.Cards;
using Fartstone.Combat.Core;
using Fartstone.Core.EnumDefinations;

namespace Fartstone.Core
{

    public class CardDisplay : MonoBehaviour
    {

        [SerializeField] Card card;
        [SerializeField] Text titleText;
        [SerializeField] Text descriptionText;
        [SerializeField] Rarity rarity;
        [SerializeField] Image portraitImage;
        [SerializeField] Image rarityImage;
        [SerializeField] Text manaText;
        [SerializeField] Text attackText;
        [SerializeField] Text healthText;

        // Use this for initialization
        void Start()
        {
            InitializeAttributes();
        }

        private void InitializeAttributes()
        {
            titleText.text = card.Title;
            rarity = card.Rarity;
            portraitImage.sprite = card.Portrait;
            descriptionText.text = card.Description;
            manaText.text = card.ManaCost.ToString();
            rarity = card.Rarity;

            if (GetComponent<Health>() != null)
            {
                healthText.text = GetComponent<Health>().HealthVal.ToString();
            }

            else
            {
                healthText.text = null;
            }

            if (GetComponent<Attack>() != null)
            {
                attackText.text = GetComponent<Attack>().AttackVal.ToString();
            }

            else
            {
                attackText.text = null;
            }

            switch (rarity)
            {
                case Rarity.None:
                    rarityImage.gameObject.SetActive(false);
                    break;
                case Rarity.Common:
                    rarityImage.color = Color.white;
                    break;
                case Rarity.Rare:
                    rarityImage.color = Color.blue;
                    break;
                case Rarity.Epic:
                    rarityImage.color = new Color(160, 32, 240);
                    break;
                case Rarity.Legendary:
                    rarityImage.color = new Color(255, 140, 0);
                    break;
                default:
                    break;
            }
        }
    }
}