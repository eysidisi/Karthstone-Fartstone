using Fartstone.Combat.Triggers.Battlecries;
using Fartstone.Combat.Triggers.Deathrattles;
using Fartstone.Combat.Triggers.TakeDamageTriggers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fartstone.Core.Managers
{
    /// <summary>
    /// Script for managing cards
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        // All possible triggers
        Battlecry battlecry;
        Deathrattle deathrattle;
        TakeDamage takeDamage;

        private void Start()
        {
            battlecry = GetComponent<Battlecry>();
            deathrattle = GetComponent<Deathrattle>();
            takeDamage = GetComponent<TakeDamage>();
        }

        // Called by game manager
        public void CardIsPlayed()
        {
            // If battlecry is attached
            if(battlecry!=null)
            {
                battlecry.InitializeTrigger();
            }
        }

        public void CardTookDamage()
        {
            // If takeDamage is attached
            if (takeDamage != null)
            {
                takeDamage.InitializeTrigger();
            }
        }

        public void CardIsDestroyed()
        {
            // If deathRattle is attached
            if (deathrattle != null)
            {
                deathrattle.InitializeTrigger();
            }
        }
    }
}
