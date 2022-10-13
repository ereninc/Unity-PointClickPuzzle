using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePoolModel : PoolModel
{
    public void SetParticle(Vector3 pos)
    {
        ParticleBaseModel particle = GetDeactiveItem<ParticleBaseModel>();
        if(particle != null)
        {
            particle.transform.position = pos;
            particle.SetActiveGameObject(true);
            particle.Play();
        }

    }

    public void SetParticle(Vector3 pos, Quaternion rotation)
    {
        ParticleBaseModel particle = GetDeactiveItem<ParticleBaseModel>();
        if (particle != null)
        {
            particle.transform.position = pos;
            particle.transform.rotation = rotation;
            particle.SetActiveGameObject(true);
            particle.Play();
        }
    }

    [EditorButton]
    public void GetDeactiveItems()
    {
        InitializeOnEditor();
    }
}