using UnityEngine;

namespace RakibJahan
{
    public class Shootable : MonoBehaviour
    {
        private float _damagePerHit = 10;

        public void Init(float damagePerHit)
        {
            _damagePerHit = damagePerHit;
        }
    }
}