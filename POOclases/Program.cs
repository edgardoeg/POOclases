using POOclases;

Ave ave = new Ave();

ave.Nombre = "Loro";
ave.Especie = "Amazona Aestiva";
ave.Color = "Verde";
ave.Tamano = 30.5;
ave.Habitat = "Bosques tropicales";
ave.Familia.Nombre= "Psittacidae";
ave.Familia.numeroEspecie = 393;
ave.Familia.Caracteristicas = "Aves coloridas, a menudo inteligentes";

ave.Imprimir();

Ave ave2 = new Ave();
ave2.Nombre = "Flamenco";
ave2.Especie = "Phoenicopterus roseus";
ave2.Color = "Rosa";
ave2.Tamano = 0;
ave2.Habitat = "Lagunas salinas";
ave2.Familia.Nombre = "Phoenicopteridae";
ave2.Familia.numeroEspecie = 6;
ave2.Familia.Caracteristicas = "Aves zancudas con patas largas y cuellos largos.";

ave2.Imprimir();
