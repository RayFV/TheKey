﻿using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabylonAnswerChecker : MonoBehaviour {

    public Image img;
    public List<AnswerSlot> answerSlots;
    [SerializeField] private bool isAllAnswersCorret;

    public void CheckAllAnswers()               //判斷是否全部正確
    {
        foreach (AnswerSlot answer in answerSlots)  //判斷全部的答案是否正確
        {
            Debug.Log(answer.IsCorrect);
            isAllAnswersCorret = answer.IsCorrect;
            if (!isAllAnswersCorret)
            {
                break;
            }
        }
        Iscorrect();
    }

    public void Iscorrect()             //答案驗證
    {
        if (isAllAnswersCorret)
        {
            Flowchart.BroadcastFungusMessage("strong_box_correct_answer");
            img.color = Color.green;
        }
        else
        {
            Flowchart.BroadcastFungusMessage("strong_box_wrong_answer");
        }
    }

    public void ClearAll()
    {
        foreach (AnswerSlot answer in answerSlots)
        {
            answer.Clear();
        }
    }
}