using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Material _objectMaterial;
    [SerializeField] private Color _startColor;
    [SerializeField] private Color _endColor;
    [SerializeField] private float _duration;

    private void Start()
    {
        _objectMaterial.color = _startColor;
        _objectMaterial.DOColor(_endColor, _duration);
    }
}
