using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;

public class TextInput : MonoBehaviour
{

    //private string sInput;
    private string readInput;
    public Text tInput;
    private List<string> solutionList;
    public WordBankControls words;
    public Score score;
    //get input from text field
    //print input into textbox after pressing enter
    void Start()
    {
        //sInput = "";
        solutionList = new List<string>();
        //words = new WordBankControls();
    }

	public void changeText() {
		Solution sCheck = this.GetComponent<Solution>();
		tInput.text = sCheck.updateAnswer();
        ReadFromFile();
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
        string filename = Path.GetFileName(Application.dataPath + "/LevelOne.txt");
        StreamReader reader = new StreamReader(filename); // put in where the txt file is 
        //string s = reader.ReadLine();
        Debug.Log("tInput: " + tInput.text);
        readInput = reader.ReadLine();
        while (readInput != null && !CheckFromFile(readInput))
        {
            //char[] delimiter = {':'}; //colon splits 
            //string[] fields = s.Split(delimiter);
            solutionList.Add(readInput); //adds to solutionList //fix to take in two fields 
            System.Console.WriteLine(readInput);
            readInput = reader.ReadLine(); //test
        }
    }

    //Check Text Input with Text File
    private bool CheckFromFile(string input)
    {
        //Debug.Log(input.ToLower());
        if (input.ToLower() == tInput.text)
        {
            Debug.Log("Answer good.");
            words.AddWord(tInput.text);
            Debug.Log(tInput.text);
            if (tInput.text != "cake" || tInput.text != "oil" || tInput.text != "kite" || tInput.text != "cheese" || tInput.text != "delete" || tInput.text != "code" || tInput.text != "hole" || tInput.text != "dart")
            {
                Debug.Log("I'm in here!");
                if (tInput.text == "key")
                {
                    //do nothing
                }
                else
                {
                    score.score += score.IncreaseScore(score.score, tInput.text, false, false);
                    Debug.Log("Score: " + score.score);
                }
            }
            return true;
            //System.Console.WriteLine("Answer Good"); //Testing 
            //Add score offset 
        }
        return false;
    }
}
