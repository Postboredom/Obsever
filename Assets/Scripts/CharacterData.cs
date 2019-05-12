using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class SerializableVector3
{
    public float x, y, z;

    public SerializableVector3(float x,float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return String.Format("[{0}, {1}, {2}]", x, y, z);
    }

    public static implicit operator Vector3(SerializableVector3 rValue)
    {
        return new Vector3(rValue.x, rValue.y, rValue.z);
    }

    public static implicit operator SerializableVector3(Vector3 rValue)
    {
        return new SerializableVector3(rValue.x, rValue.y, rValue.z);
    }
}

[Serializable]
public class CharacterData {
    private string name;
    public string charname;
    public string power;
    public short charge;
    public string level;
    public SerializableVector3 placement;

    public CharacterData(string tname)
    {
        name = tname;
        power = "flights";
        charge = 21;
        level = " wd";
    }

    public void setall(CharacterData data)
    {
        charname = data.charname;
        power = data.power;
        charge = data.charge;
        level = data.level;
    }
    public void setplacement(Vector3 place)
    {
        placement = new SerializableVector3(place.x,place.y,place.z);
    }

    public Vector3 getplacement()
    {
        if (placement == null)
        {
            return new Vector3(0, 0, 0);
        }
        else
        {
            return new Vector3(placement.x, placement.y, placement.z);
        }
    }
    public override string ToString()
    {
        return name; 
    }
}
