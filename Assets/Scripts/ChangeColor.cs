using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer _renderer;
    private MaterialPropertyBlock _propBlock;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();
    }

    [System.Obsolete]
    void Update()
    {
        _renderer.material.color = GetRandomColor();
        //_renderer.material.SetColor("Color",GetRandomColor());
    }
    //[System.Obsolete]
    //void Update()
    //{
    //    _renderer.GetPropertyBlock(_propBlock);
    //    _propBlock.SetColor("_Color", GetRandomColor());
    //    _renderer.SetPropertyBlock(_propBlock);
    //}
    [System.Obsolete]
    private Color GetRandomColor()
    {
        return new Color(
            Random.RandomRange(0f, 1f),
            Random.RandomRange(0f, 1f),
            Random.RandomRange(0f, 1f));
    }

 
}
