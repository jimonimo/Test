using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickImaged : MonoBehaviour
{
    private static ClickImaged _instance;
    public static ClickImaged Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ClickImaged();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }

    public SpriteRenderer spriteRenderer;
    public string log;

    
    public void ChangeSprite()
    {
        /*
        if (log == "0")
        {
            log = "1";
            Sprite newSprite = Resources.Load<Sprite>(log);
            spriteRenderer.sprite = newSprite;
        }
        else if (log == "1")
        {
            log = "0";
            Sprite newSprite = Resources.Load<Sprite>(log);
            spriteRenderer.sprite = newSprite;
        }
        */
        Sprite newSprite = Resources.Load<Sprite>(log);
        spriteRenderer.sprite = newSprite;
    }
    //�ܺο��� �α��̸��� �ٲٴ� �ڵ�
    public void ChangeLog(string _log)
    {
        log = _log;
    }
}
