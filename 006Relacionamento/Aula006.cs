using _006Relacionamento;
using System;

class Aula006
{
    static void Main(string[] args)
    {
        Lutador[] l = new Lutador[6];

        l[0] = new Lutador("Maguila", "Brasil", 31, 1.75, 68.9, 11, 2, 1);
        l[1] = new Lutador("Pink Bobby Jenkins", "EUA", 29, 1.75, 68.8, 14, 2, 3);
        l[2] = new Lutador("Nhoque Balboa", "EUA", 35, 1.65, 80.9, 12, 2, 1);
        l[3] = new Lutador("KanguruJack", "Australia", 28, 1.93, 81.6, 13, 0, 2);
        l[4] = new Lutador("Popó", "Brasil", 37, 1.70, 119.3, 5, 4, 3);
        l[5] = new Lutador("Bambam", "EUA", 30, 1.81, 105.7, 12, 2, 4);


        Luta luta1 = new Luta();
        Luta luta2 = new Luta();

        luta1.MarcarLuta(l[0], l[1]);
        luta1.Lutar();

        luta2.MarcarLuta(l[2], l[3]);
        luta2.Lutar();
        


    }
}