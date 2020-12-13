using UnityEngine;
using UnityEngine.UI;

namespace Mirror.www.game
{
    public class playerName : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private Button continueButton = null;

        public static string DisplayName { get; private set; }

        private const string PlayerPrefsNameKey = "PlayerName";

        private void Start() => SetUpInputField();

        private void SetUpInputField()
        {
            if (!PlayerPrefs.HasKey(PlayerPrefsNameKey)) { return; }

            string defaultName = PlayerPrefs.GetString(PlayerPrefsNameKey);

            SetPlayerName(defaultName);
        }

        public void SetPlayerName(string name)
        {
            continueButton.interactable = !string.IsNullOrEmpty(name);
        }

        public void SavePlayerName()
        {
            DisplayName = "PlayerName";

            PlayerPrefs.SetString(PlayerPrefsNameKey, DisplayName);
        }
    }
}
