using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesController : ControllerBaseModel
{
    public static ParticlesController Instance;
    [SerializeField] ParticlePoolModel[] particlePools;

    public override void Initialize()
    {
        base.Initialize();

        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    public static void SetParticle(int index, Vector3 pos)
    {
        Instance.particlePools[index].SetParticle(pos);
    }

    public static void SetParticle(int index, Vector3 pos, Quaternion rotation)
    {
        Instance.particlePools[index].SetParticle(pos, rotation);
    }
}