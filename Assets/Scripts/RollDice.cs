using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollDice : MonoBehaviour
{
    
    public void Roll()
    {   
        int r1, r2;
        r1 = Random.Range(1,7);
        r2 = Random.Range(1,7);
        this.GetComponent<TextMeshProUGUI>().text = r1+"+"+r2;
    }

}
