using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed, _moveY;
    public void Move(int index)
    {
        _rb.AddForce(new Vector2(_speed * index, 0), ForceMode2D.Force);
    }
    public void MoveY(int index)
    {
        _rb.AddForce(new Vector2(0, _moveY * index), ForceMode2D.Impulse);
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.A)) {
            Move(-1);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Move(1);
        }
        if (Input.GetKeyUp(KeyCode.W)) {
            MoveY(1);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            MoveY(-1);
        }
    }
}