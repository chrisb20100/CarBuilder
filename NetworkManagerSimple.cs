using System.Collections.Generic;
using UnityEngine;

public class NetworkManagerSimple : MonoBehaviour
{
    public static NetworkManagerSimple Instance;

    public Dictionary<string, NetworkPlayerData> players = new Dictionary<string, NetworkPlayerData>();
    public NetworkCarData carData = new NetworkCarData();

    void Awake()
    {
        Instance = this;
    }

    public void UpdatePlayer(string id, Vector3 pos, Vector3 rot)
    {
        if (!players.ContainsKey(id))
        {
            players[id] = new NetworkPlayerData(id);
        }

        players[id].position = pos;
        players[id].rotation = rot;
    }

    public NetworkPlayerData GetPlayer(string id)
    {
        return players.ContainsKey(id) ? players[id] : null;
    }
}
