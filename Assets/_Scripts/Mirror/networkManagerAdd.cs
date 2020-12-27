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
    public static int Port;
    public static int maxConnections;
    public static int numPlayers;

    public GameObject loadIcon;
    public bool error = false;

    void Update() 
    {
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        networkAddress = ConfigManager.appConfig.GetString("Client - IP");
        maxConnections = ConfigManager.appConfig.GetInt("Server - Max players");
    }

    public void Load()
    {
        loadIcon.SetActive(true);

        if (error)
        {
            loadIcon.SetActive(false);
        }
    }
}