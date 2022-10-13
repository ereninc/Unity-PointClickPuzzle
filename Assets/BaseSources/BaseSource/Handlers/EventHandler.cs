using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : HandlerBaseModel
{
    public EventModel[] Events;

    public void Trigger(int eventIndex)
    {
        Events[eventIndex].Invoke();
    }
}
