using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Gun : MonoBehaviour
    {
        public Animator animator;
        public Transform bulletSpawnPoint;
        public GameObject bulletPrefab;
        public float bulletSpeed = 10;

        private void Start()
        {
        animator = GetComponent<Animator>();
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
            animator.SetBool("Shoot", true);
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            }
            else
            {
            animator.SetBool("Shoot", false);
            }
    }
    }