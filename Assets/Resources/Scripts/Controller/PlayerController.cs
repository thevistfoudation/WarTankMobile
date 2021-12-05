using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public GameObject gun;
    public GameObject Bullet;
    public Transform Transhoot;
    public GameObject BodyTank;
    public GameObject Player;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.LogError("Awaken");
    }
    void Start()
    {
        Debug.LogError("start");
    }
    private void OnEnable()
    {
        Debug.LogError("eneble");
    }
    private void OnDestroy()
    {
        Debug.LogError("Destroy");
    }
    // Update is called once per frame
    void Update()
    {
        TankMove();
        RotateGun();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void TankMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);
        BodyTank.gameObject.transform.position += direction * Time.deltaTime * speed;
        if (direction != Vector3.zero)
        {
            this.gameObject.transform.up = direction;
        }
    }
    public int level;

    public void Shoot()
    {
        Instantiate(Bullet, Transhoot.position, Transhoot.rotation);
        Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY,level);
    }

    private void RotateGun()
    {
        Vector3 gunDirection = new Vector3(
             Input.mousePosition.x - Screen.width / 2,
             Input.mousePosition.y - Screen.height / 2
         );
        gun.gameObject.transform.up = gunDirection;

    }
}
