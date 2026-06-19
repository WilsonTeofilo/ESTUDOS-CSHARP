
using POOEXS;

Lutador[] Fighter = new Lutador[4];

Fighter[0] = new Lutador("Charles do Bronx", "Brasil", 36, 1.75f, 34, 9, 0, 71.40f);
Fighter[1] = new Lutador("Ilia Topuria", "Espanha", 29, 1.70f, 17, 1, 0, 73.55f);
Fighter[2] = new Lutador("Guilherme Hegeler", "Brasil", 62, 1.84f, 23, 0, 2, 81.02f);
Fighter[3] = new Lutador("Wilson Teofilo", "Brasil", 71, 1.79f, 22, 0, 2, 80.22f);


Luta Lutas = new Luta();
Lutas.marcarLuta(Fighter[0], Fighter[1], 3);
await Lutas.Lutar();
