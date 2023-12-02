using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Clothing_Display : MonoBehaviour
{
    public Cloths clothing;

    public Image artworkImage;
    public Text cName;
    public Text cost;

    void Start()
    {
        artworkImage.sprite = clothing.artwork;
        cName.text = clothing.clothName;
        cost.text = clothing.cost.ToString();


    }

  }
