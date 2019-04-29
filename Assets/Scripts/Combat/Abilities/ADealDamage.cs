using Fartstone.Cards;
using Fartstone.Combat.Core;
using Fartstone.Core.Hero;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fartstone.Combat.Abilities
{
    /// <summary>
    /// Damage dealing ability
    /// </summary>
    public class ADealDamage :Ability
    {
        [SerializeField] int damageAmount;
        EnemyHero enemyHero;

        private void Start()
        {
            // Cache enemy hero
            enemyHero = FindObjectOfType<EnemyHero>();
        }

        
        protected override void InitializeAbility()
        {
            // Deal damage
            enemyHero.GetComponent<Health>().TakeDamage(damageAmount);
        }
    }
}