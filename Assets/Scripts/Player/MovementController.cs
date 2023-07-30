using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;
    private Camera _camera;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _camera = Camera.main;
    }

    private void Update()
    {
        // Перемещаем персонажа в направлении _destination.
        _navMeshAgent.SetDestination(_destination);
        
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out var hit))
        {
            SetDestination(hit.point);
        }
    }

    private void SetDestination(Vector3 target)
    {
        _destination = target;
    }
}