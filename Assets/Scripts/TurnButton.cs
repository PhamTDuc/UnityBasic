using System.Collections;
using UnityEngine;

public class TurnButton : MonoBehaviour
{
    private bool is_turn = true;
    private bool is_flipping = false;
    private InputSystem input_system;
    public float duration = 2.0f;

    private void Awake()
    {
        input_system = new InputSystem();
        input_system.PlayerControl.Combat.performed += (ctx)=>ChangeTurn();
    }

    private void OnEnable() => input_system.Enable();
    private void OnDisable() => input_system.Disable();

    private void ChangeTurn()
    {
         if(!is_flipping)
         {
             StartCoroutine("ChangeRotation");
         }
         
    }

    private void OnMouseDown()
    {
        ChangeTurn();
    }

    //private void Combat(InputAction.CallbackContext ctx)
    //{
    //    ChangeTurn();
    //}

    IEnumerator ChangeRotation()
    {
        is_flipping = true;

        float from  = is_turn ? 0f : 180f;
        float to =  is_turn ? 180f : 0f;
        float current = from;
        float step = (to - from) / duration * Time.fixedDeltaTime;
        float timer = 0f;
        while(timer < duration)
        {
            timer += Time.fixedDeltaTime;
            if(timer >= duration)
                current = to;
            else
                current +=  step;
            
            this.transform.localRotation = Quaternion.Euler(current, 0, 0);
            yield return new WaitForSeconds(Time.fixedDeltaTime);
        }

        is_turn =! is_turn; 
        is_flipping = false;
    }
}
