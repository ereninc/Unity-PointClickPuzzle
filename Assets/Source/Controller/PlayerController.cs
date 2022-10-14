using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : ControllerBaseModel
{
    [SerializeField] private PointerController pointerController;
    [SerializeField] private InteractableController interactableController;
    private InteractableBaseModel onInteractObject, onDropInteractObject;
    private RaycastHit hit;
    private Ray ray;

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
        onDropInteractObject = null;
        onRaycast();
    }

    public void OnPointer()
    {
        onRaycast();
    }

    public void OnPointerUp()
    {
        if (onInteractObject != null && onDropInteractObject != null)
        {
            if (interactableController.CheckCondition(onInteractObject, onDropInteractObject))
            {
                onInteractObject = null;
                onDropInteractObject = null;
            }
        }
    }

    private void onRaycast()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (onInteractObject == null)
            {
                onInteractObject = hit.transform.GetComponent<InteractableBaseModel>();
            }
            else
            {
                onDropInteractObject = hit.transform.GetComponent<InteractableBaseModel>();
            }
        }
    }
}