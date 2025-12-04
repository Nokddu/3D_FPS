using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControll : PlayerController.IPlayerActions
{
    private PlayerController _action;
    private Player _player;

    public PlayerControll(Player player)
    {
        _player = player;
        _action = new PlayerController();
        _action.Player.SetCallbacks(this);
    }

    public void OnEnable() => _action.Player.Enable();
    public void OnDisable() => _action.Player.Disable();

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
       _player.SetMoveInput(input);
    }
}
