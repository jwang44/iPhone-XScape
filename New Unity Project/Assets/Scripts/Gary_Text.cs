using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gary_Text : MonoBehaviour {

    public Transform WuTi;

    public float speed = 1;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        //上
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position += transform.forward * speed;
        }
        //下
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.position += transform.forward * speed;
        }
        //左
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 270, 0);
            transform.position += transform.forward * speed;
        }
        //右
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            transform.position += transform.forward * speed;
        }
    }
}
