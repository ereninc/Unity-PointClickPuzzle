using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : ControllerBaseModel
{
    [SerializeField] private List<InteractableBaseModel> interactables;
    [SerializeField] private EventModel onLevelFinished;
    private LevelModel activeLevel;
    private int stage;

    public override void Initialize()
    {
        base.Initialize();
        activeLevel = LevelController.Instance.ActiveLevel;
        stage = 0;
        setInteractables();
    }

    public bool CheckCondition(InteractableBaseModel pointObject, InteractableBaseModel clickObject) 
    {
        if (pointObject.InteractableType == activeLevel.LevelDatas[stage].PointObjectType && clickObject.InteractableType == activeLevel.LevelDatas[stage].ClickObjectType)
        {
            pointObject.OnInteract();
            clickObject.OnInteract();
            checkStageCount();
            return true;
        }
        return false;
    }

    private void checkStageCount()
    {
        stage++;
        if (stage == activeLevel.StageCount)
        {
            onLevelFinished?.Invoke();
        }
    }

    private void setInteractables() 
    {
        for (int i = 0; i < interactables.Count; i++)
        {
            interactables[i].Initialize();
        }
    }
}