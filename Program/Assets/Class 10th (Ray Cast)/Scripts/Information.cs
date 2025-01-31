using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    [SerializeField] string title;
    [SerializeField] string description;
    [SerializeField] string price;

    private Text titleText;
    private Text descriptionText;
    private Text priceText;

    private void Awake()
    {
        titleText = transform.GetChild(0).GetComponent<Text>();
        descriptionText = transform.GetChild(1).GetComponent<Text>();
        priceText = transform.GetChild(2).GetComponent<Text>();
    }

    void Start()
    {
        titleText.text = title;
        descriptionText.text = description;
        priceText.text = price;
    }

    
}
