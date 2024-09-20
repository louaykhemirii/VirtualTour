using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class textedit : MonoBehaviour
{
    [SerializeField] TextAsset test;
    
    public void WriteString1()
    {
        string path = "Assets/Resources/test.txt";
        string path2 = "Assets/Resources/bossdialogue.txt";
        //Write some text to the test.txt file
        File.WriteAllText(path, "");
        StreamWriter writer = new StreamWriter(path, true);
        StreamReader reader = new StreamReader(path2);
        writer.WriteLine(reader.ReadToEnd());
        
        writer.Close();

        //Re-import the file to update the reference in the editor
        //UnityEditor.AssetDatabase.ImportAsset(path); 
        TextAsset asset = (TextAsset)Resources.Load("test");

        //Print the text from the file
        Debug.Log(asset.text);
    }

  
      public void ReadString()
    {
        string path = "Assets/Resources/test.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path); 
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    public void checktextfile()
    {
        
            Debug.Log(test);
        
    }
}
