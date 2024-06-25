using Dreamteck.Forever;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Runner _Player;
    public float _moveSpeed = 5f;
    public float _clampWidth = 4f;

    void Start()
    {
        _Player = GetComponent<Runner>();
    }

    private void Update()
    {
        _Player.motion.offset += new Vector2(Input.GetAxis("Horizontal"), 0f) * _moveSpeed * Time.deltaTime;
        _Player.motion.offset = new Vector2(Mathf.Clamp(_Player.motion.offset.x, -_clampWidth, _clampWidth), _Player.motion.offset.y);


        //if (transform.position.x < -8) transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        //if (transform.position.x > 5) transform.position = new Vector3(5, transform.position.y, transform.position.z);

    }
    public void OnTriggerEnter(Collider other)
    {
        Runner runner = _Player;
        runner.follow = false;
    }
}