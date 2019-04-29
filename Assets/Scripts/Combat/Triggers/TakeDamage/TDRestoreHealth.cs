using Fartstone.Combat.Core;
using Fartstone.Core.Hero;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fartstone.Combat.Triggers.TakeDamageTriggers
{
    /// <summary>
    /// Restores player hero health when damage is taken
    /// </summary>
    public class TDRestoreHealth : TakeDamage
    {
        [SerializeField] int healthRestoreVal;
        public override void InitializeTrigger()
        {
            FindObjectOfType<PlayerHero>().GetComponent<Health>().RestoreHealth(healthRestoreVal);
            print(healthRestoreVal + " health is restored");
        }
    }
}