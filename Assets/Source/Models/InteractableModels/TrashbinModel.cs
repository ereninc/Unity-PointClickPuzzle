using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashbinModel : InteractableBaseModel
{
    [SerializeField] private EventModel trashBinInteractEventModel;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.TrashBin);
    }

    public override void OnInteract()
    {
        base.OnInteract();
        trashBinInteractEventModel?.Invoke();
    }
}