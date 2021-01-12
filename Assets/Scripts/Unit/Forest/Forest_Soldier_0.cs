using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest_Soldier_0 : Unit
{
    public Animator _anim;

    void Start()
    {
        _name = "���� 1";
        _desc = "������ �׿��ָ�!";
        _cost = 0;
        _activity.Add(ACTIVITY.MOVE);
        _activity.Add(ACTIVITY.ATTACK);
        StartCoroutine("creating");
    }

    IEnumerator creating()
    {
        yield return new WaitForSeconds(1);
        GameMng.I._BuiltGM.act = ACTIVITY.NONE;
    }

    public void walking()
    {
        _anim.SetBool("isWorking", false);
        _anim.SetBool("isRunning", true);
    }
    public void working()
    {
        _anim.SetBool("isRunning", false);
        _anim.SetBool("isWorking", true);
    }
    public void dying()
    {
        _anim.SetBool("isDying", true);
    }
}