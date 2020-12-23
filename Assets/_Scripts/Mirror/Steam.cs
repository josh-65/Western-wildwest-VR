using Mirror;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class Steam : MonoBehaviour
{
    /*[SyncVar(hook = nameof(HandleSteamIdUpdated))]
    private ulong steamId;

    [SerializeField] private RawImage pic = null;
    [SerializeField] private Text name = null;

    protected Callback<AvatarImageLoaded_t> avatarImageLoaded;

    void Start()
    {
        steamId = new CSteamID(callback.m_ulSteamIDLobby, "HostAddress", SteamUser.GetSteamID().ToString());
        LobbyId = new CSteamID(callback.m_ulSteamIDLobby);
    }

    public void OnStartClient()
    {
        avatarImageLoaded = Callback<AvatarImageLoaded_t>.Create(OnAvatarImageLoaded);
    }

    public void setSteamId(ulong steamId)
    {
        this.steamId = steamId;
    }


    private void HandleSteamIdUpdated(ulong oldSteamId, ulong newSteamId)
    {
        var cSteamId = new CSteamID(newSteamId);
        name.text = SteamFriends.GetFriendPersonaName(cSteamId);

        int imageId = SteamFriends.GetLargeFriendAvatar(cSteamId);
        if (imageId == -1) {
            return;
        }

        pic.texture = GetSteamImageAsTexture(imageId);
    }

    private void OnAvatarImageLoaded(AvatarImageLoaded_t callback)
    {
        if(callback.m_steamID.m_SteamID != steamId)
        {
            return;
        }

        pic.texture = GetSteamImageAsTexture(callback.m_iImage);
    }

    private Texture2D GetSteamImageAsTexture(int iImage)
    {
        Texture2D texture = null;
        bool isVaild = SteamUtils.GetImageSize(iImage, out uint width, out uint height);

        if(isVaild) 
        {
            byte[] image = new byte[width * height * 4];
            isVaild = SteamUtils.GetImageRGBA(iImage, image, (int)(width * height * 4));

            if(isVaild)
            {
                texture = new Texture2D((int)width, (int)height, textureFormat.RGBA32, false, true);
                texture.LoadRawTextureData(image);
                texture.Apply();
            }
        }
    }*/
}