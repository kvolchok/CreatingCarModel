using UnityEngine;

public class CarTrackerCamera : MonoBehaviour
{
    [SerializeField]
    private Vector3 _offset;
    
    private CarMovementHandler _carMovementHandler;

    private void Start()
    {
        _carMovementHandler = FindObjectOfType<CarMovementHandler>();
    }

    private void LateUpdate()
    {
        transform.position = _carMovementHandler.transform.position + _offset;
    }
}
