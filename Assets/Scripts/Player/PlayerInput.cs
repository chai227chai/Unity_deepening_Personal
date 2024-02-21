using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerInputAction InputAction { get; private set; }
    public PlayerInputAction.PlayerActions PlayerAction { get; private set; }

    private void Awake()
    {
        InputAction = new PlayerInputAction();

        PlayerAction = InputAction.Player;
    }

    public void OnEnable()
    {
        InputAction.Enable();
    }

    public void OnDisable()
    {
        InputAction.Disable();
    }
}
