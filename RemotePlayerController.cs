using UnityEngine;

public class RemotePlayerController : MonoBehaviour
{
    public string targetPlayerId;

    void Update()
    {
        var data = NetworkManagerSimple.Instance.GetPlayer(targetPlayerId);

        if (data != null)
        {
            transform.position = Vector3.Lerp(transform.position, data.position, Time.deltaTime * 10f);
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, data.rotation, Time.deltaTime * 10f);
        }
    }
}
