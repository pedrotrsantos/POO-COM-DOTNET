using _006Relacionamento;
using System;

class Aula006
{
    static void Main(string[] args)
    {
        Lutador[] l = new Lutador[6];

        l[0] = new Lutador("Pretty Boy", "França", 31, 1.75, 68.9, 11, 2, 1);
        l[1] = new Lutador("Putscript", "Brasil", 29, 1.68, 57.8, 14, 2, 3);
        l[2] = new Lutador("Snapshadow", "EUA", 35, 1.65, 80.9, 12, 2, 1);
        l[3] = new Lutador("KanguruJack", "Australia", 28, 1.93, 81.6, 13, 0, 2);
        l[4] = new Lutador("Popó", "Brasil", 37, 1.70, 119.3, 5, 4, 3);
        l[5] = new Lutador("Nerdaard", "EUA", 30, 1.81, 105.7, 12, 2, 4);


        l[0].Apresentar();
        l[0].GanharLuta();
        l[0].Status();

        l[1].Apresentar();
        l[1].GanharLuta();
        l[1].Status();

        l[2].Apresentar();
        l[2].GanharLuta();
        l[2].Status();

        l[3].Apresentar();
        l[3].GanharLuta();
        l[3].Status();

        l[4].Apresentar();
        l[4].GanharLuta();
        l[4].Status();

        l[5].Apresentar();
        l[5].GanharLuta();
        l[5].Status();    }
}