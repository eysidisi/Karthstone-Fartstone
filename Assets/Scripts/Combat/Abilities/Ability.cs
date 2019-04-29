using Fartstone.Cards;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fartstone.Combat.Abilities
{
    /// <summary>
    /// Base class for abilities
    /// </summary>
    public abstract class Ability : MonoBehaviour
    {
        protected abstract void InitializeAbility();
    }
}