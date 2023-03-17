using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 4;
    [SerializeField] private GameObject _bullet;
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
        Vector3 move = new Vector3(_move.x, 0, _move.y);
        transform.Translate(move * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 5, ForceMode.Impulse);
            Destroy(bullet, 5);
        }
    }
}
