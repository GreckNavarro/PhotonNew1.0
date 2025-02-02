using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListing : MonoBehaviour
{
    [SerializeField] Text _text;

    public void SetTex(Text newText)
    {
        _text.text = newText.text;
    }

    public Player Player {get; private set; }

    public void SetPlayerInfo(Player player)
    {
        Player = player;
        _text.text = player.NickName;
      
    }
}
