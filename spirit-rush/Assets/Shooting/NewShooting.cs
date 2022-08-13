using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShooting : MonoBehaviour
{
    public Bullets bullets;
    private float nextFire = 0.0F;
    // Start is called before the first frame update
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + bullets.firerate;
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bullets.projectile ,firePoint.position, firePoint.rotation);
        bullet.transform.localScale = bullet.transform.localScale*bullets.size;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bullets.speed, ForceMode2D.Impulse);

    }
}
