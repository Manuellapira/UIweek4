using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChestAnimation : MonoBehaviour
{
    public GameObject chestLid;
    // Start is called before the first frame update
    void Start()
    {
        Sequence chestSequence = DOTween.Sequence();
        chestSequence.Append(transform.DOMoveY(5f, 0.25f));
        chestSequence.Join(transform.DORotate(Vector3.up * 180, 0.25f));

        chestSequence.Append(transform.DOMoveY(0, 0.25f)).SetEase(Ease.InCirc);
        chestSequence.Join(transform.DORotate(Vector3.up * 360, 0.45f));

        chestSequence.Append(transform.DOShakeRotation(0.5f, 20f, 25, 10f));
        chestSequence.Join(transform.DOScaleY(transform.localScale.y * 1.25f, 0.55f));

        chestSequence.Append(chestLid.transform.DORotate(Vector3.left * 125, 0.25f));
        chestSequence.Join(chestLid.transform.DOScaleY(transform.localScale.y / 1.25f, 0.55f));
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}