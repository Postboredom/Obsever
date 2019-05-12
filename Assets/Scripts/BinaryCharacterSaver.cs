using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;



public class BinaryCharacterSaver : MonoBehaviour {

    const string folderName = "BinaryCharacterData";
    const string fileExtension = ".dat";

	void Update () {

	}

    public static void onSave <T>(T Data)
    {
        string folderPath = Path.Combine(Application.persistentDataPath, folderName);
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        string dataPath = Path.Combine(folderPath, Data.ToString() + fileExtension);
        SaveData(Data, dataPath);
    }


    static void SaveData<T> (T data, string path)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        using (FileStream fileStream = File.Open(path, FileMode.OpenOrCreate))
        {
            binaryFormatter.Serialize(fileStream, data);
        }
    }

    public static CharacterData onLoad(string name)
    {
        string[] filePaths = GetFilePaths();

        if (filePaths.Length > 0)
        {
            for(int ii = 0; ii < filePaths.Length; ii++)
            {
                string sname = Path.Combine(Path.Combine(Application.persistentDataPath, folderName), name + fileExtension);
                if (filePaths[ii] == sname) 
                {
                    return LoadCharacter(filePaths[ii]);
                }
            }
        }
        return null;
    }


    static CharacterData LoadCharacter (string path)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        using (FileStream fileStream = File.Open(path, FileMode.Open))
        {
            return (CharacterData)binaryFormatter.Deserialize(fileStream);
        }
    }

    static string[] GetFilePaths()
    {
        string folderPath = Path.Combine(Application.persistentDataPath, folderName);

        return Directory.GetFiles(folderPath);
    }
}
