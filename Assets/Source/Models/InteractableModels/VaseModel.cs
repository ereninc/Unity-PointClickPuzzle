using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseModel : InteractableBaseModel
{
    [SerializeField] private VaseVisualModel vaseVisualModel;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Vase);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {
        vaseVisualModel.OnWatered();
        base.OnClickEnd();
    }
}