using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControl playerControl;
    public Vector2 movementInput;
    public float verticalinput;
    public float horizontalinput;
    // Start is called before the first frame update

    private void OnEnable()
    {
        if (playerControl == null)
        {
            playerControl = new PlayerControl();
            playerControl.PlayerControls.WASD.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerControl.Enable();
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void HandleMovementInput()
    {
        verticalinput = movementInput.y;
        horizontalinput = movementInput.x;
    }
    public void HandleAllInput()
    {
        HandleMovementInput();
    }
}
