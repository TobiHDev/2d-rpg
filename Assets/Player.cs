using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public StateMachine stateMachine { get; private set; }
    public Player_IdleState idleState{ get; private set; }
    public Player_MoveState moveState{ get; private set; }
    private PlayerInputSet input;
    public Vector2 mouseInput { get; private set; }

    private void Awake()
    {
        stateMachine = new StateMachine();
        idleState = new Player_IdleState(this, stateMachine, "Idle");
        moveState = new Player_MoveState(this, stateMachine, "Move");
        input = new PlayerInputSet();
    }
    private void OnEnable()
    {
        input.Enable();
        input.Player.Movement.performed += ctx => mouseInput = ctx.ReadValue<Vector2>();
        input.Player.Movement.canceled += ctx => mouseInput = Vector2.zero;
    }
    private void OnDisable()
    {
        input.Disable();
    }
    private void Start()
    {
        stateMachine.Initialize(idleState);
    }
    private void Update()
    {
        stateMachine.UpdateActiveState();
    }
}
