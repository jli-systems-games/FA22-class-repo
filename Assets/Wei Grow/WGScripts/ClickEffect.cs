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
            point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4f);//����������
            point = Camera.main.ScreenToWorldPoint(point);//����Ļ�ռ�ת��������ռ�
            GameObject go = Instantiate(effectGo);//������Ч
            go.transform.position = point;
            Destroy(go, 0.5f);
        }
    }
}