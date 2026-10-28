using UnityEngine;

// 입력 값을 받아 플레이어를 XZ 평면 위에서 이동시킨다.
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
        Vector2 moveInput = _inputReader.MoveInput;

        // 입력의 y 값을 월드의 z 방향(앞뒤)으로 사용한다.
        Vector3 moveDirection = new Vector3(moveInput.x, 0f, moveInput.y);
        transform.Translate(moveDirection * _moveSpeed * Time.deltaTime, Space.World);
    }
}
