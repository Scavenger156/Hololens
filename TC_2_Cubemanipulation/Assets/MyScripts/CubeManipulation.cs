using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class CubeManipulation : MonoBehaviour, IManipulationHandler, IInputClickHandler
{
    [Tooltip("Rotation speed")]
    public float rotationSpeed = 10.0f;

    
    void Start () {
		
	} 
	void Update () {
		
	}

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {       
        float rotationFactor = eventData.CumulativeDelta.x * rotationSpeed;
        transform.Rotate(new Vector3(0, -1 * rotationFactor,0));
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("OnInputClicked");
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
       
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
       
    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
       
    }
}
