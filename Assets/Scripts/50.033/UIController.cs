using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 0.0f;
    }
    void Start()
    {
        
    }
    public void StartButtonClicked()
    {
        foreach (Transform eachChild in transform)
        {
            if (eachChild.name == "Start")
            {
                eachChild.gameObject.SetActive(false);   
            }
            if (eachChild.name == "Minimap")
            {
                eachChild.gameObject.SetActive(true);
            }
            if (eachChild.name == "MinimapBorder")
            {
                eachChild.gameObject.SetActive(true);
            }
            if (eachChild.name == "Reset")
            {
                eachChild.gameObject.SetActive(true);
            }
            if (eachChild.name == "Background")
            {
                eachChild.gameObject.SetActive(false);
            }
        }
        Time.timeScale = 1.0f;
    }
    public void ResetButtonClicked()
    {
        foreach (Transform eachChild in transform)
        {
            if (eachChild.name == "Start")
            {
                eachChild.gameObject.SetActive(true);
            }
            if (eachChild.name == "Minimap")
            {
                eachChild.gameObject.SetActive(false);
            }
            if (eachChild.name == "MinimapBorder")
            {
                eachChild.gameObject.SetActive(false);
            }
            if (eachChild.name == "Reset")
            {
                eachChild.gameObject.SetActive(false);
            }
            if (eachChild.name == "Background")
            {
                eachChild.gameObject.SetActive(true);
            }
        }
        Application.LoadLevel(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
