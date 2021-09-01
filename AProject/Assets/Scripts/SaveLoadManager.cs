using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SaveLoadManager : MonoBehaviour
{
    #region ΩÃ±€≈Ê
    private static SaveLoadManager _instance;
    public static SaveLoadManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SaveLoadManager();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    #endregion

    #region UI
    public Button setBtn;
    public GameObject setPopup;

    public void ShowPopup()
    {
        setPopup.SetActive(!setPopup.activeSelf);
    }
    
    #endregion

    void Start()
    {
    }

    void Update()
    {
        
    }

    #region SAVE

    #endregion
}
[Serializable]
public struct GameInfo
{
    public Vector3 position;
    public int playCount;
    public string playerID;
    public int energy;
    public int dayCount;
}
