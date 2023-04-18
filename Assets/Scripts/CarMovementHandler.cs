using UnityEngine;

public class CarMovementHandler : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotationAngleY;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var position = transform.position;
        var rotationAngleY = transform.rotation.y;
        var step = Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;

            if (Input.GetKey(KeyCode.A))
            {
                rotationAngleY -= _rotationAngleY;
                position.x -= step;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rotationAngleY += _rotationAngleY;
                position.x += step;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;

            if (Input.GetKey(KeyCode.A))
            {
                rotationAngleY += _rotationAngleY;
                position.x -= step;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rotationAngleY -= _rotationAngleY;
                position.x += step;
            }
        }

        transform.position = position;
        transform.rotation = Quaternion.Euler(0, rotationAngleY, 0);
    }
}