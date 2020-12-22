using Mirror;
using System;
using UnityEngine;
using Unity.RemoteConfig;

public class networkManagerRemote : NetworkManager
{
    public struct userAttributes {}
    public struct appAttributes {}

    void Update() 
    {
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        networkAddress = ConfigManager.appConfig.GetString("Client - IP");
        maxConnections = ConfigManager.appConfig.GetInt("Server - Max players");
    }
}