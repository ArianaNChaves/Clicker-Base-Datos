using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private float clickRate;
    [SerializeField] private LayerMask clickeableLayer;
    private float _timer;
    private Camera _camera;
    private void Start()
    {
        _timer = clickRate;
        _camera = Camera.main;
    }
    private void Update()
    {
        PlayerClick();
    }

    private void PlayerClick()
    {
        _timer += Time.deltaTime;
        if (_timer >= clickRate && Input.GetMouseButtonDown(0))
        {
            _timer = 0;
            RaycastClick();
        }
    }

    private void RaycastClick()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit, Mathf.Infinity, clickeableLayer))
        {
            // Debug.Log("Click a " + LayerMask.LayerToName(hit.collider.gameObject.layer));
            if (Utilities.CompareLayerAndMask(hit.transform.gameObject.layer, clickeableLayer))
            {
                IClickeable clickeable = hit.transform.gameObject.GetComponent<IClickeable>();
                clickeable.Clicked();
            }
        } 
    }
    
}
