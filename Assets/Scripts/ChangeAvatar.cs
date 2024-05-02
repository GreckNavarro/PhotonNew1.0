using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAvatar : MonoBehaviour
{
    [SerializeField] private List<CharacterSelector> ListComponents = new List<CharacterSelector>();
    [SerializeField] private CharacterSelector InitCharact;
    public static CharacterSelector currentCharacter;
    public CharacterSelector CurrentCharacater { get => InitCharact;  }
    public int idC;

    public CharacterSelector GetCharacter()
    {
        currentCharacter = InitCharact;
        return currentCharacter;
    }
    static CharacterSelector _instance;
    static public bool isActive
    {
        get
        {
            return _instance != null;
        }
    }
    static public CharacterSelector instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Object.FindObjectOfType(typeof(CharacterSelector)) as CharacterSelector;

                if (_instance == null)
                {
                    GameObject go = new GameObject("CharacterSelector");
                    DontDestroyOnLoad(go);
                    _instance = go.AddComponent<CharacterSelector>();
                }
            }
            return _instance;
        }
    }

    void Start()
    {
        ActiveComponent(InitCharact.type);
    }
    public void ActiveComponent(Character component)
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


    public void ChangeCharacter()
    {
        idC = (idC + 1) % 3;
        if (idC > 2)
        {
            return;
        }
        else
        {
            InitCharact = ListComponents[idC];
            ActiveComponent(InitCharact.type);
        }
        

    }
    private void OnDisable()
    {
        currentCharacter = InitCharact;
    }

}
