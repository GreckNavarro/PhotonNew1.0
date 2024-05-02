using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
public class CreatePLayerMenu : MonoBehaviour
{
    [SerializeField] private Text _InputPlayerName;

    public void SetNickName()
    {
        PhotonNetwork.NickName = _InputPlayerName.text;
        UIManager.instance.ActiveComponent(ComponentUI.ListRoom);
    }
}
