﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalImageControl : MonoBehaviour, EscClose {

    public Image image;
    private TerminalController controller;

    public void ShowImage(Sprite sprite, TerminalController controller)
    {
        this.controller = controller;
        controller.SetInputFieldActive(false);
        image.sprite = sprite;
        gameObject.SetActive(true);
        EscStack.instance.Push(this);
    }

    public void Close()
    {
        controller.SetInputFieldActive(true);
        gameObject.SetActive(false);
    }
    
}
