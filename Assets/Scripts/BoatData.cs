using UnityEngine;

[CreateAssetMenu(fileName = "BoatData", menuName = "Scriptable Objects/BoatData")]
public class BoatData : ScriptableObject
{
    [SerializeField]
    private float width = 16f;

    [SerializeField]
    private float length = 9f;

    [SerializeField]
    [Range(0, 10)]
    private float maxSpeed = 6f;

    [SerializeField]
    [Range(0.1f, 45f)]
    private float steeringSpeed = 4.5f;

    [SerializeField]
    [Range(.01f, .5f)]
    private float maxForce = .03f;

    [SerializeField]
    [Range(1, 10)]
    private float neighborhoodRadius = 4f;

    [SerializeField]
    [Range(0.1f, 10f)]
    private float separationRadius = 2.4f;

    [SerializeField]
    [Range(0, 3)]
    private float separationAmount = 1.1f;

    [SerializeField]
    [Range(0, 3)]
    private float cohesionAmount = 0.3f;

    [SerializeField]
    [Range(0, 3)]
    private float alignmentAmount = 0.5f;

    public float Width {  get { return width; } }
    public float Length { get { return length; } }
    public float MaxSpeed { get { return maxSpeed; } }
    public float SteeringSpeed { get { return steeringSpeed; } }
    public float MaxForce { get { return maxForce; } }
    public float NeighborhoodRadius { get { return neighborhoodRadius; } }
    public float SeparationRadius { get { return separationRadius; } }
    public float SeparationAmount { get { return separationAmount; } }
    public float CohesionAmount {  get { return cohesionAmount; } }
    public float AlignmentAmount { get {return alignmentAmount; } }
}
