using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class ShowNumber : MonoBehaviour {
    private int tmp = 20;
    // Use this for initialization
    void Start () {
        //开启一个协程
        StartCoroutine("changeTime");
    }
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 24;
        //GUILayout.Label("你好。1234", myStyle);
        GUILayout.BeginArea(new Rect(100,100,600,100));
        //GUILayout.Label("Battery Left:" + tmp + "%", GUILayout.Width(900));
        if(tmp>0)
        {
            GUILayout.Label("电量剩余:" + tmp + "%", myStyle);
        }
        else
        {
            GUILayout.Label("电量耗尽\n即将重启本关卡", myStyle);
        }
        //GUILayout.Label("Battery Left:" + tmp + "%", myStyle);
        GUILayout.EndArea();
    }
     
    IEnumerator changeTime()
    {
        while(tmp > 0)
        {
            //暂停一秒
            yield return new WaitForSeconds(8);
            tmp--;
        }
        yield return new WaitForSeconds(3);
        EditorSceneManager.LoadScene("SampleScene");
    }
}