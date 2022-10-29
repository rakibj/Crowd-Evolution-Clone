using RakibJahan;
using UnityEngine;

namespace Modifiers
{
    public class ModifierLog : ModifierBase
    {
        public override void Modify(PlayerController playerController)
        {
            Debug.Log("Modify player");
        }
    }
}