using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]

public class CharacterData {
    public string charname;
    public string power;
    public short charge;

    public void setall(CharacterData data)
    {
        charname = data.charname;
        power = data.power;
        charge = data.charge;
    }
}
