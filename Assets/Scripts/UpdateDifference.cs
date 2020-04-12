using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateDifference : MonoBehaviour
{
   
    public TextMeshProUGUI yourMoneys;
    public TextMeshProUGUI otherMoneys;

    public void ChangeThis()
    {

        int difference = int.Parse(yourMoneys.text)-int.Parse(otherMoneys.text);
        this.GetComponent<TextMeshProUGUI>().text = difference.ToString();
        if(difference>=0) this.GetComponent<TextMeshProUGUI>().color = Color.green;
        else this.GetComponent<TextMeshProUGUI>().color = Color.red;
    }

}
