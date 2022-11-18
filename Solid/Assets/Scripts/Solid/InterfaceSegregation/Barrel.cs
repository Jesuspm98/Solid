using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, IDamageable
{
    public void TakeDamage(int damageAmount)
    {
        Destroy(gameObject);
    }

    void IDamageable.Interact()
    {
        throw new System.NotImplementedException();
    }
}