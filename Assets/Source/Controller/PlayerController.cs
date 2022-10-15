using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : ControllerBaseModel
{
    [SerializeField] private PointerController pointerController;
    [SerializeField] private InteractableController interactableController;
    private InteractableBaseModel onPointObject, onClickObject;
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
        onClickObject = null;
        onRaycast();
    }

    public void OnPointer()
    {
        onRaycast();
    }

    public void OnPointerUp()
    {
        if (onPointObject != null && onClickObject != null)
        {
            if (interactableController.CheckCondition(onPointObject, onClickObject))
            {
                onPointObject = null;
                onClickObject = null;
            }
        }
    }

    private void onRaycast()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (onPointObject == null)
            {
                onPointObject = hit.transform.GetComponent<InteractableBaseModel>();
            }
            else
            {
                onClickObject = hit.transform.GetComponent<InteractableBaseModel>();
            }
        }
    }
}