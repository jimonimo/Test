using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLog : MonoBehaviour
{
    public string str;
    
    public void ChangeLog()
    {
        ClickImaged.Instance.ChangeLog(str); //�α��̸� ����
        ClickImaged.Instance.ChangeSprite(); //�α��̹��� ����
    }
}
