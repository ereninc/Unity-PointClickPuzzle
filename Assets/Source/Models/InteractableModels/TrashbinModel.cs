using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashbinModel : InteractableBaseModel
{
    [SerializeField] private TrashbinVisualModel trashbinVisualModel;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.TrashBin);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {
        trashbinVisualModel.OnTrash();
        base.OnClickEnd();
    }
}