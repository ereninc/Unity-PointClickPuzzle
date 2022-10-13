using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : ControllerBaseModel
{
    [SerializeField] private PointerController pointerController;
    [SerializeField] private InteractableController interactableController;
    public InteractableBaseModel OnInteractObject, OnDropInteractObject;
    public LevelModel ActiveLevel;
    public int Stage;
    public InteractableTypes First, Second;
    private RaycastHit hit;
    private Ray ray;

    public override void Initialize()
    {
        base.Initialize();
        Stage = 0;
        ActiveLevel = LevelController.Instance.ActiveLevel;
        First = ActiveLevel.LevelDatas[Stage].PointObject;
        Second = ActiveLevel.LevelDatas[Stage].ClickObject;
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
        if (OnInteractObject != null && OnDropInteractObject != null)
        {
            if (interactableController.CheckCondition(OnInteractObject, OnDropInteractObject, ActiveLevel, Stage))
            {
                Stage++;
            }
        }
        OnInteractObject = null;
        OnDropInteractObject = null;
    }
}