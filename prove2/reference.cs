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

