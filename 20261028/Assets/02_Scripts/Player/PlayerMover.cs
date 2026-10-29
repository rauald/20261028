using UnityEngine;

// 입력 값에 따라 플레이어를 XZ 평면에서 이동시킨다.
[RequireComponent(typeof(PlayerInputReader))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private PlayerInputReader _inputReader;

    private void Awake()
    {
        _inputReader = GetComponent<PlayerInputReader>();
    }

    private void Update()
    {
        Vector2 input = _inputReader.MoveInput;
        Vector3 moveDirection = new Vector3(input.x, 0f, input.y);

        transform.Translate(moveDirection * _moveSpeed * Time.deltaTime, Space.World);
    }
}
