using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIType
{
    HUD,
    POPUP
}

public class UIBase : MonoBehaviour
{
    public UIType uIType;

    public void Show(Canvas canvas)
    {
        Instantiate(gameObject, canvas.transform);
    }

    public void CloseUI()
    {
        Destroy(gameObject);
    }
}
