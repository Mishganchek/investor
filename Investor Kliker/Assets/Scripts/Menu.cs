using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Menu : MonoBehaviour
{
    [SerializeField] private RectTransform _stopPosition;
    [SerializeField] private RectTransform _startPosition;
    public void Open()
    {
        transform.DOMoveY(_stopPosition.position.y , 3f);
    }

    public void Close()
    {
        transform.DOMoveY(_startPosition.position.y, 3f);
    }


}
