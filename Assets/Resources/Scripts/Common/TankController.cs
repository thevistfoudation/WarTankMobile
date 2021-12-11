using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class TankController : MoveController
{
    [SerializeField]
    Transform Gun;

    [SerializeField]
    protected Transform Than;

    [SerializeField]
    Transform tranShoot;

    public BulletController prefabBullet;

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
        // Instantiate(prefabBullet, tranShoot.position, tranShoot.rotation);
        createBullet(tranShoot);
    }

    public BulletController createBullet(Transform tranShoot)
    {
        BulletController bullet = PoolingObject.createPooling<BulletController>(prefabBullet);
        if (bullet == null)
        {
            return Instantiate(prefabBullet, tranShoot.position, tranShoot.rotation);
        }
        bullet.time = 0;
        bullet.transform.position = tranShoot.position;
        bullet.transform.rotation = tranShoot.rotation;
        return bullet;
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
