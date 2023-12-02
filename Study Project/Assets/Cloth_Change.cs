using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth_Change : MonoBehaviour
{
    public Cloths clothing;
    public SpriteRenderer bodyPart;

    Gold _gold;
    public GameObject purse;

    public int coin;
   

    void Awake()
    {
        _gold = purse.GetComponent<Gold>();
       
        
    }
    void Update()
    {
        coin = _gold.gold;
    }

    [Header("All Available Clothing")]
    public List<Cloths> options = new List<Cloths>();

    public void ClothChanging()
    {
        bodyPart.sprite = options[1].artwork;
    }

    public void Buiyng()
    {
        if (coin >= options[1].cost)
        {
            ClothChanging();
            _gold.gold = coin - options[1].cost;
        }
    }
}
