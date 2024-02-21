using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private Canvas popUpCanvas;
    [SerializeField] private Canvas HUDCanvas;

    public List<UIBase> UI_List = new List<UIBase>();

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Show(string UIName)
    {
        UIBase ui = UI_List.Find(ui => ui.name == UIName);

        if(ui == null)
        {
            return;
        }

        switch (ui.uIType)
        {
            case UIType.HUD:
                ui.Show(HUDCanvas);
                break;
            case UIType.POPUP:
                ui.Show(popUpCanvas);
                break;
        }
    }
}
