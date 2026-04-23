using UnityEngine;

public class NetworkTransformSync : MonoBehaviour
{
    public string objectId;

    public Vector3 networkPosition;
    public Vector3 networkRotation;

    public float lerpSpeed = 10f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, networkPosition, Time.deltaTime * lerpSpeed);
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, networkRotation, Time.deltaTime * lerpSpeed);
    }

    public void ApplyNetworkData(Vector3 pos, Vector3 rot)
    {
        networkPosition = pos;
        networkRotation = rot;
    }
}
