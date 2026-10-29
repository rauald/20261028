using UnityEngine;
using UnityEngine.InputSystem;

// 플레이어 입력을 읽어서 다른 컴포넌트에 제공한다.
public class PlayerInputReader : MonoBehaviour
{
    [SerializeField] private InputActionReference _moveAction;

    // WASD 입력 값 (x : 좌우, y : 앞뒤)
    public Vector2 MoveInput { get; private set; }

    private void OnEnable()
    {
        _moveAction.action.Enable();
    }

    private void OnDisable()
    {
        _moveAction.action.Disable();
    }

    private void Update()
    {
        MoveInput = _moveAction.action.ReadValue<Vector2>();
    }
}
