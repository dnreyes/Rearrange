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

	public void changeText() {
		Solution sCheck = this.GetComponent<Solution>();
		tInput.text = sCheck.updateAnswer();
	}

    //Save to Text File
    private void SaveToFile()
    {
        StreamWriter writer = new StreamWriter(@"C:\Users\adao1\Documents\GitHub\Rearrange\Rearrange\Assets\Scripts\LevelOne.txt"); // where to find the text file 
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
        StreamReader reader = new StreamReader(@"C:\Users\adao1\Documents\GitHub\Rearrange\Rearrange\Assets\Scripts\LevelOne.txt"); // put in where the txt file is 
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
