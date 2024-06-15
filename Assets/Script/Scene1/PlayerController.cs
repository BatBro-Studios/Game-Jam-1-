using TMPro;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed, _moveY;
    [SerializeField] private int _hp = 5;
    [SerializeField] private TMP_Text _Text;
    private void OnCollisionEnter(Collision collision)
    {
        _hp--;
        if (collision.gameObject.tag == "enemy")
        {
            print("enemy");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        print("11");
    }
    public void Move(int index)
    {
        _rb.AddForce(new Vector2(_speed * index, 0), ForceMode2D.Force);
    }
    public void MoveY(int index)
    {
        _rb.AddForce(new Vector2(0, _moveY * index), ForceMode2D.Force);
    }
    private void Update()
    {
        _Text.text = $"hp={_hp}";
        if(Input.GetKey(KeyCode.A)) {
            Move(-1);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Move(1);
        }
        if (Input.GetKey(KeyCode.W)) {
            MoveY(1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveY(-1);
        }
    }
}