using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class PlayerController : TankController
{
    private Camera _camera;
    public void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //Vector3 direction = new Vector3(horizontal, vertical);
        //Move(direction);
        ////Vector3 gunDirection = new Vector3(
        ////       Input.mousePosition.x - Screen.width / 2,
        ////       Input.mousePosition.y - Screen.height / 2
        ////   );
        var position = Input.mousePosition;
        Vector3 gunDirectionmoba = new Vector3(
              position.x - Screen.width / 2,
              position.y - Screen.height / 2
          );
        RotateGun(gunDirectionmoba);
        //if (Input.GetMouseButton(1))
        //{
        //    Shoot();
        //}
    }

    public void Moveleft()
    {
        var left = new Vector3(-10, 0, 0);
        Move(left);
    }
    public void MoveRight()
    {
        var right = new Vector3(10, 0, 0);
        Move(right);
    }
    public void MoveUp()
    {
        var up = new Vector3(0, 10, 0);
        Move(up);
    }
    public void MoveDown()
    {
        var down = new Vector3(0, -10, 0);
        Move(down);
    }
}
public class Player : SingletonMonoBehaviour<PlayerController>
{

}