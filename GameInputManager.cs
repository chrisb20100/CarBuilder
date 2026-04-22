using UnityEngine;

public class GameInputManager : MonoBehaviour
{
    public static GameInputManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public bool InteractPressed()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    public bool StartCarPressed()
    {
        return Input.GetKeyDown(KeyCode.R);
    }
}
