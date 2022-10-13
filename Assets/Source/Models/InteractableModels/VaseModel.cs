using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseModel : InteractableBaseModel
{
    public override void Initialize()
    {
        base.Initialize();
        onSpawn();
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    private void onSpawn()
    {
        InteractableType = InteractableTypes.Vase;
    }
}