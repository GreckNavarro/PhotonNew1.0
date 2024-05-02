using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Singletons/MasterManager")]
public class MasterManager : SingletonSO<MasterManager>
{
    [SerializeField] GameSettings _gameSettings;
    public static GameSettings GameSettings { get { return Instance._gameSettings; } }

}
