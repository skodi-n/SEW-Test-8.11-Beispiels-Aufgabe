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
    private Wahl S1;
    private Random _random;
    
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
    

    public void BundestaatHinzufuegen()
    {
        _random = new Random();
        
        B1 = new Wahl("FL", "Florida", 29, 2, 1, 0, 0);
        B2 = new Wahl("TX", "Texas", 38, 2, 1, 0, 0);
        B3 = new Wahl("CA", "Kalifornien", 55, 2, 3, 0, 0);
        B4 = new Wahl("PA", "Pensylvania", 18, 2, 1, 0, 0);
        S1 = new Wahl("MI", "Mischigen", 10, _random.Next(1, 10), _random.Next(1, 10), _random.Next(1, 10), _random.Next(1, 10));
        
    }

    public void GetWinnerState(Wahl P2)
    {
        if (B1._stimmenRepublikaner2020 > B1._stimmenDemokraten2020)
        {

            _wahlleute += B1._wahlleute;


        }
        else
        {

            P2._wahlleute += B1._wahlleute;

        }

        if (B2._stimmenRepublikaner2020 > B2._stimmenDemokraten2020)
        {

            _wahlleute += B2._wahlleute;


        }
        else
        {

            P2._wahlleute += B2._wahlleute;

        }
        if (B3._stimmenRepublikaner2020 > B3._stimmenDemokraten2020)
        {

           _wahlleute += B3._wahlleute;


        }
        else
        {

            P2._wahlleute += B3._wahlleute;

        }

        if (B4._stimmenRepublikaner2020 > B4._stimmenDemokraten2020)
        {

            _wahlleute += B4._wahlleute;


        }
        else
        {

            P2._wahlleute += B4._wahlleute;

        }
        
        if (S1._stimmenRepublikaner2020 > S1._stimmenDemokraten2020)
        {

            _wahlleute += S1._wahlleute;


        }
        else
        {

            P2._wahlleute += S1._wahlleute;

        }
        
        
        
        
    }
    public string Winner(Wahl P2)
    {
        if (_wahlleute > P2._wahlleute)
        {

            return "Der Sieger ist: Donald Trump und die Republikansiche Partei \n" +
                   "Wahlleute Trump: " + _wahlleute + " \n" +
                   "Wahlleute Harris: " + P2._wahlleute;


        }
       
                
        return "Die Siegerin ist: Kamala Harris und die Demokratische Partei! \n" +
                   "Wahlleute Trump: " + _wahlleute + " \n" +
                   "Wahlleute Harris: " + P2._wahlleute;
        
            
    }
    
    

}