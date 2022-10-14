using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseModel : InteractableBaseModel
{
    [SerializeField] private EventModel vaseInteractEventModel;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Vase);
    }

    public override void OnInteract()
    {
        vaseInteractEventModel?.Invoke();
        base.OnInteract();
    }
}