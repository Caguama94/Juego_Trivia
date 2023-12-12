using JuegoTrivia.Entities;
using System.Threading.Channels;

namespace JuegoTrivia
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Preguntas
            Capitales[] PreguntaCapitales = new Capitales[15];
            PreguntaCapitales[0] = new Capitales("¿Cuál es la capital de Argentina?", "Buenos Aires", "Montevideo", "Santiago", "Lima", "Buenos Aires", "", false);
            PreguntaCapitales[1] = new Capitales("¿Cuál es la capital de Brasil?", "Río de Janeiro", "Brasilia", "Sao Paulo", "Bogotá", "Brasilia", "", false);
            PreguntaCapitales[2] = new Capitales("¿Cuál es la capital de China?", "Shanghai", "Hong Kong", "Beijing", "Taipei", "Beijing", "", false);
            PreguntaCapitales[3] = new Capitales("¿Cuál es la capital de Egipto?", "El Cairo", "Alejandría", "Luxor", "Casablanca", "El Cairo", "", false);
            PreguntaCapitales[4] = new Capitales("¿Cuál es la capital de Francia?", "París", "Marsella", "Lyon", "Burdeos", "París", "", false);
            PreguntaCapitales[5] = new Capitales("¿Cuál es la capital de Grecia?", "Atenas", "Esparta", "Salónica", "Rodas", "Atenas", "", false);
            PreguntaCapitales[6] = new Capitales("¿Cuál es la capital de India?", "Mumbai", "Nueva Delhi", "Bangalore", "Calcuta", "Nueva Delhi", "", false);
            PreguntaCapitales[7] = new Capitales("¿Cuál es la capital de Japón?", "Tokio", "Kioto", "Osaka", "Hiroshima", "Tokio", "", false);
            PreguntaCapitales[8] = new Capitales("¿Cuál es la capital de México?", "Guadalajara", "Monterrey", "Ciudad de México", "Cancún", "Ciudad de México", "", false);
            PreguntaCapitales[9] = new Capitales("¿Cuál es la capital de Noruega?", "Estocolmo", "Oslo", "Copenhague", "Helsinki", "Oslo", "", false);
            PreguntaCapitales[10] = new Capitales("¿Cuál es la capital de Rusia?", "Moscú", "San Petersburgo", "Kiev", "Minsk", "Moscú", "", false);
            PreguntaCapitales[11] = new Capitales("¿Cuál es la capital de Sudáfrica?", "Johannesburgo", "Pretoria", "Ciudad del Cabo", "Durban", "Pretoria", "", false);
            PreguntaCapitales[12] = new Capitales("¿Cuál es la capital de Turquía?", "Estambul", "Ankara", "Izmir", "Antalya", "Ankara", "", false);
            PreguntaCapitales[13] = new Capitales("¿Cuál es la capital de Estados Unidos?", "Nueva York", "Los Ángeles", "Chicago", "Washington D.C.", "Washington D.C.", "", false);
            PreguntaCapitales[14] = new Capitales("¿Cuál es la capital de Vietnam?", "Hanoi", "Ho Chi Minh", "Da Nang", "Phnom Penh", "Hanoi", "", false);
            Historia[] PreguntaHistoria = new Historia[15];
            PreguntaHistoria[0] = new Historia("¿Cuándo ocurrió la Segunda Guerra Mundial?", "1914-1918", "1939-1945", "1950-1953", "1967-1973", "1939-1945", "", false);
            PreguntaHistoria[1] = new Historia("¿Quién fue Cleopatra?", "Una famosa filósofa griega.", "La monarca más joven de Egipto.", "Una destacada científica romana.", "Una reina de la antigua Persia.", "La monarca más joven de Egipto.", "", false);
            PreguntaHistoria[2] = new Historia("¿Cuándo cayó el Muro de Berlín?", "1956", "1989", "1991", "2000", "1989", "", false);
            PreguntaHistoria[3] = new Historia("¿Quién fue Cristóbal Colón?", "Un famoso astrónomo.", "Un explorador vikingo.", "El descubridor de América.", "Un líder militar chino.", "El descubridor de América.", "", false);
            PreguntaHistoria[4] = new Historia("¿Qué es la Guerra Fría?", "Un conflicto bélico entre Estados Unidos y la Unión Soviética.", "Una guerra librada en el Ártico.", "Un enfrentamiento político sin combates directos.", "Una lucha por el control de África.", "Un enfrentamiento político sin combates directos.", "", false);
            PreguntaHistoria[5] = new Historia("¿Cuáles si son algunas de las 7 Maravillas del Mundo Moderno?", "La Torre Eiffel, el Taj Mahal y el Coliseo.", "El Gran Cañón, la Gran Muralla China y el Monte Everest.", "El Coliseo, Machu Picchu y el Cristo Redentor.", "El Taj Mahal, Petra y la Gran Muralla China.", "El Coliseo, Machu Picchu y el Cristo Redentor.", "", false);
            PreguntaHistoria[6] = new Historia("¿Quién fue Vincent van Gogh?", "Un famoso compositor clásico.", "Un pintor postimpresionista.", "Un filósofo renombrado.", "Un científico nuclear.", "Un pintor postimpresionista.", "", false);
            PreguntaHistoria[7] = new Historia("¿Quién fue Isaac Newton?", "Un matemático egipcio.", "Un físico y matemático destacado.", "Un arquitecto famoso.", "Un explorador polar.", "Un físico y matemático destacado.", "", false);
            PreguntaHistoria[8] = new Historia("¿Cuál es la teoría de la Pangea?", "La idea de que la Tierra es plana.", "La teoría de la evolución.", "La hipótesis de la deriva continental.", "La creencia en seres extraterrestres.", "La hipótesis de la deriva continental.", "", false);
            PreguntaHistoria[9] = new Historia("¿Quién fue Amelia Earhart?", "Una astronauta pionera.", "Una aviadora que cruzó el Atlántico en solitario.", "Una exploradora del Ártico.", "Una científica famosa.", "Una aviadora que cruzó el Atlántico en solitario.", "", false);
            PreguntaHistoria[10] = new Historia("¿Cuál fue la causa de la muerte de Julio César?", "Enfermedad cardíaca.", "Envenenamiento.", "Asesinato en el Senado.", "Accidente de carroza", "Asesinato en el Senado.", "", false);
            PreguntaHistoria[11] = new Historia("¿Quién fue Napoleón Bonaparte?", "Un famoso pintor renacentista.", "Un líder militar y emperador francés.", "Un filósofo alemán.", "Un explorador del Ártico.", "Un líder militar y emperador francés.", "", false);
            PreguntaHistoria[12] = new Historia("¿Qué evento histórico marcó el fin de la Edad Media y el inicio de la Edad Moderna?", "La Revolución Industrial.", "La caída del Imperio Romano.", "El Renacimiento.", "La Revolución Francesa.", "El Renacimiento.", "", false);
            PreguntaHistoria[13] = new Historia("¿Cuál fue el imperio más grande de la historia antigua?", "El Imperio Romano.", "El Imperio Persa.", "El Imperio Mongol.", "El Imperio Egipcio.", "El Imperio Mongol.", "", false);
            PreguntaHistoria[14] = new Historia("Quién fue Martin Luther King Jr.?", "Un famoso astronauta.", "Un líder en la lucha por los derechos civiles en Estados Unidos.", "Un inventor de la Revolución Industrial.", "Un explorador del Ártico.", "Un líder en la lucha por los derechos civiles en Estados Unidos.", "", false);
            Peliculas[] PreguntaPeliculas = new Peliculas[15];
            PreguntaPeliculas[0] = new Peliculas("¿Qué película ganó el Oscar a la mejor película en 2020?", "Joker", "1917", "Parásitos", "Érase una vez en Hollywood", "Parásitos", "", false);
            PreguntaPeliculas[1] = new Peliculas("¿Qué actor interpreta a Iron Man en el Universo Cinematográfico de Marvel?", "Chris Hemsworth", "Robert Downey Jr.", "Tom Holland", "Chris Evans", "Robert Downey Jr.", "", false);
            PreguntaPeliculas[2] = new Peliculas("¿Qué película de animación tiene como protagonistas a Woody y Buzz Lightyear?", "Los Increíbles", "Toy Story", "Monstruos S.A.", "Buscando a Nemo", "Toy Story", "", false);
            PreguntaPeliculas[3] = new Peliculas("¿Qué director es conocido por sus películas de terror como El resplandor, La naranja mecánica y 2001: Una odisea del espacio?", "Alfred Hitchcock", "Steven Spielberg", "Stanley Kubrick", "Quentin Tarantino", "Stanley Kubrick", "", false);
            PreguntaPeliculas[4] = new Peliculas("¿Qué película de ciencia ficción se ambienta en el planeta Pandora, donde los humanos intentan explotar los recursos naturales de los nativos llamados Na’vi?", "Avatar", "Star Wars", "Matrix", "Interestelar", "Avatar", "", false);
            PreguntaPeliculas[5] = new Peliculas("¿Qué película musical está basada en el musical de Broadway del mismo nombre y cuenta la historia de un grupo de jóvenes artistas que viven en Nueva York durante la epidemia del SIDA?", "La La Land", "Mamma Mia!", "Rent", "Los miserables", "Rent", "", false);
            PreguntaPeliculas[6] = new Peliculas("¿Qué película de comedia tiene como protagonistas a cuatro amigos que viajan a Las Vegas para celebrar una despedida de soltero y se despiertan al día siguiente sin recordar nada de lo que pasó?", "Resacón en Las Vegas", "Supersalidos", "Zoolander", "Virgen a los 40", "Resacón en Las Vegas", "", false);
            PreguntaPeliculas[7] = new Peliculas("¿Qué película de drama está basada en la novela homónima de Stephen King y narra la amistad entre dos presos condenados a cadena perpetua en una prisión de Estados Unidos?", "La milla verde", "El padrino", "Cadena perpetua", "El silencio de los corderos", "Cadena perpetua", "", false);
            PreguntaPeliculas[8] = new Peliculas("¿Qué película de fantasía está basada en la saga literaria de J.R.R. Tolkien y cuenta la historia de un hobbit llamado Frodo que debe destruir un anillo mágico para salvar al mundo?", "Harry Potter", "El señor de los anillos", "Las crónicas de Narnia", "Juego de tronos", "El señor de los anillos", "", false);
            PreguntaPeliculas[9] = new Peliculas("¿Qué película de animación tiene como protagonista a una princesa escocesa que desafía las tradiciones de su clan y provoca una maldición que amenaza con convertirla en un oso?", "Frozen", "Brave", "Mulan", "Moana", "Brave", "", false);
            PreguntaPeliculas[10] = new Peliculas("¿Qué película de suspense tiene como protagonista a un asesino en serie que secuestra a sus víctimas y las somete a macabros juegos para poner a prueba su voluntad de vivir?", "Saw", "Scream", "Seven", "Psycho", "Saw", "", false);
            PreguntaPeliculas[11] = new Peliculas("¿Qué película de aventuras tiene como protagonista a un arqueólogo llamado Indiana Jones que busca reliquias históricas mientras se enfrenta a nazis, sectas y otras amenazas?", "Jurassic Park", "Indiana Jones", "Tomb Raider", "La momia", "Indiana Jones", "", false);
            PreguntaPeliculas[12] = new Peliculas("¿Qué película de romance tiene como protagonistas a Jack y Rose, dos jóvenes que se enamoran a bordo del Titanic, el barco más lujoso y famoso de su época?", "Titanic", "El diario de Noa", "Pretty Woman", "La La Land", "Titanic", "", false);
            PreguntaPeliculas[13] = new Peliculas("¿Qué película de ciencia ficción tiene como protagonista a Neo, un hacker que descubre que el mundo en el que vive es una simulación creada por máquinas y se une a un grupo de rebeldes para liberar a la humanidad?", "Matrix", "Blade Runner", "El quinto elemento", "Ready Player One", "Matrix", "", false);
            PreguntaPeliculas[14] = new Peliculas("¿Qué película de comedia tiene como protagonista a Borat, un reportero de Kazajistán que viaja a Estados Unidos para hacer un documental sobre la cultura americana y se mete en todo tipo de situaciones absurdas y embarazosas?", "Ali G", "Bruno", "Borat", "The Dictator", "Borat", "", false);
            Musica[] PreguntaMusica = new Musica[15];
            PreguntaMusica[0] = new Musica("¿Qué grupo musical que inició su andadura en los 80 le decía a alguien que nunca había ido a Venus en un barco?", "Mecano", "Los Inhumanos", "Duran Duran", "Rolling Stones", "Mecano", "", false);
            PreguntaMusica[1] = new Musica("¿Qué instrumento de cuerda tiene cuatro cuerdas y se toca con un arco?", "Violín", "Guitarra", "Arpa", "Bajo", "Violín", "", false);
            PreguntaMusica[2] = new Musica("¿Qué género musical se originó en Nueva Orleans a principios del siglo XX y se caracteriza por la improvisación y el ritmo sincopado?", "Blues", "Rock", "Jazz", "Reggae", "Jazz", "", false);
            PreguntaMusica[3] = new Musica("¿Qué cantante colombiana es conocida por éxitos como “Hips Don’t Lie”, “Waka Waka” y “La Tortura”?", "Thalía", "Paulina Rubio", "Shakira", "Jennifer Lopez", "Shakira", "", false);
            PreguntaMusica[4] = new Musica("¿Qué compositor alemán del siglo XVIII se quedó sordo y escribió la famosa Novena Sinfonía?", "Mozart", "Bach", "Beethoven", "Schubert", "Beethoven", "", false);
            PreguntaMusica[5] = new Musica("¿Qué grupo de rock británico formado en 1962 tiene como miembros a Mick Jagger, Keith Richards, Charlie Watts y Ronnie Wood?", "The Beatles", "The Rolling Stones", "Led Zeppelin", "Queen", "The Rolling Stones", "", false);
            PreguntaMusica[6] = new Musica("¿Qué instrumento de viento tiene 47 agujeros y se toca con dos lengüetas atadas entre sí?", "Flauta", "Clarinete", "Saxofón", "Oboe", "Oboe", "", false);
            PreguntaMusica[7] = new Musica("¿Qué género musical se originó en Jamaica en la década de 1960 y se caracteriza por el uso de ritmos acentuados y letras con contenido social o religioso?", "Salsa", "Reggae", "Merengue", "Cumbia", "Reggae", "", false);
            PreguntaMusica[8] = new Musica("¿Qué cantante estadounidense es conocido por éxitos como “Thriller”, “Billie Jean” y “Bad” y por su innovador estilo de baile?", "Michael Jackson", "Prince", "Elvis Presley", "Madonna", "Michael Jackson", "", false);
            PreguntaMusica[9] = new Musica("¿Qué instrumento de percusión tiene forma de reloj de arena y se toca con las manos o con baquetas?", "Tambor", "Bongó", "Timbal", "Conga", "Tambor", "", false);
            PreguntaMusica[10] = new Musica("¿Qué género musical se originó en Estados Unidos en la década de 1950 y se caracteriza por el uso de guitarras eléctricas, batería y letras sobre el amor y la rebeldía juvenil?", "Rock", "Pop", "Hip hop", "Country", "Rock", "", false);
            PreguntaMusica[11] = new Musica("¿Qué cantante mexicana es conocida por éxitos como “Amor a la mexicana”, “Piel morena” y “No me enseñaste”?", "Thalía", "Paulina Rubio", "Gloria Trevi", "Lucero", "Thalía", "", false);
            PreguntaMusica[12] = new Musica("¿Qué compositor italiano del siglo XVII se considera el padre de la ópera y escribió obras como “L’Orfeo” y “L’incoronazione di Poppea”?", "Vivaldi", "Monteverdi", "Verdi", "Puccini", "Monteverdi", "", false);
            PreguntaMusica[13] = new Musica("¿Qué instrumento de teclado tiene 88 teclas y se toca con los dedos y los pies?", "Piano", "Órgano", "Acordeón", "Sintetizador", "Órgano", "", false);
            PreguntaMusica[14] = new Musica("¿Qué género musical se originó en Cuba en la década de 1920 y se caracteriza por el uso de trompetas, timbales y clave?", "Salsa", "Son", "Bolero", "Rumba", "Son", "", false);
            Ciencia[] PreguntaCiencia = new Ciencia[15];
            PreguntaCiencia[0] = new Ciencia("¿Qué es la fotosíntesis?", "El proceso por el cual las plantas producen oxígeno y glucosa a partir de dióxido de carbono y agua.", "El proceso por el cual las plantas producen dióxido de carbono y agua a partir de oxígeno y glucosa.", "El proceso por el cual las plantas producen energía eléctrica a partir de la luz solar.", "El proceso por el cual las plantas producen oxígeno y glucosa a partir de la luz solar y el agua.", "El proceso por el cual las plantas producen oxígeno y glucosa a partir de la luz solar y el agua.", "", false);
            PreguntaCiencia[1] = new Ciencia("¿Qué es un átomo?", "La unidad más pequeña de un elemento químico que conserva sus propiedades.", "La unidad más pequeña de materia que se puede dividir sin perder su identidad.", " La unidad más pequeña de energía que se puede medir.", "La unidad más pequeña de vida que se puede observar.", "La unidad más pequeña de materia que se puede dividir sin perder su identidad.", "", false);
            PreguntaCiencia[2] = new Ciencia("¿Qué es un ADN?", "Una molécula que contiene la información genética de los organismos vivos.", "Una molécula que contiene la información química de los elementos.", "Una molécula que contiene la información eléctrica de los átomos.", "Una molécula que contiene la información genética de los seres vivos.", "Una molécula que contiene la información genética de los seres vivos.", "", false);
            PreguntaCiencia[3] = new Ciencia("¿Qué es una galaxia?", "Un conjunto de estrellas, planetas, asteroides y cometas que orbitan alrededor de un centro común.", "Un conjunto de estrellas, planetas, asteroides y cometas que se mueven al azar en el espacio.", "Un conjunto de estrellas, planetas, gas y polvo que se mantienen unidos por la gravedad.", "Un conjunto de estrellas, planetas, gas y polvo que se alejan unos de otros por la expansión del universo.", "Un conjunto de estrellas, planetas, gas y polvo que se mantienen unidos por la gravedad.", "", false);
            PreguntaCiencia[4] = new Ciencia("¿Qué es una célula?", "La unidad más pequeña de vida que se puede observar.", "La unidad más pequeña de materia que se puede dividir sin perder su identidad.", "La unidad más pequeña de vida que tiene las funciones básicas de los seres vivos.", "La unidad más pequeña de vida que tiene ADN.", "La unidad más pequeña de vida que tiene las funciones básicas de los seres vivos.", "", false);
            PreguntaCiencia[5] = new Ciencia("¿Qué es un volcán?", "Una montaña que tiene una abertura por donde sale lava, ceniza y gases del interior de la Tierra.", "Una montaña que tiene una abertura por donde sale agua, vapor y gases del interior de la Tierra.", "Una montaña que tiene una abertura por donde sale aire, polvo y gases del interior de la Tierra.", "Una montaña que tiene una abertura por donde sale lava, ceniza y gases del interior de la Tierra.", "Una montaña que tiene una abertura por donde sale lava, ceniza y gases del interior de la Tierra.", "", false);
            PreguntaCiencia[6] = new Ciencia("¿Qué es un fósil?", "Un resto o impresión de un organismo vivo que se ha conservado en una roca o en el suelo durante millones de años.", "Un resto o impresión de un organismo vivo que se ha conservado en un ámbar o en el hielo durante millones de años.", "Un resto o impresión de un organismo vivo que se ha conservado en un metal o en el fuego durante millones de años.", "Un resto o impresión de un organismo vivo que se ha conservado en una roca o en el suelo durante millones de años.", "Un resto o impresión de un organismo vivo que se ha conservado en una roca o en el suelo durante millones de años.", "", false);
            PreguntaCiencia[7] = new Ciencia("¿Qué es una fuerza?", "Una acción o reacción que cambia el estado o la forma de un objeto.", "Una acción o reacción que mide el peso o la masa de un objeto.", "Una acción o reacción que genera calor o frío en un objeto.", "Una acción o reacción que cambia el estado o la forma de un objeto.", "Una acción o reacción que cambia el estado o la forma de un objeto.", "", false);
            PreguntaCiencia[8] = new Ciencia("¿Qué es un eclipse?", "Un fenómeno astronómico que ocurre cuando un cuerpo celeste se interpone entre otro y la fuente de luz.", "Un fenómeno astronómico que ocurre cuando un cuerpo celeste se acerca mucho a otro y lo atrae con su gravedad.", "Un fenómeno astronómico que ocurre cuando un cuerpo celeste se aleja mucho de otro y lo repele con su magnetismo.", "Un fenómeno astronómico que ocurre cuando un cuerpo celeste se interpone entre otro y la fuente de luz.", "Un fenómeno astronómico que ocurre cuando un cuerpo celeste se interpone entre otro y la fuente de luz.", "", false);
            PreguntaCiencia[9] = new Ciencia("¿Qué es una bacteria?", "Un organismo unicelular que tiene núcleo y se alimenta de materia orgánica.", "Un organismo pluricelular que no tiene núcleo y se alimenta de materia inorgánica.", "Un organismo unicelular que no tiene núcleo y se alimenta de materia orgánica o inorgánica.", "Un organismo pluricelular que tiene núcleo y se alimenta de materia orgánica o inorgánica.", "Un organismo unicelular que no tiene núcleo y se alimenta de materia orgánica o inorgánica.", "", false);
            PreguntaCiencia[10] = new Ciencia("¿Qué es un imán?", "Un objeto que tiene dos polos opuestos y atrae o repele a otros objetos metálicos.", "Un objeto que tiene dos polos opuestos y atrae o repele a otros objetos magnéticos.", "Un objeto que tiene dos polos iguales y atrae o repele a otros objetos eléctricos.", "Un objeto que tiene dos polos iguales y atrae o repele a otros objetos térmicos.", "Un objeto que tiene dos polos opuestos y atrae o repele a otros objetos magnéticos.", "", false);
            PreguntaCiencia[11] = new Ciencia("¿Qué es un arco iris?", "Una ilusión óptica que se produce cuando la luz del sol se refleja en las gotas de agua en el aire.", "Una ilusión óptica que se produce cuando la luz del sol se refracta en las gotas de agua en el aire.", "Una ilusión óptica que se produce cuando la luz del sol se refleja y se refracta en las gotas de agua en el aire.", "Una ilusión óptica que se produce cuando la luz del sol se difunde en las gotas de agua en el aire.", "Una ilusión óptica que se produce cuando la luz del sol se refleja y se refracta en las gotas de agua en el aire.", "", false);
            PreguntaCiencia[12] = new Ciencia("¿Qué es un terremoto?", "Una sacudida violenta de la superficie terrestre causada por el movimiento de las placas tectónicas.", "Una sacudida violenta de la superficie terrestre causada por el choque de los meteoritos.", "Una sacudida violenta de la superficie terrestre causada por la erupción de los volcanes.", "Una sacudida violenta de la superficie terrestre causada por el movimiento de las placas tectónicas.", "Una sacudida violenta de la superficie terrestre causada por el movimiento de las placas tectónicas.", "", false);
            PreguntaCiencia[13] = new Ciencia("¿Qué es un cometa?", "Un cuerpo celeste formado por hielo, polvo y rocas que orbita alrededor del Sol y tiene una cola luminosa.", "Un cuerpo celeste formado por fuego, gas y cenizas que orbita alrededor de la Tierra y tiene una cola luminosa.", "Un cuerpo celeste formado por metal, cristal y arena que orbita alrededor de la Luna y tiene una cola luminosa.", "Un cuerpo celeste formado por hielo, polvo y rocas que orbita alrededor del Sol y tiene una cola luminosa.", "Un cuerpo celeste formado por hielo, polvo y rocas que orbita alrededor del Sol y tiene una cola luminosa.", "", false);
            PreguntaCiencia[14] = new Ciencia("¿Qué es un hueso?", "Un tejido duro y flexible que forma el esqueleto de los animales vertebrados.", "Un tejido duro y resistente que forma el esqueleto de los animales vertebrados.", "Un tejido blando y elástico que forma el esqueleto de los animales invertebrados.", "Un tejido blando y frágil que forma el esqueleto de los animales invertebrados.", "Un tejido duro y resistente que forma el esqueleto de los animales vertebrados.", "", false);
            //Crear objeto jugador
            Console.WriteLine("Bienvenido a mi juego de trivia");
            Console.WriteLine("Cuantos jugadores van a participar?");
            int NumeroJugadores = Convert.ToInt32(Console.ReadLine());
            Jugador[] Jugador = new Jugador[NumeroJugadores];
            Random random = new Random();
            for (int i = 0; i < NumeroJugadores; i++)
            {
                Console.WriteLine($"Ingresa el nombre del jugador {i + 1}:");
                string NombreJugador = Console.ReadLine();
                int NumeroRandom = random.Next(1, NumeroJugadores);
                Jugador[i] = new Jugador(NombreJugador, NumeroRandom, 3, 0);
            }
            //Verificar Numeros Repetidos
            bool SeRepitenNumeros = false;
            do
            {
                SeRepitenNumeros = false;
                for (int i = 0; i < NumeroJugadores; i++)
                {
                    for (int j = i + 1; j < NumeroJugadores; j++)
                    {
                        if (Jugador[j].Numero == Jugador[i].Numero)
                        {
                            //Console.WriteLine($"El numero cambio de {Jugador[i].Numero}");
                            Jugador[i].Numero = random.Next(1, NumeroJugadores + 1);
                            //Console.WriteLine($"El numero cambio a {Jugador[i].Numero}");
                            SeRepitenNumeros = true;
                        }
                    }
                }
            } while (SeRepitenNumeros);
            //Ordenar Jugadores
            List<Jugador> JugadoresOrdenados = new List<Jugador>(Jugador);
            JugadoresOrdenados.Sort(delegate (Jugador x, Jugador y)
            {
                return x.Numero.CompareTo(y.Numero);
            });
            for (int i = 0; i < NumeroJugadores; i++)
            {
                Console.WriteLine($"El jugador {i + 1} es: {JugadoresOrdenados[i].Nombre}, tiene {JugadoresOrdenados[i].Puntuacion} puntos y {JugadoresOrdenados[i].Comodines} comodines");
            }
            //Rondas de preguntas
            Console.WriteLine("Cuantas rondas quieren jugar?");
            int Rondas = Convert.ToInt32(Console.ReadLine());
            Rondas = Rondas * NumeroJugadores;
            int n = 0;
            int ji = 0;
            do
            {
                Console.WriteLine("Es el turno de:" + JugadoresOrdenados[ji].Nombre);
                //Escoger el topico
                Console.WriteLine("\nIngresa el topico de la pregunta que quieras responder");
                Console.Write("\nC (Capitales)\n" + "H (Historia)\n" + "P (Peliculas)\n" + "M (Musica)\n" + "S (Ciencia)\n");
                string Topico = Console.ReadLine();
                if (Topico == "c") { Console.WriteLine($"Escogiste Capitales\n" + "Aqui esta la pregunta:"); }
                else if (Topico == "h") { Console.WriteLine($"Escogiste Historia\n" + "Aqui esta la pregunta:"); }
                else if (Topico == "p") { Console.WriteLine($"Escogiste Peliculas\n" + "Aqui esta la pregunta:"); }
                else if (Topico == "m") { Console.WriteLine($"Escogiste Musica\n" + "Aqui esta la pregunta:"); }
                else if (Topico == "s") { Console.WriteLine($"Escogiste Ciencia\n" + "Aqui esta la pregunta:"); }
                else { }
                //switch de topicos 
                int PreguntaIndex = 0;
                switch (Topico.ToLower())
                {
                    case "c":
                        for (int i = 0; i < PreguntaCapitales.Length; i++)
                        {
                            if (PreguntaCapitales[i].YaSePregunto == false)
                            {
                                PreguntaIndex = i;
                                break;
                            }
                            else { }
                        }
                        if (JugadoresOrdenados[ji].Comodines > 0)
                        {
                            Console.WriteLine(PreguntaCapitales[PreguntaIndex].FormarPreguntaConComodin());
                            PreguntaCapitales[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            if (PreguntaCapitales[PreguntaIndex].OpcionJugador == "e")
                            {
                                Console.WriteLine(JugadoresOrdenados[ji].UsarComodines());
                                Console.WriteLine(PreguntaCapitales[PreguntaIndex].FormarPreguntaComodin());
                                PreguntaCapitales[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                                PreguntaCapitales[PreguntaIndex].OpcionJugador = PreguntaCapitales[PreguntaIndex].SwitchRespuesta(PreguntaCapitales[PreguntaIndex].OpcionJugador);
                            }
                            else
                            {
                                PreguntaCapitales[PreguntaIndex].OpcionJugador = PreguntaCapitales[PreguntaIndex].SwitchRespuesta(PreguntaCapitales[PreguntaIndex].OpcionJugador);
                            }
                        }
                        else
                        {
                            Console.WriteLine(PreguntaCapitales[PreguntaIndex].FormarPreguntaSinComodin());
                            PreguntaCapitales[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                            PreguntaCapitales[PreguntaIndex].OpcionJugador = PreguntaCapitales[PreguntaIndex].SwitchRespuesta(PreguntaCapitales[PreguntaIndex].OpcionJugador);
                        }
                        //validacion respuesta correcta o incorrecta
                        if (PreguntaCapitales[PreguntaIndex].OpcionJugador == PreguntaCapitales[PreguntaIndex].OpcionCorrecta)
                        {
                            Console.WriteLine(PreguntaCapitales[PreguntaIndex].Acertaste());
                            //Puntos
                            Console.WriteLine(JugadoresOrdenados[ji].Acierto3Puntos());
                        }
                        else
                        {
                            Console.WriteLine(PreguntaCapitales[PreguntaIndex].SegundoIntento());
                            Console.WriteLine(PreguntaCapitales[PreguntaIndex].FormarPreguntaSegundoIntento());
                            PreguntaCapitales[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            PreguntaCapitales[PreguntaIndex].OpcionJugador = PreguntaCapitales[PreguntaIndex].SwitchRespuesta(PreguntaCapitales[PreguntaIndex].OpcionJugador);
                            if (PreguntaCapitales[PreguntaIndex].OpcionJugador == PreguntaCapitales[PreguntaIndex].OpcionCorrecta)
                            {
                                Console.WriteLine(PreguntaCapitales[PreguntaIndex].Acertaste());
                                //Puntos
                                Console.WriteLine(JugadoresOrdenados[ji].Acierto1Punto());
                            }
                            else
                            {
                                Console.WriteLine($"Fallaste, la respuesta correcta era:\n" + PreguntaCapitales[PreguntaIndex].OpcionCorrecta);
                            }
                        };
                        break;
                    case "h":
                        for (int i = 0; i < PreguntaHistoria.Length; i++)
                        {
                            if (PreguntaHistoria[i].YaSePregunto == false)
                            {
                                PreguntaIndex = i;
                                break;
                            }
                            else { }
                        }
                        if (JugadoresOrdenados[ji].Comodines > 0)
                        {
                            Console.WriteLine(PreguntaHistoria[PreguntaIndex].FormarPreguntaConComodin());
                            PreguntaHistoria[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            if (PreguntaHistoria[PreguntaIndex].OpcionJugador == "e")
                            {
                                Console.WriteLine(JugadoresOrdenados[ji].UsarComodines());
                                Console.WriteLine(PreguntaHistoria[PreguntaIndex].FormarPreguntaComodin());
                                PreguntaHistoria[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                                PreguntaHistoria[PreguntaIndex].OpcionJugador = PreguntaHistoria[PreguntaIndex].SwitchRespuesta(PreguntaHistoria[PreguntaIndex].OpcionJugador);
                            }
                            else
                            {
                                PreguntaHistoria[PreguntaIndex].OpcionJugador = PreguntaHistoria[PreguntaIndex].SwitchRespuesta(PreguntaHistoria[PreguntaIndex].OpcionJugador);
                            }
                        }
                        else
                        {
                            Console.WriteLine(PreguntaHistoria[PreguntaIndex].FormarPreguntaSinComodin());
                            PreguntaHistoria[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                            PreguntaHistoria[PreguntaIndex].OpcionJugador = PreguntaHistoria[PreguntaIndex].SwitchRespuesta(PreguntaHistoria[PreguntaIndex].OpcionJugador);
                        }
                        //validacion respuesta correcta o incorrecta
                        if (PreguntaHistoria[PreguntaIndex].OpcionJugador == PreguntaHistoria[PreguntaIndex].OpcionCorrecta)
                        {
                            Console.WriteLine(PreguntaHistoria[PreguntaIndex].Acertaste());
                            //Puntos
                            Console.WriteLine(JugadoresOrdenados[ji].Acierto3Puntos());
                        }
                        else
                        {
                            Console.WriteLine(PreguntaHistoria[PreguntaIndex].SegundoIntento());
                            Console.WriteLine(PreguntaHistoria[PreguntaIndex].FormarPreguntaSegundoIntento());
                            PreguntaHistoria[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            PreguntaHistoria[PreguntaIndex].OpcionJugador = PreguntaHistoria[PreguntaIndex].SwitchRespuesta(PreguntaHistoria[PreguntaIndex].OpcionJugador);
                            if (PreguntaHistoria[PreguntaIndex].OpcionJugador == PreguntaHistoria[PreguntaIndex].OpcionCorrecta)
                            {
                                Console.WriteLine(PreguntaHistoria[PreguntaIndex].Acertaste());
                                //Puntos
                                Console.WriteLine(JugadoresOrdenados[ji].Acierto1Punto());
                            }
                            else
                            {
                                Console.WriteLine($"Fallaste, la respuesta correcta era:\n" + PreguntaHistoria[PreguntaIndex].OpcionCorrecta);
                            }
                        };
                        break;
                    case "p":
                        for (int i = 0; i < PreguntaPeliculas.Length; i++)
                        {
                            if (PreguntaPeliculas[i].YaSePregunto == false)
                            {
                                PreguntaIndex = i;
                                break;
                            }
                            else { }
                        }
                        if (JugadoresOrdenados[ji].Comodines > 0)
                        {
                            Console.WriteLine(PreguntaPeliculas[PreguntaIndex].FormarPreguntaConComodin());
                            PreguntaPeliculas[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            if (PreguntaPeliculas[PreguntaIndex].OpcionJugador == "e")
                            {
                                Console.WriteLine(JugadoresOrdenados[ji].UsarComodines());
                                Console.WriteLine(PreguntaPeliculas[PreguntaIndex].FormarPreguntaComodin());
                                PreguntaPeliculas[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                                PreguntaPeliculas[PreguntaIndex].OpcionJugador = PreguntaPeliculas[PreguntaIndex].SwitchRespuesta(PreguntaPeliculas[PreguntaIndex].OpcionJugador);
                            }
                            else
                            {
                                PreguntaPeliculas[PreguntaIndex].OpcionJugador = PreguntaPeliculas[PreguntaIndex].SwitchRespuesta(PreguntaPeliculas[PreguntaIndex].OpcionJugador);
                            }
                        }
                        else
                        {
                            Console.WriteLine(PreguntaPeliculas[PreguntaIndex].FormarPreguntaSinComodin());
                            PreguntaPeliculas[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                            PreguntaPeliculas[PreguntaIndex].OpcionJugador = PreguntaPeliculas[PreguntaIndex].SwitchRespuesta(PreguntaPeliculas[PreguntaIndex].OpcionJugador);
                        }
                        //validacion respuesta correcta o incorrecta
                        if (PreguntaPeliculas[PreguntaIndex].OpcionJugador == PreguntaPeliculas[PreguntaIndex].OpcionCorrecta)
                        {
                            Console.WriteLine(PreguntaPeliculas[PreguntaIndex].Acertaste());
                            //Puntos
                            Console.WriteLine(JugadoresOrdenados[ji].Acierto3Puntos());
                        }
                        else
                        {
                            Console.WriteLine(PreguntaPeliculas[PreguntaIndex].SegundoIntento());
                            Console.WriteLine(PreguntaPeliculas[PreguntaIndex].FormarPreguntaSegundoIntento());
                            PreguntaPeliculas[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            PreguntaPeliculas[PreguntaIndex].OpcionJugador = PreguntaPeliculas[PreguntaIndex].SwitchRespuesta(PreguntaPeliculas[PreguntaIndex].OpcionJugador);
                            if (PreguntaPeliculas[PreguntaIndex].OpcionJugador == PreguntaPeliculas[PreguntaIndex].OpcionCorrecta)
                            {
                                Console.WriteLine(PreguntaPeliculas[PreguntaIndex].Acertaste());
                                //Puntos
                                Console.WriteLine(JugadoresOrdenados[ji].Acierto1Punto());
                            }
                            else
                            {
                                Console.WriteLine($"Fallaste, la respuesta correcta era:\n" + PreguntaPeliculas[PreguntaIndex].OpcionCorrecta);
                            }
                        };
                        break;
                    case "m":
                        for (int i = 0; i < PreguntaMusica.Length; i++)
                        {
                            if (PreguntaMusica[i].YaSePregunto == false)
                            {
                                PreguntaIndex = i;
                                break;
                            }
                            else { }
                        }
                        if (JugadoresOrdenados[ji].Comodines > 0)
                        {
                            Console.WriteLine(PreguntaMusica[PreguntaIndex].FormarPreguntaConComodin());
                            PreguntaMusica[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            if (PreguntaMusica[PreguntaIndex].OpcionJugador == "e")
                            {
                                Console.WriteLine(JugadoresOrdenados[ji].UsarComodines());
                                Console.WriteLine(PreguntaMusica[PreguntaIndex].FormarPreguntaComodin());
                                PreguntaMusica[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                                PreguntaMusica[PreguntaIndex].OpcionJugador = PreguntaMusica[PreguntaIndex].SwitchRespuesta(PreguntaMusica[PreguntaIndex].OpcionJugador);
                            }
                            else
                            {
                                PreguntaMusica[PreguntaIndex].OpcionJugador = PreguntaMusica[PreguntaIndex].SwitchRespuesta(PreguntaMusica[PreguntaIndex].OpcionJugador);
                            }
                        }
                        else
                        {
                            Console.WriteLine(PreguntaMusica[PreguntaIndex].FormarPreguntaSinComodin());
                            PreguntaMusica[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                            PreguntaMusica[PreguntaIndex].OpcionJugador = PreguntaMusica[PreguntaIndex].SwitchRespuesta(PreguntaMusica[PreguntaIndex].OpcionJugador);
                        }
                        //validacion respuesta correcta o incorrecta
                        if (PreguntaMusica[PreguntaIndex].OpcionJugador == PreguntaMusica[PreguntaIndex].OpcionCorrecta)
                        {
                            Console.WriteLine(PreguntaMusica[PreguntaIndex].Acertaste());
                            //Puntos
                            Console.WriteLine(JugadoresOrdenados[ji].Acierto3Puntos());
                        }
                        else
                        {
                            Console.WriteLine(PreguntaMusica[PreguntaIndex].SegundoIntento());
                            Console.WriteLine(PreguntaMusica[PreguntaIndex].FormarPreguntaSegundoIntento());
                            PreguntaMusica[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            PreguntaMusica[PreguntaIndex].OpcionJugador = PreguntaMusica[PreguntaIndex].SwitchRespuesta(PreguntaMusica[PreguntaIndex].OpcionJugador);
                            if (PreguntaMusica[PreguntaIndex].OpcionJugador == PreguntaMusica[PreguntaIndex].OpcionCorrecta)
                            {
                                Console.WriteLine(PreguntaMusica[PreguntaIndex].Acertaste());
                                //Puntos
                                Console.WriteLine(JugadoresOrdenados[ji].Acierto1Punto());
                            }
                            else
                            {
                                Console.WriteLine($"Fallaste, la respuesta correcta era:\n" + PreguntaMusica[PreguntaIndex].OpcionCorrecta);
                            }
                        };
                        break;
                    case "s":
                        for (int i = 0; i < PreguntaCiencia.Length; i++)
                        {
                            if (PreguntaCiencia[i].YaSePregunto == false)
                            {
                                PreguntaIndex = i;
                                break;
                            }
                            else { }
                        }
                        if (JugadoresOrdenados[ji].Comodines > 0)
                        {
                            Console.WriteLine(PreguntaCiencia[PreguntaIndex].FormarPreguntaConComodin());
                            PreguntaCiencia[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            if (PreguntaCiencia[PreguntaIndex].OpcionJugador == "e")
                            {
                                Console.WriteLine(JugadoresOrdenados[ji].UsarComodines());
                                Console.WriteLine(PreguntaCiencia[PreguntaIndex].FormarPreguntaComodin());
                                PreguntaCiencia[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                                PreguntaCiencia[PreguntaIndex].OpcionJugador = PreguntaCiencia[PreguntaIndex].SwitchRespuesta(PreguntaCiencia[PreguntaIndex].OpcionJugador);
                            }
                            else
                            {
                                PreguntaCiencia[PreguntaIndex].OpcionJugador = PreguntaCiencia[PreguntaIndex].SwitchRespuesta(PreguntaCiencia[PreguntaIndex].OpcionJugador);
                            }
                        }
                        else
                        {
                            Console.WriteLine(PreguntaCiencia[PreguntaIndex].FormarPreguntaSinComodin());
                            PreguntaCiencia[PreguntaIndex].OpcionJugador = Console.ReadLine().ToLower();
                            PreguntaCiencia[PreguntaIndex].OpcionJugador = PreguntaCiencia[PreguntaIndex].SwitchRespuesta(PreguntaCiencia[PreguntaIndex].OpcionJugador);
                        }
                        //validacion respuesta correcta o incorrecta
                        if (PreguntaCiencia[PreguntaIndex].OpcionJugador == PreguntaCiencia[PreguntaIndex].OpcionCorrecta)
                        {
                            Console.WriteLine(PreguntaCiencia[PreguntaIndex].Acertaste());
                            //Puntos
                            Console.WriteLine(JugadoresOrdenados[ji].Acierto3Puntos());
                        }
                        else
                        {
                            Console.WriteLine(PreguntaCiencia[PreguntaIndex].SegundoIntento());
                            Console.WriteLine(PreguntaCiencia[PreguntaIndex].FormarPreguntaSegundoIntento());
                            PreguntaCiencia[PreguntaIndex].OpcionJugador = Console.ReadLine();
                            PreguntaCiencia[PreguntaIndex].OpcionJugador = PreguntaCiencia[PreguntaIndex].SwitchRespuesta(PreguntaCiencia[PreguntaIndex].OpcionJugador);
                            if (PreguntaCiencia[PreguntaIndex].OpcionJugador == PreguntaCiencia[PreguntaIndex].OpcionCorrecta)
                            {
                                Console.WriteLine(PreguntaCiencia[PreguntaIndex].Acertaste());
                                //Puntos
                                Console.WriteLine(JugadoresOrdenados[ji].Acierto1Punto());
                            }
                            else
                            {
                                Console.WriteLine($"Fallaste, la respuesta correcta era:\n" + PreguntaCiencia[PreguntaIndex].OpcionCorrecta);
                            }
                        };
                        break;
                }
                if (ji == NumeroJugadores - 1)
                { ji = 0; }
                else { ji++; }
                n++;
            } while (n < Rondas);

            //Suma de comodines
            for (int i = 0; i < NumeroJugadores; i++)
            { JugadoresOrdenados[i].Puntuacion = JugadoresOrdenados[i].Puntuacion + (JugadoresOrdenados[i].Comodines * 1); }
            //Lista Puntuacion
            List<Jugador> JugadoresPuntuacion = new List<Jugador>(Jugador);
            JugadoresPuntuacion.Sort(delegate (Jugador x, Jugador y)
            { return x.Puntuacion.CompareTo(y.Puntuacion); });
            //Mostrar Lista de ganadores
            Console.WriteLine("La puntuacion es la siguiente:");
            for (int i = 0; i < NumeroJugadores; i++)
            { Console.WriteLine($"{i + 1} {JugadoresPuntuacion[i].Nombre} con {JugadoresPuntuacion[i].Puntuacion}"); }
            Console.WriteLine("Felicidades a los ganadores");

            //For que valide que no se ha preguntado la pregunta--ya

            //Metodo del topico que escribe la pregunta y respuestas--ya

            //Responder pregunta 1er intento o usar comodin--ya

            //Si uso comodin restar 1 comodin al jugador[i] y quitar una respuesta incorrecta de pregunta[i]--ya

            //Validar respuesta--ya

            //Cambiar atributo del objeto[i].Yasepregunto a  true--ya

            //Vontinuar con siguiente topico o segundo intento de respuesta--ya

            //Sumar puntuaciones y decidir ganador o ronda de desempate

            //Mandar todo a metodos--ya


            //EXTRA!!
            //Añadir random a que preguntas aparecen segun el topico seleccionado y que las opciones cambien de lugar
        }
    }
}