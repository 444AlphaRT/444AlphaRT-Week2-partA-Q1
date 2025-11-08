using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public Vector2 direction = Vector2.right; // axis of movement
    public float amplitude = 2f;              // max distance from center
    public float period = 2f;                 // time for a full cycle
    [Range(0f, 360f)] public float phaseDeg = 0f;

    private Vector3 center;

    void Start()
    {
        center = transform.position;
        direction = direction.normalized;
    }

    void Update()
    {
        if (period <= 0f) return;

        float theta = 2f * Mathf.PI * Time.time / period + phaseDeg * Mathf.Deg2Rad;
        float s = Mathf.Sin(theta);

        Vector2 offset = direction * (s * amplitude);
        transform.position = center + (Vector3)offset;
    }
}
