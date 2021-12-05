using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : TankController
{
    private void Update()
    {
        var playerpos = Player.Instance.transform.position;
        var direction = playerpos - transform.position;
        Move(direction);
        RotateGun(direction);
        if (Random.Range(0, 100) % 50 == 0)
        {
            Shoot();
        }
    }
}
