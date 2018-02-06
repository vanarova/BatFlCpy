using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BatchCopyCore
{
    //TODO: This class works fine, its not implemented yet. please search for reference of statemanager


    /// <summary>
    /// This class is responsible to maintain the state of application, It will keep
    /// track of user changes on UI and save the user preferences on disk, to facilitate
    /// user to refer to previous states. for example - last opened file by program.
    /// </summary>
   public class StateManager
    {
        static StateManager()
        {
            if (SerializedObject.SerializedCollection == null)
            {
                SerializedObject.SerializedCollection = new Dictionary<string, object>();
            }
        }
        public static void SaveStateVariable(string key, object obj, out string err)
        {
            err = "";
            try
            {
            if (!SerializedObject.SerializedCollection.ContainsKey(key))
            {
                SerializedObject.SerializedCollection.Add(key, obj as string);
            }
            else
            {
                SerializedObject.SerializedCollection[key] = obj as string;
            }
                using (FileStream fileStream = new FileStream("State.dat", FileMode.Create))
                {
                    //create a BinaryFormatter object to serialize our object
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, SerializedObject.SerializedCollection);
                }
            }
            catch (Exception e)
            {// catching error here makes sense, because it may fail to serialize and we can tell user about it, and still continue
             // with applications, this cant be done at application level, as it will be difficult to find error originating 
             // class at application level.
                err = e.Message;
            }
            
        }

        public static object GetStateVariable(string key, out string err)
        {
            err = "";
            //create a FileStream to read the serialized object
            using (FileStream fileStream = new FileStream("State.dat", FileMode.Open))
            {
                //create a BinaryFormatter and deserialize the object
                BinaryFormatter formatter = new BinaryFormatter();
                SerializedObject.SerializedCollection = (Dictionary<string, object>)formatter.Deserialize(fileStream);
            }
            return SerializedObject.SerializedCollection;
        }

    }




    /// <summary>
    /// This class is a generic implmentation for a list of values needs to be serialized.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    static class SerializedObject
    {
        public static Dictionary<string,object> SerializedCollection { get; set; }
    }



}
