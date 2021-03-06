﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class Digital : MonoBehaviour {
    GameManager gameManager;
    public Flowchart flowchart;
    public int num1;
    public int num2;
    public int num3;
    public int num4;
    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void isCorrect()
    {
        int _num1 = flowchart.GetIntegerVariable("數字1");
        int _num2 = flowchart.GetIntegerVariable("數字2");
        int _num3 = flowchart.GetIntegerVariable("數字3");
        int _num4 = flowchart.GetIntegerVariable("數字4");
        if ((_num1 == num1) && (_num2 == num2) && (_num3 == num3) && (_num4 == num4))
        {
            Debug.Log("correct");
            Flowchart.BroadcastFungusMessage("答對了");
            gameObject.SetActive(false);
            Flowchart.BroadcastFungusMessage("開啟寶相");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("答錯了");
        }
    }


    public void Close()
    {
        gameObject.SetActive(false);
        Flowchart.BroadcastFungusMessage("取消按鈕");
    }


}
