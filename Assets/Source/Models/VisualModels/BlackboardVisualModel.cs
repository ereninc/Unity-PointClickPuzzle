using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlackboardVisualModel : VisualBaseModel
{
    [SerializeField] private Transform blackBoardGFX;
    [SerializeField] private Transform chartParent;

    public override void OnAction()
    {
        blackBoardGFX.SetActiveGameObject(true);
        chartParent.DOScaleY(1, 2f).SetEase(Ease.InOutElastic).OnComplete(() => DOTween.Kill(this));
        ParticleSystem.Play();
    }
}