using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
//相机视角跟踪
public class Follow_Target : MonoBehaviour {
 
    //游戏人物 的位置
    private Transform player;
 
    //游戏人物与 相机的差
    private Vector3 offset;
 
    //相机的速度
    private float smoothing = 10;
 
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("player").transform;
        offset = transform.position - player.position;
    }
 
 
    // Update is called once per frame
    void LateUpdate() {
        //player.TransformDirection(offset)
        //世界坐标转换为局部坐标
        Vector3 targetPosition = player.position + player.TransformDirection(offset);
        //Vector3.Lerp 计算相机位置 和 目标位置的插值
        transform.position = Vector3.Lerp(transform.position,targetPosition,Time.deltaTime * smoothing);
        //相机的目标看向 游戏人物
        //transform.LookAt(player.position);
	}
}
