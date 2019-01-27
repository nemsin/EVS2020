using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Money;
    public List<GameObject> Inventory;
}


public static class ObjectExtension
{

    public static T CopyObject<T>(this object objSource)
    {

        using (MemoryStream stream = new MemoryStream())
        {

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, objSource);
            stream.Position = 0;

            return (T)formatter.Deserialize(stream);
        }
    }
}
