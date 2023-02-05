using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class SnakeHead : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public event UnityAction BlockCollided;
    public event UnityAction<int> BonusPickUp;

    private void Start() 
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();    
    }

    public void Move(Vector3 newPosition)
    {
        _rigidbody2D.MovePosition(newPosition);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Block block))
        {
            block.Fill();
            BlockCollided?.Invoke();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Bonus bonus))
        {
            BonusPickUp?.Invoke(bonus.BonusSize);
            Destroy(bonus.gameObject);
        }
    }
}