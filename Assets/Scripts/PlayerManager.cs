using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    public GameObject player;
    public PlayerLocomotion playerLocomotion;
    public InputManager inputManager;
    public Rigidbody rigidbody;
    // Start is called before the first frame update

    public float moveSpeed;
    public float rotSpeed;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        inputManager = player.GetComponent<InputManager>();
        playerLocomotion = player.GetComponent<PlayerLocomotion>();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.HandleAllInput();
    }
    private void FixedUpdate()
    {
        playerLocomotion.HandlesAllMovement();
    }
}
