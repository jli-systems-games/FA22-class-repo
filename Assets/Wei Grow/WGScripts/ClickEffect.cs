using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffect : MonoBehaviour
{
    private Vector3 point;
    public GameObject effectGo;

    void Start()
    {
       
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4f);//获得鼠标点击点
            point = Camera.main.ScreenToWorldPoint(point);//从屏幕空间转换到世界空间
            GameObject go = Instantiate(effectGo);//生成特效
            go.transform.position = point;
            Destroy(go, 0.5f);
        }
    }
}