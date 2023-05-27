using System;

public class Scripture

    public List<Scripture> _scripture = new List<Scripture>();
    private string _fileName = "referencetext.txt";
    private string _key;
    private string _text;
    public int _index;
    public string _scriptureText;

public void LoadScriptures()
    {
        List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Scripture entry = new Scripture();

            entry._key = entries[0];
            entry._text = entries[6];

            _scripture.Add(entry);
        }
    }
