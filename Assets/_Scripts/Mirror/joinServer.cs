using UnityEngine;
using UnityEngine.UI;

namespace Mirror.www.game
{
    public class joinServer : MonoBehaviour
    {
        [SerializeField] private networkManagerCustom networkManager = null;
        //public string ipAddress;
        [SerializeField] private Button joinButton = null;

        private void OnEnable()
        {
            networkManagerCustom.OnClientConnected += HandleClientConnected;
            networkManagerCustom.OnClientDisconnected += HandleClientDisconnected;
        }

        private void OnDisable()
        {
            networkManagerCustom.OnClientConnected -= HandleClientConnected;
            networkManagerCustom.OnClientDisconnected -= HandleClientDisconnected;
        }

        public void Connect()
        {
            //networkManager.networkAddress = ipAddress;
            networkManager.StartClient();

            joinButton.interactable = false;
        }

        private void HandleClientConnected()
        {
            joinButton.interactable = true;
        }

        private void HandleClientDisconnected()
        {
            joinButton.interactable = true;
        }
    }
}