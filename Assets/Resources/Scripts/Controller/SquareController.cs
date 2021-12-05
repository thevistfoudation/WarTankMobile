using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Runsquare()
    {
        this.gameObject.transform.Rotate(0, 0, 1);
        if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(number, 0, 0);
        }
        else if (this.gameObject.transform.position.x >= number && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(0, number, 0);
            Debug.Log(this.gameObject.transform.position.y);
        }
        else if (this.gameObject.transform.position.x >= number && this.gameObject.transform.position.y >= number)
        {
            this.gameObject.transform.position += new Vector3(-number, 0, 0);
            Debug.LogError(this.gameObject.transform.position.x);
        }
        else if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y >= number)
        {
            this.gameObject.transform.position += new Vector3(0, -number, 0);
            Debug.Log(this.gameObject.transform.position.y);
        }
    }
}
