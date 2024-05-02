using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class CurrentRoom : MonoBehaviour
{
    [SerializeField] Text nameplayer;
    [SerializeField] Text nameroom;
    [SerializeField] Transform posInit;
    public CharacterSelector _changeSelector;
    [SerializeField]  private ChangeAvatar _changeAvatar;

    private void OnEnable()
    {
        nameplayer.text = "Nick Name: " + PhotonNetwork.NickName;
        nameroom.text = "Nombre de la Sala: " + PhotonNetwork.CurrentRoom.Name;
        _changeSelector = _changeAvatar.GetCharacter();
        GameObject tmp = Instantiate(_changeSelector.gameObject, posInit.position, posInit.rotation, transform);
    }



    public void OnExtiGame()
    {
        Application.Quit();
    }
}
