using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ataque : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform firePoint;
    public Slider fuerzaSlider;
    public float maxForce = 1000f;

    public void ShootProjectile()
    {
        GameObject projectile = Instantiate(proyectilPrefab, firePoint.position, firePoint.rotation);
        float force = fuerzaSlider.value * maxForce;

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * force);
    }
}
