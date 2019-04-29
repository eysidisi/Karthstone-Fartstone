using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fartstone.Combat.Triggers.Battlecries
{
    /// <summary>
    /// Battlecry that draws card(s)
    /// </summary>
    public class BCDrawCard : Battlecry
    {
        [SerializeField] int numberOfCardsToDraw;
        public override void InitializeTrigger()
        {
            print("Draw "+numberOfCardsToDraw +"cards");
        }
    }
}