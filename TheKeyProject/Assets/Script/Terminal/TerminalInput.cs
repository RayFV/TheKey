﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TerminalInput : MonoBehaviour {
    public TMP_InputField inputField;

    private TerminalController controller;
    
	void Awake () {
        controller = GetComponent<TerminalController>();
        inputField.onEndEdit.AddListener(AcceptStringInput);
	}

    void AcceptStringInput(string userInput)
    {
        controller.LogString(userInput);
        userInput = userInput.ToLower();

        char[] delimiterCharacters = { ' ' };
        string[] separatedInputWords = userInput.Split(delimiterCharacters);
        bool isRespond = false;
        for (int i = 0; i < controller.inputCmds.Length; i++)
        {
            TerminalInputCommand inputCmd = controller.inputCmds[i];
            if (inputCmd.keyword == separatedInputWords[0])
            {
                inputCmd.Respond(controller, separatedInputWords);
                isRespond = true;
            }
            else
            {
                
            }
        }

        if (!isRespond)
        {
            controller.LogString(separatedInputWords[0] +
                    " is unable, please type \"help\" to see all the commands.");
        }

        InputComplete();
    }

    private void InputComplete()
    {
        controller.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
