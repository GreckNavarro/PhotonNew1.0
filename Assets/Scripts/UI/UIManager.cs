using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{ 
    [SerializeField] private List<UIComponent> ListComponents = new List<UIComponent>();
    [SerializeField] private UIComponent InitComp;

    static UIManager _instance;
    static public bool isActive
    {
        get
        {
            return _instance != null;
        }
    }
    static public UIManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Object.FindObjectOfType(typeof(UIManager)) as UIManager;

                if (_instance == null)
                {
                    GameObject go = new GameObject("UIManager");
                    DontDestroyOnLoad(go);
                    _instance = go.AddComponent<UIManager>();
                }
            }
            return _instance;
        }
    }

    void Start()
    {


        ActiveComponent(InitComp.type);
    }
    public void ActiveComponent(ComponentUI component)
    {
        foreach (var item in ListComponents)
        {
            if (item.type == component)
            {
                item.gameObject.SetActive(true);

            }
            else
            {

                item.gameObject.SetActive(false);
            }
        }
    }
 
}
