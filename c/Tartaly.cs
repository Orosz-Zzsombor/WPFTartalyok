class Tartaly
{

    private string nev;
    private int a,b,c;
    private double aktLiter;
    public Tartaly( string nev, int a, int b, int c)
    {
        this.nev = nev;
        this.a = a;
        this.b = b;
        this.c= c;
        aktLiter = 0;

    }
    public Tartaly(string nev)
    {
        Tartaly uresTartaly = new Tartaly(nev, 10, 10, 10);

    }
    public double Terfogat { get { return a*b*c; }}


    public void DuplazMeretet()
    {
        a *= 2;
    }
    public void TeljesLeengedes()
    {
        aktLiter = 0;
    }
    public double Toltottseg { get { return (aktLiter*1000 /Terfogat)*100; }}

    public void Tolt(double liter)
    {
        aktLiter += liter;
    }

    public string Info()
    {
        return $"{this.nev}: {this.Terfogat * 1000:n1} cm3 = ({this.Terfogat:n2} liter)," +
            $" töltöttsége: {this.Toltottseg:n2}%, ({this.aktLiter:n2} liter)," +
            $" méretei: {this.a}x{this.b}x{this.c} cm";

        /*
        return string.Format("{0}: {1} cm3 = ({6} liter), töltöttsége: {2}%, ({7} liter), méretei: {3}x{4}x{5} cm"
            , this.nev
            , this.Terfogat
            , this.Toltottseg
            , this.a
            , this.b
            , this.c
            , this.Terfogat / 1000
            , this.aktLiter
            );
        */

    }


    

}
