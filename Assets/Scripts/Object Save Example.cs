using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSaveExample : MonoBehaviour {

    CharacterData person;

    void Start()
    {

        person = new CharacterData(name);

        if (BinaryCharacterSaver.onLoad(name) == null)
        {
            person.setplacement(transform.position);
            BinaryCharacterSaver.onSave(person);
        }
        else
        {
            person.setall(BinaryCharacterSaver.onLoad(name));
            gameObject.transform.position = person.getplacement();
        }
    }
    private void Update()
    {
        person.setplacement(transform.position);
        BinaryCharacterSaver.onSave(person);
    }
    private void OnDestroy()
    {
        BinaryCharacterSaver.onSave(person);
    }
}
