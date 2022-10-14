using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlackboardVisualModel : ObjectModel
{
    [SerializeField] private Transform blackBoardGFX;
    [SerializeField] private Transform chartParent;
    [SerializeField] private ParticleSystem dustParticle;

    public void OnBlackboardClick()
    {
        blackBoardGFX.SetActiveGameObject(true);
        chartParent.DOScaleY(1, 2f).SetEase(Ease.InOutElastic).OnComplete(() => DOTween.Kill(this));
        dustParticle.Play();
    }
}