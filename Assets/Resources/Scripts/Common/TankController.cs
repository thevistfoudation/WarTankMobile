using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MoveController
{
    [SerializeField]
    Transform Gun;

    [SerializeField]
    protected Transform Than;

    [SerializeField]
    Transform tranShoot;

    public GameObject bullet;

    public string opponent;
    public string item;
    protected override void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            Than.up = direction;
        }
        base.Move(direction);
    }

    protected void RotateGun(Vector3 direction)
    {
        Gun.up = direction;
    }

    public void Shoot()
    {
        Instantiate(bullet, tranShoot.position, tranShoot.rotation);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == opponent)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == item)
        {
            Destroy(gameObject);
        }
    }
}
