using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenModel : InteractableBaseModel
{
    [SerializeField] private EventModel onDrawEvent;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Pen);
    }

    public override void OnInteract()
    {
        base.OnInteract();
        onDrawEvent?.Invoke();
    }
}