namespace Wahlen;

public class Wahl
{
    private string _kuerzel;
    private string _name;
    private int _wahlleute;
    private int _stimmenRepublikaner2020;
    private int _stimmenDemokraten2020;
    private int _stimmenRepublikaner2024;
    private int _stimmenDemokraten2024;
    private Wahl B1;
    private Wahl B2;
    private Wahl B3;
    private Wahl B4;
    
    
    
    
    public Wahl(string kuerzel, string name, int wahlleute, int stimmenRepublikaner2020, int stimmenDemokraten2020, int stimmenRepublikaner2024, int stimmenDemokraten2024)
    {
        _kuerzel = kuerzel;
        _name = name;
        _wahlleute = wahlleute;
        _stimmenRepublikaner2020 = stimmenRepublikaner2020;
        _stimmenDemokraten2020 = stimmenDemokraten2020;
        _stimmenRepublikaner2024 = stimmenRepublikaner2024;
        _stimmenDemokraten2024 = stimmenDemokraten2024;
    }

    public Wahl()
    {
        _kuerzel = " ";
        _name = " ";
        _wahlleute = 0;
        _stimmenRepublikaner2020 = 0;
        _stimmenDemokraten2020 = 0;
        _stimmenRepublikaner2024 = 0;
        _stimmenDemokraten2024 = 0;
        
        
    }

    public void BundestaatHinzufuegen()
    {
        B1 = new Wahl("FL", "Florida", 29, 1000000, 2500000, 0, 0);
        B2 = new Wahl("TX", "Texas", 38, 1000000, 5500000, 0, 0);
        B3 = new Wahl("CA", "Kalifornien", 55, 500000, 12000000, 0, 0);
        B4 = new Wahl("PA", "Pensylvania", 18, 245000, 980000, 0, 0);
    }

    public void GetWinnerState()
    {
        if (B1._stimmenRepublikaner2020 > B1._stimmenDemokraten2020)
        {

            _wahlleute += B1._wahlleute;


        }
        else
        {

            this._wahlleute += B1._wahlleute;

        }

        if (B2._stimmenRepublikaner2020 > B2._stimmenDemokraten2020)
        {

            _wahlleute += B1._wahlleute;


        }
        else
        {

            this._wahlleute += B2._wahlleute;

        }
        if (B3._stimmenRepublikaner2020 > B3._stimmenDemokraten2020)
        {

           _wahlleute += B3._wahlleute;


        }
        else
        {

            this._wahlleute += B3._wahlleute;

        }

        if (B4._stimmenRepublikaner2020 > B4._stimmenDemokraten2020)
        {

            _wahlleute += B4._wahlleute;


        }
        else
        {

            this._wahlleute += B4._wahlleute;

        }
        
        
        
        
    }
    public string Winner()
    {
        if (_wahlleute > this._wahlleute)
        {

            return "Der Sieger ist: Donald Trump und die Republikansiche Partei";


        }

        else
        {
                
            return "Die Siegerin ist: Kamala Harris und die Demokratische Partei!";
                
        }
            
            
            
            
            
    }
    
    

}