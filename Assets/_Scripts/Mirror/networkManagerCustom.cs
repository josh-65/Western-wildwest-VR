using Mirror.www.game;
using Mirror;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.RemoteConfig;

namespace Mirror.www.game
{
    public class networkManagerCustom : NetworkManager
    {
        public struct userAttributes {}
        public struct appAttributes {}

        [SerializeField] private networkManagerCustom networkManager = null;
        [Scene] [SerializeField] private string menuScene = string.Empty;
        [SerializeField] private GameObject playerSpawn = null;

        public static event Action OnClientConnected;
        public static event Action OnClientDisconnected;
        public static event Action<NetworkConnection> OnServerReadied;
        public static event Action OnServerStopped;

        /*public override void OnStartServer() => spawnPrefabs = Resources.LoadAll<GameObject>("_Prefabs").ToList();

        public override void OnStartClient()
        {
            var spawnablePrefabs = Resources.LoadAll<GameObject>("_Prefabs");

            foreach (var prefab in spawnablePrefabs) 
            {
                ClientScene.RegisterPrefab(spawnablePrefabs);
            }
        }*/

        void Update() 
        {
            ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
            networkAddress = ConfigManager.appConfig.GetString("Client - IP");
            maxConnections = ConfigManager.appConfig.GetInt("Server - Max players");
        }

        public override void OnClientConnect(NetworkConnection conn)
        {
            base.OnClientConnect(conn);

            OnClientConnected?.Invoke();
        }

        public override void OnClientDisconnect(NetworkConnection conn)
        {
            base.OnClientDisconnect(conn);

            OnClientDisconnected?.Invoke();
        }

        public override void OnServerConnect(NetworkConnection conn)
        {
            if (numPlayers >= maxConnections)
            {
                conn.Disconnect();
                return;
            }
        }

        public override void OnServerDisconnect(NetworkConnection conn)
        {
            base.OnServerDisconnect(conn);
        }

        public override void OnStopServer()
        {
            OnServerStopped?.Invoke();
        }

        public override void ServerChangeScene(string newSceneName)
        {
            // From menu to game
            base.ServerChangeScene(newSceneName);
        }

        public override void OnServerSceneChanged(string sceneName)
        {
            if (sceneName.StartsWith("Scene_Map"))
            {
                GameObject playerSpawnSystemInstance = Instantiate(playerSpawn);
                NetworkServer.Spawn(playerSpawnSystemInstance);
            }
        }

        public override void OnServerReady(NetworkConnection conn)
        {
            base.OnServerReady(conn);

            OnServerReadied?.Invoke(conn);
        }
    }
}