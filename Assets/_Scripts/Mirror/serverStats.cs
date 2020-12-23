using Mirror;
using UnityEngine;
using UnityEngine.UI;

public class serverStats : MonoBehaviour
{
    public Text ip;
    public Text port;
    public Text players;
    public Text uptime;
    public Text log;

    private float timer;
    private int SS = 0;
    private int MM = 0;
    private int HH = 0;

    void Start()
    {
        InvokeRepeating("Stat", 1f, 1f);
    }

    void Stat()
    {
        SS += 1;

        if (SS == 60)
        {
            SS = 0;
            MM += 1;

            if (MM == 60)
            {
                MM = 0;
                HH += 1;
            }
        }

        ip.text = "IP:\n" + networkManagerAdd.networkAddress;
        port.text = "Port:\n" + networkManagerAdd.Port.ToString();
        players.text = "Players:\n" + networkManagerAdd.numPlayers.ToString() + " / " + networkManagerAdd.maxConnections.ToString();
        uptime.text = "Uptime:\n" + HH + "hours : " + MM + "min : " + SS + "sec";
        log.text = "Server Started - V0.0.1";
    }
}