using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Text Cash;
    public GameObject[] drawSlot;
    public GameObject floor;
    public SpriteRenderer[] spriteSlot;

    public int Number = 0;
    public int number = 0;
    public bool[] Characterdraw = new bool[4];

    [NonSerialized]
    public bool[] Confirmed = new bool[4];
    public int cashMoney = 0;
    public int CatCash = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        DrawCharacter();
        EncCharacter();
        CashManager(cashMoney);
    }

    public void CashManager(int cash)
    {
        CatCash += cash;
        Cash.text = $"{CatCash}";
    }

    public void EncCharacter()
    {
        spriteSlot[Number].color = Color.white;
    }

    public void DrawCharacter()
    {
        for (int i = 0; i < 4; i++)
        {
            if (Characterdraw[i] == true)
            {
                drawSlot[i].SetActive(false);
                Characterdraw[i] = false;
            }
        }

        if (Number != 0)
        {
            floor.SetActive(true);
            drawSlot[Number].SetActive(true);
            Characterdraw[Number] = true;
        }
    }
}
