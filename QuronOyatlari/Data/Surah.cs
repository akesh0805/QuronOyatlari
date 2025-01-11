namespace QuronOyatlari.Data;

public class AllSurahs
{
    public List<Surah>? Data { get; set; }
}
public class SurahTranslationResponse  
{  
    public int Code { get; set; }  
    public string? Status { get; set; }  
    public SurahTranslationData? Data { get; set; }  
}

public class SurahTranslationData
{
    public int Number {get;set;}
    public string? Text {get;set;}
    public Surah? Surah {get;set;}
}

public class Surah
{
    public int Number { get; set; }
    public string? Name {get;set;}
    public string? EnglishName {get;set;}
    public int NumberOfAyahs { get; set; }
}