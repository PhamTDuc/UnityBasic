using UnityEngine;

public class TurnButtonAnimator : MonoBehaviour
{
    private InputSystem input_system;
    private Animator animator = null;
    bool is_flipping = false;
    private static readonly int hashFlipBtn = Animator.StringToHash("FlipButton");

    private void Awake()
    {
        input_system = new InputSystem();
        input_system.PlayerControl.Combat.performed += (ctx)=>FlipButton();
        animator = GetComponent<Animator>();
    }

    private void Enabled()=> input_system.Enable();
    private void Disable()=> input_system.Disable();

    private void OnMouseDown()
    {
        FlipButton();
    }
    private void FlipButton()
    {
        if(is_flipping) {return;}
        is_flipping = true;
        animator.SetTrigger(hashFlipBtn);

    }

    public void FinishFlipping()=> is_flipping = false;
}
