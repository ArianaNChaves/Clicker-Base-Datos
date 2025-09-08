using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] private Texture2D attackTexture;
    [SerializeField] private Texture2D defaultTexture;
    [SerializeField] private Texture2D pickTexture;
    [SerializeField] private LayerMask interactableLayer;
    private Camera _camera;
    private Texture2D _cursorDefaultTexture;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void LateUpdate()
    {
        ChangeCursor();
    }
    
    private void ChangeCursor()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit, Mathf.Infinity, interactableLayer))
        {
            switch (LayerMask.LayerToName(hit.transform.gameObject.layer))
            {
                case "Enemy":
                {
                    UnityEngine.Cursor.SetCursor(attackTexture, hit.point, CursorMode.Auto);
                    break;
                }
                case "Pickeables":
                {
                    UnityEngine.Cursor.SetCursor(pickTexture, hit.point, CursorMode.Auto);
                    break;
                }
            }
        }
        else
        {
            UnityEngine.Cursor.SetCursor(defaultTexture, hit.point, CursorMode.Auto);
        }
        
    }
}
