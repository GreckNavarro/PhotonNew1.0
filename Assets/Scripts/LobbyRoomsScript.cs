using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
public class LobbyRoomsScript : MonoBehaviour
{
    [SerializeField] Text nameplayer;
    private void OnEnable()
    {
        nameplayer.text = "Nick Name: " + PhotonNetwork.NickName;
    }
    public void EnterCreateSala()
    {
        UIManager.instance.ActiveComponent(ComponentUI.CreateRoom);
    }
}
