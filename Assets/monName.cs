using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
//using JetBrains.Annotations;

public class monName : MonoBehaviour
{
    public string naa;
    public float monHp;
    public Image monHpbar;
    public float i = 10;
    float jk = 10;
    public TextMeshProUGUI hptext;
    //[HideInInspector]
    public float monCurHP;
    public monName target;
    public float coolTime;
    public float Atk;
    public int re;

    string dead = "dead";

    

    void Start()
    {
        monCurHP = monHp;
        gameObject.GetComponent<TextMeshProUGUI>().text = naa;
        hptext.text = monCurHP + "/"+ monHp;
    }
    
    float cTime;

    void Update()
    {
        if (monCurHP > 0)
        {

            if (cTime >= coolTime)
            {
                target.OnDamege(Atk);
                cTime = 0;
            }
            else
            {
                cTime += Time.deltaTime;
            }
        }
        /*if (cTime >= jk)
        {
            monCurHP--;
            float fill = monCurHP / monHp;
            monHpbar.fillAmount = fill;

        }
        else
        {
            cTime += Time.deltaTime;
        }*/
    }

    public void OnDamege(float _Atk)
    {
             monCurHP -= _Atk;

        if (monCurHP <= 0)
        {
            if (re > 0)
            {
                monCurHP = monHp / 2f; //monCurHP = monHp / 0.5
                re --;
                hptext.text = monCurHP + "/" + monHp;
            }
            else
            {
                hptext.text = dead;
            }
        }
        else
        {
            hptext.text = monCurHP + "/" + monHp;
        }
        float fill = monCurHP / monHp;
        monHpbar.fillAmount = fill;
    }

}