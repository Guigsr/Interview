using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public int gold;
    public Text GoldValue;

   public void GainCoin()
    {
        gold++;
    }

    void Update()
    {
        GoldValue.text = gold.ToString();
    }
}
