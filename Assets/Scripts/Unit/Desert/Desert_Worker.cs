using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desert_Worker : Worker
{
    void Awake()
    {
        _name = "사막 종족 일꾼";
        _unitDesc = "듬직해 보인다.";
        _code = (int)UNIT.DESERT_WORKER;
        _max_hp = 10;
        _hp = _max_hp;
        _damage = 1;
        _basedistance = 1;
        _attackdistance = 1;
        maxCreateCount = 2;
        maintenanceCost = 1;
        _desc = "생성까지 " + (maxCreateCount - createCount) + "턴 남음";

        GameMng.I._BuiltGM.act = ACTIVITY.NONE;
        GameMng.I.AddDelegate(this.waitingCreate);
    }

    void Start()
    {
        _name = string.Format("사막 종족 일꾼  (소유자 : {0})", GameMng.I.getUserName(_uniqueNumber));
        _emoteSide.color = GetUserColor(_uniqueNumber);
    }


    void OnDestroy()
    {
        buildingobj?.DestroyMyself();
        
        if (!(createCount > maxCreateCount - 1))
            GameMng.I.RemoveDelegate(waitingCreate);
        else
            GameMng.I.RemoveDelegate(maintenance);
    }
}
