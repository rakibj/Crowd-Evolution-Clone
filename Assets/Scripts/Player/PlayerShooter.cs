using System;
using UnityEngine;

namespace RakibJahan
{
    public class PlayerShooter : MonoBehaviour
    {
        [SerializeField] private float defaultShootDelay = 1f;
        [SerializeField] private float damagePerShootable = 100f;
        [SerializeField] private Shootable shootablePrefab;
        [SerializeField] private Transform shootFrom;
        private float _shootDelay;
        private float _runningTimer;

        private void Start()
        {
            _shootDelay = defaultShootDelay;
        }

        private void Update()
        {
            _runningTimer += Time.deltaTime;
            if (_runningTimer >= _shootDelay)
            {
                _runningTimer = 0f;
                Shoot();
            }
        }

        public void Shoot()
        {
            Instantiate(shootablePrefab, shootFrom.position, Quaternion.identity).Init(damagePerShootable);
        }
    }
}