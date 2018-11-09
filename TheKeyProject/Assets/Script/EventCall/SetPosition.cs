﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour {
    
    public Transform[] points;

    private EventDataGetter eventDataGetter;

    // Use this for initialization
    void Awake () {
        eventDataGetter = GetComponent<EventDataGetter>();
        Init();
	}

    private void Init()
    {
        int eventCode = eventDataGetter.GetData();
        if (eventCode >= points.Length || eventCode < 0)
        {
            return;
        }
        while(points[eventCode] == null)
        {
            eventCode--;
            if(eventCode == 0)
            {
                break;
            }
        }
        this.transform.position = points[eventCode].position;
    }
}
