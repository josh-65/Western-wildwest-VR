using Mirror;
using System;
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
    private bool error = false;

    void Update() 
    {
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        networkAddress = ConfigManager.appConfig.GetString("Client - IP");
        Port = ConfigManager.appConfig.GetInt("Client - Port");
        maxConnections = ConfigManager.appConfig.GetInt("Server - Max players");
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        error = true;
    }

    public void Load()
    {
        loadIcon.SetActive(true);

        if (error)
        {
            loadIcon.SetActive(false);
            error = false;
        }
    }

    public override void OnClientConnect(NetworkConnection conn)
    {

    }
}