using DG.Tweening;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _endRotation;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(_endRotation, _duration)
            .SetEase(Ease.Linear);
    }
}
