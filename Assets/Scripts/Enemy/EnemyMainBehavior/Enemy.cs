using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(1, 15)] [SerializeField] private float _movementSpeed;
    [Range(1, 15)] [SerializeField] private int _health;

    public float MovementSpeed => _movementSpeed;
}
