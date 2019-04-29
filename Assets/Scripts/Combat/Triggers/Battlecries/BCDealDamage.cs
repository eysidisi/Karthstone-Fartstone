using Fartstone.Combat.Core;
using Fartstone.Core.Hero;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Fartstone.Combat.Triggers.Battlecries
{
    /// <summary>
    /// Deals damage to enemy hero
    /// </summary>
    public class BCDealDamage : Battlecry
    {
        [SerializeField] int damageAmount;


        public override void InitializeTrigger()
        {
            // Find enemy hero
            EnemyHero enemyHero = FindObjectOfType<EnemyHero>();

            // Get enemy hero health
            Health enemyHealth = enemyHero.GetComponent<Health>();

            // Deal damage
            enemyHealth.TakeDamage(damageAmount);

            // Print
            print("Damage is dealt");
        }
    }
}