using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBaseModel : ObjectModel, IInteractable
{
    public InteractableTypes InteractableType;

    public virtual void OnInteract() 
    {
        Interact();
    }

    public void Interact() { }

    public void OnSpawn(InteractableTypes type)
    {
        InteractableType = type;
    }
}