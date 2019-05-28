﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ExitGames.Client.Photon;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;
using Photon.Pun;

using Consts;
using Utils;

public class ManagerGame : MonoBehaviour
{
    private Dictionary<int, GameObject> _playerListEntries;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        _playerListEntries = new Dictionary<int, GameObject>();

        foreach (Player p in PhotonNetwork.PlayerList)
        {
            //GameObject entry = Instantiate(PlayerOverviewEntryPrefab);
            //entry.transform.SetParent(gameObject.transform);
            //entry.transform.localScale = Vector3.one;
            //entry.GetComponent<Text>().text = string.Format("{0}\nScore: {1}\nLives: {2}", p.NickName, p.GetScore(), UserGame.PLAYER_MAX_LIVES);

            //playerListEntries.Add(p.ActorNumber, entry);
        }
    }

    private void Start()
    {
        var initialPosition = ManagerPositions.Instance.GetPosition();
        Quaternion rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

        PhotonNetwork.Instantiate("Prefabs/EntityPlayer", initialPosition, rotation, 0);
    }
}
