using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickImaged : MonoBehaviour
{
    public Image[] images = new Image[2];
    public bool isClick;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void Start()
    {
        isClick = false;
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void ChangeImage()
    {
        ChangeSprite();
    }
    void ChangeSprite()
    {
        newSprite = Resources.Load<Sprite>("1");
        spriteRenderer.sprite = newSprite;
    }
}
