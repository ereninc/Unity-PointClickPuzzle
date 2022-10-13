using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : ControllerBaseModel
{
    [SerializeField] private PointerController pointerController;
    public InteractableBaseModel OnInteractObject, OnDropInteractObject;
    private RaycastHit hit;
    private Ray ray;

    public override void Initialize()
    {
        base.Initialize();
    }

    public override void ControllerUpdate(GameStates currentState)
    {
        base.ControllerUpdate(currentState);
        if (currentState == GameStates.Game)
        {
            pointerController.ControllerUpdate();
        }
    }

    public void OnPointerDown() 
    {
        OnDropInteractObject = null;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (OnInteractObject = hit.transform.GetComponent<InteractableBaseModel>())
            {
                OnInteractObject.OnInteract();
            }
        }
    }

    public void OnPointer()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (OnInteractObject == null)
            {
                if (OnInteractObject = hit.transform.GetComponent<InteractableBaseModel>())
                {
                    OnInteractObject.OnInteract();
                }
            }
            else
            {
                if (OnDropInteractObject = hit.transform.GetComponent<InteractableBaseModel>())
                {
                    if (OnInteractObject != OnDropInteractObject)
                    {
                        OnDropInteractObject.OnInteract();
                    }
                }
            }
        }
    }

    public void OnPointerUp()
    {
        OnDropInteractObject = null;
        OnInteractObject = null;
    }
}