using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffectSounds : MonoBehaviour
{

    private Vector3 point;
    public GameObject[] effects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4f);//获得鼠标点击点
            point = Camera.main.ScreenToWorldPoint(point);//从屏幕空间转换到世界空间
            int effectsIndex = Random.Range(0, effects.Length);
            GameObject click = Instantiate(effects[effectsIndex]);//生成特效
            click.transform.position = point;
            Destroy(click, 0.5f);
        }



    }
}
