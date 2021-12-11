using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
using System;

public class BulletController : MonoBehaviour,IceSkill
{
    public int time = 0;
    public int speed = 0;
    public int dam;
    public GameObject smoke;
    public GameObject prebIce;


    // Start is called before the first frame update
    void Start()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, Getnotify);
    }

    private void Getnotify(object data)
    {
        Debug.LogError("game one");
    }

    private void OnDestroy()
    {
        Observer.Instance.RemoveObserver(TOPICNAME.ENEMYDESTROY, Getnotify);
        Debug.LogError("destroy bullet");
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        BulletEx();
    }
    private void BulletMove()
    {
        this.transform.position += transform.up * Time.deltaTime * speed;
    }
    private void BulletEx()
    {
        time += 1;
        if (time == 20)
        {
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Ice(100, prebIce);
            PoolingObject.DestroyPooling<BulletController>(this);
            return;
        }
    }

    public void Ice(int dameff, GameObject Ice)
    {
        Instantiate(Ice, this.gameObject.transform.position, this.gameObject.transform.rotation);
        dam = dameff;
    }
}
