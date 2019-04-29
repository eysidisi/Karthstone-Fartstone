
using Fartstone.Core.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fartstone.Combat.Core
{
    /// <summary>
    /// Health script for cards with health attribute and also used for durability 
    /// </summary>
    public class Health : MonoBehaviour
    {
        [SerializeField] int healthVal;

        public int HealthVal { get => healthVal; }

        CardManager cardManager;

        private void Start()
        {
            // Cache cardManager
            cardManager = GetComponent<CardManager>();
        }

        public void TakeDamage(int attackVal)
        {
            // If card manager is attached
            if (cardManager != null)
            {
                // Call for any trigger attached
                cardManager.CardTookDamage();
            }

            healthVal = Mathf.Max(0, healthVal - attackVal);

            // Card is destroyed
            if(healthVal==0 && cardManager!=null)
            {
                cardManager.CardIsDestroyed();
            }
        }

        // Restore health
        public void RestoreHealth(int restoreVal)
        {
            healthVal += restoreVal;
        }
    }
}