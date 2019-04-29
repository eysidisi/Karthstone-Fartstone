using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fartstone.Cards;

namespace Fartstone.Combat.Core
{
    /// <summary>
    /// Attack script for cards with attack attribute
    /// </summary>
    public class Attack :MonoBehaviour
    {
        [SerializeField] int attackVal;
        public int AttackVal { get => attackVal; }

        public void HitTarget(Health targetHealth)
        {
            
            // Target card needs to have health component
            if(targetHealth!=null)
            {
                targetHealth.TakeDamage(attackVal);
            }
            
        }
    }
}