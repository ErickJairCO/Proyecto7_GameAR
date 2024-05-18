using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnARPosition;

    public static GameManager instance;
    private void Awake()
    {

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else 
        {
            instance = this;
        }
    }

    public void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Menu principal Activado");
    }

    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Menu Items Activado");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("Posicion AR Activado");
    }

    public void CloseAPP()
    {
        Application.Quit();
    }
}
