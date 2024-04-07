using DG.Tweening;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 _endScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_endScale, _duration);
    }
}
