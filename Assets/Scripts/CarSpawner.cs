using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _carPrefab;

    private void Awake()
    {
        Instantiate(_carPrefab, transform);
    }
}
