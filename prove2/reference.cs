using System;

public class Reference
{
    public List<Reference> _reference = new List<Reference>();
    private string _fileName = "referencetext.txt";
    private string _key;
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

  public void LoadReference()
    {
        List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Reference entry = new Reference();

            entry._key = entries[0];
            entry._book = entries[1];
            entry._chapter = int.Parse(entries[2]);
            entry._verseStart = int.Parse(entries[3]);
            entry._verseEnd = int.Parse(entries[4]);

            _reference.Add(entry);
        }
    }
