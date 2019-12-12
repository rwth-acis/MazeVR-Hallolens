using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour, IMixedRealityPointerHandler
{

    private DoorController contr;
    private bool state = false;

    // Use this for initialization
    void Start () {
        contr = gameObject.GetComponent<DoorController>();
        contr.DoorOpen = false;
	}

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        if (contr.DoorOpen == false)
        {
            contr.DoorOpen = true;
        }
        else
        {
            contr.DoorOpen = false;
        };
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        contr.DoorOpen = contr.DoorOpen;
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        if (contr.DoorOpen == false)
        {
            contr.DoorOpen = true;
        }
        else
        {
            contr.DoorOpen = false;
        };
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        if (contr.DoorOpen == false)
        {
            contr.DoorOpen = true;
        }
        else
        {
            contr.DoorOpen = false;
        };
    }
}
