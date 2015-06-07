using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class TextInput : MonoBehaviour
{

    private string sInput;
    private string readInput;
    public Text tInput;
    public InputField iInput;
    public List<string> solutionList;
    public WordBankControls words;
    //get input from text field
    //print input into textbox after pressing enter
    void Start()
    {
        sInput = "";
        solutionList = new List<string>();
        words = new WordBankControls();
    }

    // Update is called once per frame
    void Update()
    {
        //ReadFromFile();
        if (Input.GetKeyDown("return"))
        {
            //set the text field to be user input
            tInput.text = iInput.text;
            //save user input in a string
            sInput = iInput.text;
            words.AddWord(iInput.text);
        }

        if (sInput != null)
        { //<-- yay no errors!
            //do something
        }
    }

    //Save to Text File
    private void SaveToFile()
    {
        StreamWriter writer = new StreamWriter(("LevelOne")); // where to find the text file 
        foreach (string b in solutionList)
        {
            string output = b;
            writer.WriteLine(output);
        }

        writer.Close();
    }

    //Read from Text File 
    private void ReadFromFile()
    {
        StreamReader reader = new StreamReader("LevelOne"); // put in where the txt file is 
        //string s = reader.ReadLine();
        readInput = reader.ReadLine();
        while (readInput != null)
        {
            //char[] delimiter = {':'}; //colon splits 
            //string[] fields = s.Split(delimiter);
            solutionList.Add(readInput); //adds to solutionList //fix to take in two fields 
            System.Console.WriteLine(readInput);
            readInput = reader.ReadLine(); //test
            CheckFromFile();

        }
    }

    //Check Text Input with Text File
    private void CheckFromFile()
    {
        if (readInput == sInput)
        {
            System.Console.WriteLine("Answer Good"); //Testing 
            //Add score offset 
        }
    }
}
