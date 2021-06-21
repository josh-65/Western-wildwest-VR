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

    void Start() {
        error = true;
    }

    void Update() 
    {
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        networkAddress = ConfigManager.appConfig.GetString("Client - IP");
        Port = ConfigManager.appConfig.GetInt("Client - Port");
        maxConnections = ConfigManager.appConfig.GetInt("Server - Max players");

        if (error) {
            loadIcon.SetActive(false);
        } else {
            loadIcon.SetActive(true);
        }
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        error = true;
    }

    public override void OnClientConnect(NetworkConnection conn) {
        
    }

    public void Load()
    {
        error = false;
    }
}