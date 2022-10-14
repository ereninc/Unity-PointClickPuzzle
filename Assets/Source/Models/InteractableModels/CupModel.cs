using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupModel : InteractableBaseModel
{
    [SerializeField] private CupVisualModel cupVisualModel;
    private int interactIndex;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Cup);
        interactIndex = 0;
    }

    public override void OnInteract()
    {
        setEvent();
        interactIndex++;
        base.OnInteract();
    }

    private void setEvent()
    {
        switch (interactIndex)
        {
            case 0:
                cupVisualModel.OnCupClick(true);
                break;
            case 1:
                cupVisualModel.OnCupClick(false);
                break;
            case 2:
                cupVisualModel.OnEnterTrashBin();
                break;
            default:
                break;
        }
    }
}