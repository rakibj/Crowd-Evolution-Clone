using RakibJahan;
using UnityEngine;

namespace Modifiers
{
    public class ModifierLog : MonoBehaviour
    {
        public void Modify(PlayerController playerController)
        {
            Debug.Log("Modify player");
        }
    }
}