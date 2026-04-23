using System;
using UnityEngine;

[Serializable]
public class NetworkPlayerData
{
    public string playerId;
    public Vector3 position;
    public Vector3 rotation;

    public NetworkPlayerData(string id)
    {
        playerId = id;
        position = Vector3.zero;
        rotation = Vector3.zero;
    }
}
