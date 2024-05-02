using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character { Character1, Character2, Character3}


public class CharacterSelector : MonoBehaviour
{
    public Character type;
    public string NamePrefab;
    private void Start()
    {
        NamePrefab = this.name;
    }


}
