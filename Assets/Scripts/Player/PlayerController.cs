using System;
using Modifiers;
using UnityEngine;

namespace RakibJahan
{
    public class PlayerController : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Modifier"))
            {
                var modifier = other.GetComponent<ModifierLog>();
                if (modifier)
                {
                    modifier.Modify(this);
                }
            }
        }
    }
}