using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform aimTransform;

    public Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;

    private Vector3 mousePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        PointAtMouse();
    }

    private void Shoot()
    {
       GameObject bullet = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.rotation);

       Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(mousePos * bulletSpeed, ForceMode2D.Impulse);
    }

    private void PointAtMouse()
    {
        Vector3 lookDir = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }
}
