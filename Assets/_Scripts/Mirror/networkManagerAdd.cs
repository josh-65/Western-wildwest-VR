using Mirror;
using System;
using Steamworks;
using UnityEngine;
using Unity.RemoteConfig;

public class networkManagerAdd : NetworkManager
{
    public struct userAttributes {}
    public struct appAttributes {}

    public static string networkAddress;
    public static int maxConnections;
    public static int numPlayers;
    public static int Port;

    void Update() 
    {
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        networkAddress = ConfigManager.appConfig.GetString("Client - IP");
        maxConnections = ConfigManager.appConfig.GetInt("Server - Max players");
    }

    /*public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
        CSteamID steamId = SteamMatchmaking.GetLobbyMemberByIndex(SteamLobby.LobbyId, numPlayers - 1);

        var playerInfoDisplay = conn.identity.GetComponent<PlayerInfoDisplay>();
        playerInfoDisplay.SetSteamId(steamId.m_SteamID);
    }*/
}