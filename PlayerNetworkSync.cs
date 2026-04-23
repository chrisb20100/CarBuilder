using UnityEngine;

public class PlayerNetworkSync : MonoBehaviour
{
    public string playerId = "Player1";

    void Update()
    {
        // Send local data
        NetworkManagerSimple.Instance.UpdatePlayer(
            playerId,
            transform.position,
            transform.eulerAngles
        );
    }
}
