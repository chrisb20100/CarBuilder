using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 0f;
    public float acceleration = 5f;
    public float maxSpeed = 50f;

    public FuelSystem fuelSystem;
    public EngineSystem engineSystem;

    void Update()
    {
        if (engineSystem.isRunning && fuelSystem.HasFuel())
        {
            if (Input.GetKey(KeyCode.W))
            {
                speed += acceleration * Time.deltaTime;
                speed = Mathf.Clamp(speed, 0, maxSpeed);

                fuelSystem.ConsumeFuel();
            }
        }
        else
        {
            speed = 0;
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
