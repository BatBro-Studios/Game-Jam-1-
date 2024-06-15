using UnityEngine;
public class enemy : MonoBehaviour
{
    [SerializeField] private Transform _playerransform, _enemy;
    private void Update()
    {
        _enemy.position += Vector3.left  * Time.deltaTime * 3f;
    }
}