using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public Car car;

    public void SaveGame()
    {
        PlayerPrefs.SetInt("EngineInstalled", car.parts[0].isInstalled ? 1 : 0);
        PlayerPrefs.SetFloat("EngineCondition", car.parts[0].condition);

        PlayerPrefs.Save();
        Debug.Log("Game Saved");
    }

    public void LoadGame()
    {
        car.parts[0].isInstalled = PlayerPrefs.GetInt("EngineInstalled") == 1;
        car.parts[0].condition = PlayerPrefs.GetFloat("EngineCondition");

        Debug.Log("Game Loaded");
    }
}
