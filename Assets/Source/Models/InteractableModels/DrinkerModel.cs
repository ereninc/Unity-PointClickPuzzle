using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkerModel : InteractableBaseModel
{
    [SerializeField] private DrinkerVisualModel drinkerMachineVisualModel;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Drinker);
    }

    public override void OnInteract()
    {
        base.OnInteract();
        drinkerMachineVisualModel.OnAction();
    }
}