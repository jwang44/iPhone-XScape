using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;
//-------------------------
public class Timer : MonoBehaviour
{
  //-------------------------
  //完成关卡的时间 (单位为秒)
  public float MaxTime = 60f;
  //-------------------------
  //倒计时
  [SerializeField]
  private float CountDown = 0;
  //-------------------------
  // start()是初始化函数
  void Start () 
  {
    CountDown = MaxTime;
  }
  //-------------------------
  // 每一帧都会调用update
  void Update () 
  {
    //时间减少
    CountDown -= Time.deltaTime;

    //当时间耗尽之后重启关卡t
    if(CountDown <= 0)
    {
      //重置金币的数量
      //Coin.CoinCount=0;
      //Application.LoadLevel(Application.loadedLevel);
      EditorSceneManager.LoadScene("SampleScene");
    }
  }
  //-------------------------
}