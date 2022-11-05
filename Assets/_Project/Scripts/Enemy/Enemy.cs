using System;
using UnityEngine;

namespace _Project.Scripts.Enemy
{
    public class Enemy : MonoBehaviour,IDamageable
    {
        [SerializeField] private Animator animator;
        [SerializeField] private float hitPoints = 100f;
        private float _currentHitPoints;

        private void Start()
        {
            _currentHitPoints = hitPoints;
        }

        public void Damage(float damage)
        {
            _currentHitPoints -= damage;
            if (_currentHitPoints <= 0f)
            {
                animator.SetBool("isDead", true);
                GetComponent<Collider>().enabled = false;
                GetComponentInChildren<Renderer>().material.SetColor("_Color", Color.gray);
            }
        }
    }
}