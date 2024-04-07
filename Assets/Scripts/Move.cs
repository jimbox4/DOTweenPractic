using DG.Tweening;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_endPosition, _duration);
    }
}
