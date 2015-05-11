using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class WordManager : MonoBehaviour {

    public TextAsset WordAsset;
    public static List<string> words = new List<string>{};

    //List<Dictionary<string, string>> wordDict = new List<Dictionary<string, string>>();
    Dictionary<string, string> obj;

    void Start()
    {
        print("This is going on.");
    }

    void ReadXML()
    {
        print("Starting to Read");
        XmlDocument solution = new XmlDocument();
        solution.LoadXml(WordAsset.text);
        XmlNodeList wordList = solution.GetElementsByTagName("WordBank");

        foreach (XmlNode wordInfo in wordList)
        {
            XmlNodeList wordContent = wordInfo.ChildNodes;
            obj = new Dictionary<string, string>();

            foreach (XmlNode content in wordContent)
            {
                if (content.Name == "LevelSolutions1")
                {
                    obj.Add("level1solutions", content.InnerText);
                    print ("This is happening man");
                }
            }
        }
    }
}