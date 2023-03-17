using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 4;
    private Vector2 _move;

    // Start is called before the first frame update
    void Start()
    {
        print("Всем привет");
    }

    // Update is called once per frame
    void Update()
    {
        _move.x = Input.GetAxisRaw("Horizontal");
        _move.y = Input.GetAxisRaw("Vertical");
        _move.Normalize();
        transform.Translate(_move * _speed * Time.deltaTime);
    }
}
