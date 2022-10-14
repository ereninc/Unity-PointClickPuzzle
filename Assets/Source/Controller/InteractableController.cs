using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : ControllerBaseModel
{
    [SerializeField] private List<InteractableBaseModel> interactables;
    private LevelModel activeLevel;
    private int stage;

    public override void Initialize()
    {
        base.Initialize();
        activeLevel = LevelController.Instance.ActiveLevel;
        stage = 0;
        setInteractables();
    }

    public bool CheckCondition(InteractableBaseModel point, InteractableBaseModel click) 
    {
        if (point.InteractableType == activeLevel.LevelDatas[stage].PointObject && click.InteractableType == activeLevel.LevelDatas[stage].ClickObject)
        {
            point.OnInteract();
            click.OnInteract();
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
            //SET END STATE
            GameController.ChangeState(GameStates.Win);
            CameraController.Controller.ChangeCamera(1);
            FinishController.Controller.OnLevelFinished();
            Debug.Log("LEVEL FINISHED");
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