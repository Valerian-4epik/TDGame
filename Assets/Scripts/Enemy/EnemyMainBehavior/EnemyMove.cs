using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;

    private Enemy _enemy;
    private float _movementSpeed;
    private int _currentWaypointIndex;

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();
    }

    private void Start()
    {
        _movementSpeed = _enemy.MovementSpeed;
    }

    private void LateUpdate()
    {
        if (_currentWaypointIndex == _waypoints.Length)
        {
            return;
        }

        var targetPosition = _waypoints[_currentWaypointIndex].position;
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition,
            _movementSpeed * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            _currentWaypointIndex++;
        }
    }
}