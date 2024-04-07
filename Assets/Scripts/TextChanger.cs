using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _endText;
    [SerializeField] private string _addText;
    [SerializeField] private float _duration;
    [SerializeField] private float _textAddDuration;

    TweenerCore<string,string, StringOptions> _tweener;
    bool _isTextAdded = false;
    bool _isTextScrabled = false;

    private void Start()
    {
        _tweener = _text.DOText(_endText, _duration);
    }

    private void Update()
    {
        if (_tweener.active == false && _isTextAdded == false)
        {
            _isTextAdded = true;
            _tweener = _text.DOText(_addText, _textAddDuration).SetRelative().SetEase(Ease.Linear);
        }

        if (_tweener.active == false && _isTextScrabled == false)
        {
            _isTextScrabled = true;
            _tweener = _text.DOText(_text.text, _duration, true, ScrambleMode.All);
        }
    }
}
