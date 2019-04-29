using Fartstone.Cards;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fartstone.Combat.Triggers
{
    /// <summary>
    /// Base class for triggers
    /// </summary>
    public abstract class Trigger : MonoBehaviour
    {
        public abstract void InitializeTrigger();
    }
}