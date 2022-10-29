using System;
using _Project.Scripts.Enemy;
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

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.CompareTag("Damageable"))
            {
                var damageable = collision.transform.GetComponentInChildren<IDamageable>();
                damageable.Damage(_damagePerHit);
                Destroy(gameObject);
            }
        }
    }
}