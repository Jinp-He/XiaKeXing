using QFramework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MatchThree {
    public class MatchThree : Architecture<MatchThree>
    {
        protected override void Init()
        {
            ResKit.Init();

            // Register System
            RegisterSystem<GameSystem>(new GameSystem());
            // Register Utility
            //RegisterSystem<IDialogue>(new DialogueSystem());

            // Register Models
        }

     
    }
}