using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : ControllerBaseModel
{
    [SerializeField] private List<InteractableBaseModel> interactables;

    public override void Initialize()
    {
        base.Initialize();
        setInteractables();
    }

    public bool CheckCondition(InteractableBaseModel point, InteractableBaseModel click, LevelModel activeLevel, int stage) 
    {
        if (point.InteractableType == activeLevel.LevelDatas[stage].PointObject && click.InteractableType == activeLevel.LevelDatas[stage].ClickObject)
        {
            point.OnClickEnd();
            click.OnClickEnd();
            return true;
        }
        return false;
    }

    private void setInteractables() 
    {
        for (int i = 0; i < interactables.Count; i++)
        {
            interactables[i].Initialize();
        }
    }
}