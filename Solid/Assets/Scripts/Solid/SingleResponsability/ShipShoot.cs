using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    public Transform shootPosition;

    public GameObject projectilePrefab;

    public float shootForce = 30;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
        GameObject bullet = Instantiate(projectilePrefab, shootPosition.position, shootPosition.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPosition.forward * shootForce, ForceMode.Impulse);
        }
    }
}