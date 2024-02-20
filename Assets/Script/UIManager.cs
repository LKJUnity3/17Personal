using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    [SerializeField]        
    private Text numtext;
    [SerializeField]
    private Button Click;
    private void Awake()
    {
        TextModify();
        Click.onClick.AddListener(ClickButton);
    }

    public void ClickButton()
    {
        GameManager.instance.Score -= 1;
        TextModify();
    }
    public void TextModify()
    {
        numtext.text = GameManager.instance.Score.ToString("N0");
        if (GameManager.instance.Score <= 0)
        {
            numtext.fontSize = 100;
            numtext.text = "�̰� ���� ���~ �� ����̸� ���θ� �ؼ� ����� �ϰڴ�~";
        }
    }
}
