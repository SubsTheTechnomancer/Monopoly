using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddMoney : MonoBehaviour
{
   
    public TextMeshProUGUI tmp;

    public void Add()
    {
        int moneys = 0;
        moneys = int.Parse(tmp.text);
        int content = 0;
        if(Int32.TryParse(this.GetComponent<TMP_InputField>().text,out content))
            moneys += content;
        tmp.text = moneys.ToString();
        this.GetComponent<TMP_InputField>().text = "";
    }

}
