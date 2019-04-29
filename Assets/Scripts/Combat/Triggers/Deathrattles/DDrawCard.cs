using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Fartstone.Combat.Triggers.Deathrattles
{
    /// <summary>
    /// Deathrattle that draws card(s)
    /// </summary>
    public class DDrawCard : Deathrattle
    {
        [SerializeField] int numberOfCardsToDraw;
        public override void InitializeTrigger()
        {
            print("Draw " + numberOfCardsToDraw + " cards");
        }
    }
}