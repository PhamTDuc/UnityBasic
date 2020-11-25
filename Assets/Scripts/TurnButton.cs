using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnButton : MonoBehaviour
{
    private bool is_turn = true;
    private bool is_flipping = false;
    public float duration = 2.0f;
    private void OnMouseDown() => ChangeTurn();


    private void ChangeTurn()
    {
         if(!is_flipping)
         {
             StartCoroutine("ChangeRotation");
         }
         
    }

    IEnumerator ChangeRotation()
    {
        is_flipping = true;
        is_turn =! is_turn; 

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

        is_flipping = false;
    }
}
