using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fartstone.Core.EnumDefinations;

namespace Fartstone.Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Assets/NewCard", order = 1)]

    public class Card : ScriptableObject
    {
        #region attributes
        [SerializeField] int manaCost;
        [SerializeField] Rarity rarity;
        [SerializeField] Sprite portrait;
        [SerializeField] string title;
        [SerializeField] string description;
        [SerializeField] CardSetType cardSetType; 

        public int ManaCost { get => manaCost; }
        public Rarity Rarity { get => rarity; }
        public Sprite Portrait { get => portrait; }
        public string Title { get => title; }
        public string Description { get => description; }
        public CardSetType CardSetType { get => cardSetType;  }
        #endregion

    }
}