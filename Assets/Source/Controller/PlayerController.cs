using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : ControllerBaseModel
{
    [SerializeField] private PointerController pointerController;
    [SerializeField] private InteractableController interactableController;
    private InteractableBaseModel onInteractObject, onDropInteractObject;
    private LevelModel activeLevel;
    private int stage;
    private RaycastHit hit;
    private Ray ray;

    public override void Initialize()
    {
        base.Initialize();
        stage = 0;
        activeLevel = LevelController.Instance.ActiveLevel;
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
        onDropInteractObject = null;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (onInteractObject = hit.transform.GetComponent<InteractableBaseModel>())
            {
                onInteractObject.OnInteract();
            }
        }
    }

    public void OnPointer()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (onInteractObject == null)
            {
                if (onInteractObject = hit.transform.GetComponent<InteractableBaseModel>())
                {
                    onInteractObject.OnInteract();
                }
            }
            else
            {
                if (onDropInteractObject = hit.transform.GetComponent<InteractableBaseModel>())
                {
                    if (onInteractObject != onDropInteractObject)
                    {
                        onDropInteractObject.OnInteract();
                    }
                }
            }
        }
    }

    public void OnPointerUp()
    {
        if (onInteractObject != null && onDropInteractObject != null)
        {
            if (interactableController.CheckCondition(onInteractObject, onDropInteractObject, activeLevel, stage))
            {
                stage++;
                onInteractObject = null;
                onDropInteractObject = null;
            }
        }
    }
}