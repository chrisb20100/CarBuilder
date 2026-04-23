using System.Collections.Generic;
using UnityEngine;

public class WiringSystem : MonoBehaviour
{
    public List<Wire> wires = new List<Wire>();

    void Awake()
    {
        wires.Add(new Wire("BatteryToStarter"));
        wires.Add(new Wire("StarterToEngine"));
        wires.Add(new Wire("BatteryToLights"));
    }

    public void ConnectWire(string name)
    {
        Wire wire = wires.Find(w => w.wireName == name);

        if (wire != null)
        {
            wire.isConnected = true;
            Debug.Log(name + " connected.");
        }
    }

    public void DisconnectWire(string name)
    {
        Wire wire = wires.Find(w => w.wireName == name);

        if (wire != null)
        {
            wire.isConnected = false;
            wire.hasPower = false;
            Debug.Log(name + " disconnected.");
        }
    }

    public bool IsWireConnected(string name)
    {
        Wire wire = wires.Find(w => w.wireName == name);
        return wire != null && wire.isConnected;
    }

    public void UpdatePower(bool batteryHasPower)
    {
        foreach (Wire wire in wires)
        {
            wire.hasPower = batteryHasPower && wire.isConnected;
        }
    }
}
