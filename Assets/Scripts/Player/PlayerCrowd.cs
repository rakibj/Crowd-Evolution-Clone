using System.Collections.Generic;
using UnityEngine;

namespace RakibJahan
{
    public class PlayerCrowd : MonoBehaviour
    {
        [SerializeField] private int crowdSizeForDebug = 5;

        [SerializeField] private PlayerShooter shooterPrefab;
        [SerializeField] private List<Transform> spawnPoints = new List<Transform>();
        private List<PlayerShooter> _shooters = new List<PlayerShooter>();

        [ContextMenu("Set")]
        public void Debug_ResizeCrowd() => Set(crowdSizeForDebug);
        
        public void Set(int amount)
        {
            if (_shooters.Count == amount) return;
            var needToRemove = amount < _shooters.Count;
            var needToAdd = amount > _shooters.Count;
            while (amount != _shooters.Count)
            {
                if(needToRemove) RemoveShooter();
                else if (needToAdd) AddShooter();
            }
        }

        private void RemoveShooter()
        {
            var lastShooter = _shooters[_shooters.Count - 1];
            _shooters.Remove(lastShooter);
            Destroy(lastShooter.gameObject);
        }

        private void AddShooter()
        {
            var lastShooterIndex = _shooters.Count - 1;
            var position = spawnPoints[lastShooterIndex + 1].position;
            var shooter = Instantiate(shooterPrefab, position, Quaternion.identity, transform);
            _shooters.Add(shooter);
        }
    }
}