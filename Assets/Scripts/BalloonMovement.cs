using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public enum MovementPattern
    {
        Straight,
        Wavy,
        ZigZag
    }

    public float speed = 1.0f;
    public MovementPattern pattern;

    // Adjustable parameters
    public float waveFrequency = 3.0f;   
    public float waveAmplitude = 0.5f;   
    public float zigZagAmplitude = 1.5f; 
    public float zigZagFrequency = 1.5f; 

    private float initialX;              

    void Start()
    {
        
        pattern = (MovementPattern)Random.Range(0, System.Enum.GetValues(typeof(MovementPattern)).Length);
        initialX = transform.position.x;  
    }

    void Update()
    {
        switch (pattern)
        {
            case MovementPattern.Straight:
                MoveStraight();
                break;
            case MovementPattern.Wavy:
                MoveWavy();
                break;
            case MovementPattern.ZigZag:
                MoveZigZag();
                break;
        }

        
        if (transform.position.y > 10.0f || transform.position.x < -10.0f || transform.position.x > 10.0f)
        {
            gameObject.SetActive(false);
        }
    }

    // Movement in a straight line upwards
    void MoveStraight()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    // Movement in a wavy pattern
    void MoveWavy()
    {
        float x = initialX + Mathf.Sin(Time.time * waveFrequency) * waveAmplitude;
        transform.position = new Vector3(x, transform.position.y + speed * Time.deltaTime, 0);
    }

    // Movement in a zig-zag pattern
    void MoveZigZag()
    {
        float x = initialX + Mathf.PingPong(Time.time * zigZagFrequency, zigZagAmplitude) - (zigZagAmplitude / 2);
        transform.position = new Vector3(x, transform.position.y + speed * Time.deltaTime, 0);
    }
}
