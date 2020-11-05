/*
 * 该脚本应挂载于一个空物体下
 * 
 * 实现：
 * 1.动态传入场景中多个相机
 * 2.按C键循环切换机位
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public List<GameObject> cams;           // 相机数组
    private int camFlag;

    private void Start()
    {
        camFlag = 1;
        _switch();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))    // 每按下C键
        {
            camFlag++;                      // 标志位加一

            if (camFlag > cams.Count)       // 越位归位
            {
                camFlag = 1;
            }

            _switch();
        }
    }

    void _switch()  // 切换相机
    {
        for (int i = 0; i < cams.Count; i++)
        {
            if (i == camFlag - 1)
            {
                cams[i].SetActive(true);
            }
            else
            {
                cams[i].SetActive(false);
            }
        }
    }
}
