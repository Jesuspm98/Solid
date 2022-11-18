using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullShip : MonoBehaviour
{
    public float movementSpeed = 20;
    public float rotationSpeed = 60;

    public int maxHealth;
    private int currentHealth;

    public Transform shootPosition;

    public GameObject projectilePrefab;

    public float shootForce = 30;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
        transform.position += transform.forward * movementSpeed * Time.deltaTime * vertical;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(projectilePrefab, shootPosition.position, shootPosition.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPosition.forward * shootForce, ForceMode.Impulse);
        }
    }
}