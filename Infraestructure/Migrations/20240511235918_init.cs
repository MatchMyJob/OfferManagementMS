using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 1, "Argentina" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 2, 1, "Ciudad Autónoma de Buenos Aires" },
                    { 6, 1, "Buenos Aires" },
                    { 10, 1, "Catamarca" },
                    { 14, 1, "Cordoba" },
                    { 18, 1, "Corrientes" },
                    { 22, 1, "Chaco" },
                    { 26, 1, "Chubut" },
                    { 30, 1, "Entre Rios" },
                    { 34, 1, "Formosa" },
                    { 38, 1, "Jujuy" },
                    { 42, 1, "La Pampa" },
                    { 46, 1, "La Rioja" },
                    { 50, 1, "Mendoza" },
                    { 54, 1, "Misiones" },
                    { 58, 1, "Neuquen" },
                    { 62, 1, "Rio Negro" },
                    { 66, 1, "Salta" },
                    { 70, 1, "San Juan" },
                    { 74, 1, "San Luis" },
                    { 82, 1, "Santa Fe" },
                    { 90, 1, "Tucuman" },
                    { 94, 1, "Tierra Del Fuego" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 22007, "Comuna 1", 2 },
                    { 22014, "Comuna 2", 2 },
                    { 22021, "Comuna 3", 2 },
                    { 22028, "Comuna 4", 2 },
                    { 22035, "Comuna 5", 2 },
                    { 22042, "Comuna 6", 2 },
                    { 22049, "Comuna 7", 2 },
                    { 22056, "Comuna 8", 2 },
                    { 22063, "Comuna 9", 2 },
                    { 22070, "Comuna 10", 2 },
                    { 22077, "Comuna 11", 2 },
                    { 22084, "Comuna 12", 2 },
                    { 22091, "Comuna 13", 2 },
                    { 22098, "Comuna 14", 2 },
                    { 22105, "Comuna 15", 2 },
                    { 60007, "Adolfo Alsina", 6 },
                    { 60014, "Adolfo Gonzales Chaves", 6 },
                    { 60021, "Alberti", 6 },
                    { 60028, "Almirante Brown", 6 },
                    { 60035, "Avellaneda", 6 },
                    { 60042, "Ayacucho", 6 },
                    { 60049, "Azul", 6 },
                    { 60056, "Bahía Blanca", 6 },
                    { 60063, "Balcarce", 6 },
                    { 60070, "Baradero", 6 },
                    { 60077, "Arrecifes", 6 },
                    { 60084, "Benito Juárez", 6 },
                    { 60091, "Berazategui", 6 },
                    { 60098, "Berisso", 6 },
                    { 60105, "Bolívar", 6 },
                    { 60112, "Bragado", 6 },
                    { 60119, "Brandsen", 6 },
                    { 60126, "Campana", 6 },
                    { 60134, "Cañuelas", 6 },
                    { 60140, "Capitán Sarmiento", 6 },
                    { 60147, "Carlos Casares", 6 },
                    { 60154, "Carlos Tejedor", 6 },
                    { 60161, "Carmen de Areco", 6 },
                    { 60168, "Castelli", 6 },
                    { 60175, "Colón", 6 },
                    { 60182, "Coronel de Marina Leonardo Rosales", 6 },
                    { 60189, "Coronel Dorrego", 6 },
                    { 60196, "Coronel Pringles", 6 },
                    { 60203, "Coronel Suárez", 6 },
                    { 60210, "Chacabuco", 6 },
                    { 60218, "Chascomús", 6 },
                    { 60224, "Chivilcoy", 6 },
                    { 60231, "Daireaux", 6 },
                    { 60238, "Dolores", 6 },
                    { 60245, "Ensenada", 6 },
                    { 60252, "Escobar", 6 },
                    { 60260, "Esteban Echeverría", 6 },
                    { 60266, "Exaltación de la Cruz", 6 },
                    { 60270, "Ezeiza", 6 },
                    { 60274, "Florencio Varela", 6 },
                    { 60277, "Florencio Ameghino", 6 },
                    { 60280, "General Alvarado", 6 },
                    { 60287, "General Alvear", 6 },
                    { 60294, "General Arenales", 6 },
                    { 60301, "General Belgrano", 6 },
                    { 60308, "General Guido", 6 },
                    { 60315, "General Juan Madariaga", 6 },
                    { 60322, "General La Madrid", 6 },
                    { 60329, "General Las Heras", 6 },
                    { 60336, "General Lavalle", 6 },
                    { 60343, "General Paz", 6 },
                    { 60351, "General Pinto", 6 },
                    { 60357, "General Pueyrredón", 6 },
                    { 60364, "General Rodríguez", 6 },
                    { 60371, "General San Martín", 6 },
                    { 60385, "General Viamonte", 6 },
                    { 60392, "General Villegas", 6 },
                    { 60399, "Guaminí", 6 },
                    { 60406, "Hipólito Yrigoyen", 6 },
                    { 60408, "Hurlingham", 6 },
                    { 60410, "Ituzaingó", 6 },
                    { 60412, "José C. Paz", 6 },
                    { 60413, "Junín", 6 },
                    { 60420, "La Costa", 6 },
                    { 60427, "La Matanza", 6 },
                    { 60434, "Lanús", 6 },
                    { 60441, "La Plata", 6 },
                    { 60448, "Laprida", 6 },
                    { 60455, "Las Flores", 6 },
                    { 60462, "Leandro N. Alem", 6 },
                    { 60466, "Lezama", 6 },
                    { 60469, "Lincoln", 6 },
                    { 60476, "Lobería", 6 },
                    { 60483, "Lobos", 6 },
                    { 60490, "Lomas de Zamora", 6 },
                    { 60497, "Luján", 6 },
                    { 60505, "Magdalena", 6 },
                    { 60511, "Maipú", 6 },
                    { 60515, "Malvinas Argentinas", 6 },
                    { 60518, "Mar Chiquita", 6 },
                    { 60525, "Marcos Paz", 6 },
                    { 60532, "Mercedes", 6 },
                    { 60539, "Merlo", 6 },
                    { 60547, "Monte", 6 },
                    { 60553, "Monte Hermoso", 6 },
                    { 60560, "Moreno", 6 },
                    { 60568, "Morón", 6 },
                    { 60574, "Navarro", 6 },
                    { 60581, "Necochea", 6 },
                    { 60588, "9 de Julio", 6 },
                    { 60595, "Olavarría", 6 },
                    { 60602, "Patagones", 6 },
                    { 60609, "Pehuajó", 6 },
                    { 60616, "Pellegrini", 6 },
                    { 60623, "Pergamino", 6 },
                    { 60630, "Pila", 6 },
                    { 60638, "Pilar", 6 },
                    { 60644, "Pinamar", 6 },
                    { 60648, "Presidente Perón", 6 },
                    { 60651, "Puán", 6 },
                    { 60655, "Punta Indio", 6 },
                    { 60658, "Quilmes", 6 },
                    { 60665, "Ramallo", 6 },
                    { 60672, "Rauch", 6 },
                    { 60679, "Rivadavia", 6 },
                    { 60686, "Rojas", 6 },
                    { 60693, "Roque Pérez", 6 },
                    { 60700, "Saavedra", 6 },
                    { 60707, "Saladillo", 6 },
                    { 60714, "Salto", 6 },
                    { 60721, "Salliqueló", 6 },
                    { 60728, "San Andrés de Giles", 6 },
                    { 60735, "San Antonio de Areco", 6 },
                    { 60742, "San Cayetano", 6 },
                    { 60749, "San Fernando", 6 },
                    { 60756, "San Isidro", 6 },
                    { 60760, "San Miguel", 6 },
                    { 60763, "San Nicolás", 6 },
                    { 60770, "San Pedro", 6 },
                    { 60778, "San Vicente", 6 },
                    { 60784, "Suipacha", 6 },
                    { 60791, "Tandil", 6 },
                    { 60798, "Tapalqué", 6 },
                    { 60805, "Tigre", 6 },
                    { 60812, "Tordillo", 6 },
                    { 60819, "Tornquist", 6 },
                    { 60826, "Trenque Lauquen", 6 },
                    { 60833, "Tres Arroyos", 6 },
                    { 60840, "Tres de Febrero", 6 },
                    { 60847, "Tres Lomas", 6 },
                    { 60854, "25 de Mayo", 6 },
                    { 60861, "Vicente López", 6 },
                    { 60868, "Villa Gesell", 6 },
                    { 60875, "Villarino", 6 },
                    { 60882, "Zárate", 6 },
                    { 100007, "El Rodeo", 10 },
                    { 100014, "La Puerta", 10 },
                    { 100021, "Las Juntas", 10 },
                    { 100028, "Los Varela", 10 },
                    { 100035, "Ancasti", 10 },
                    { 100042, "Aconquija", 10 },
                    { 100049, "Andalgalá", 10 },
                    { 100056, "Antofagasta de la Sierra", 10 },
                    { 100063, "Belén", 10 },
                    { 100070, "Corral Quemado", 10 },
                    { 100077, "Hualfín", 10 },
                    { 100084, "Londres", 10 },
                    { 100091, "Pozo de Piedra", 10 },
                    { 100098, "Puerta de Corral Quemado", 10 },
                    { 100105, "Puerta de San José", 10 },
                    { 100112, "San Fernando", 10 },
                    { 100119, "Villa Vil", 10 },
                    { 100126, "Capayán", 10 },
                    { 100133, "Huillapima", 10 },
                    { 100140, "San Fernando del Valle de Catamarca", 10 },
                    { 100147, "El Alto", 10 },
                    { 100154, "Tapso", 10 },
                    { 100161, "Fray Mamerto Esquiú", 10 },
                    { 100168, "Icaño", 10 },
                    { 100175, "Recreo", 10 },
                    { 100182, "Paclín", 10 },
                    { 100185, "Mutquin", 10 },
                    { 100189, "Pomán", 10 },
                    { 100196, "Saujil", 10 },
                    { 100203, "San José", 10 },
                    { 100210, "Santa María", 10 },
                    { 100213, "Los Altos", 10 },
                    { 100217, "Santa Rosa", 10 },
                    { 100224, "Fiambalá", 10 },
                    { 100231, "Tinogasta", 10 },
                    { 100238, "Valle Viejo", 10 },
                    { 140007, "Embalse", 14 },
                    { 140014, "La Cruz", 14 },
                    { 140021, "Los Cóndores", 14 },
                    { 140028, "Río de los Sauces", 14 },
                    { 140035, "Santa Rosa de Calamuchita", 14 },
                    { 140042, "Villa del Dique", 14 },
                    { 140049, "Villa General Belgrano", 14 },
                    { 140056, "San Agustín", 14 },
                    { 140063, "Villa Rumipal", 14 },
                    { 140070, "Villa Yacanto", 14 },
                    { 140077, "Córdoba", 14 },
                    { 140084, "Agua de Oro", 14 },
                    { 140091, "Colonia Caroya", 14 },
                    { 140098, "Colonia Tirolesa", 14 },
                    { 140102, "Estación General Paz", 14 },
                    { 140105, "Estación Juárez Celman", 14 },
                    { 140112, "Jesús María", 14 },
                    { 140119, "La Calera", 14 },
                    { 140126, "La Granja", 14 },
                    { 140133, "Malvinas Argentinas", 14 },
                    { 140140, "Mendiolaza", 14 },
                    { 140143, "Mi Granja", 14 },
                    { 140147, "Río Ceballos", 14 },
                    { 140154, "Saldán", 14 },
                    { 140161, "Salsipuedes", 14 },
                    { 140168, "Unquillo", 14 },
                    { 140175, "Villa Allende", 14 },
                    { 140182, "Cruz del Eje", 14 },
                    { 140185, "El Brete", 14 },
                    { 140189, "San Marcos Sierra", 14 },
                    { 140196, "Serrezuela", 14 },
                    { 140203, "Villa de Soto", 14 },
                    { 140210, "Buchardo", 14 },
                    { 140217, "Del Campillo", 14 },
                    { 140224, "Huinca Renancó", 14 },
                    { 140231, "Italó", 14 },
                    { 140238, "Jovita", 14 },
                    { 140245, "Mattaldi", 14 },
                    { 140252, "Villa Huidobro", 14 },
                    { 140259, "Villa Valeria", 14 },
                    { 140266, "Arroyo Algodón", 14 },
                    { 140273, "Arroyo Cabral", 14 },
                    { 140280, "Ausonia", 14 },
                    { 140287, "Chazón", 14 },
                    { 140294, "Etruria", 14 },
                    { 140301, "La Laguna", 14 },
                    { 140308, "La Palestina", 14 },
                    { 140315, "La Playosa", 14 },
                    { 140322, "Luca", 14 },
                    { 140329, "Pasco", 14 },
                    { 140336, "Silvio Pellico", 14 },
                    { 140343, "Ticino", 14 },
                    { 140350, "Tío Pujio", 14 },
                    { 140357, "Villa María", 14 },
                    { 140364, "Villa Nueva", 14 },
                    { 140371, "Deán Funes", 14 },
                    { 140378, "Quilino", 14 },
                    { 140385, "Alejandro Roca", 14 },
                    { 140392, "Bengolea", 14 },
                    { 140399, "Carnerillo", 14 },
                    { 140406, "Charras", 14 },
                    { 140413, "General Cabrera", 14 },
                    { 140420, "General Deheza", 14 },
                    { 140427, "Huanchilla", 14 },
                    { 140434, "La Carlota", 14 },
                    { 140441, "Los Cisnes", 14 },
                    { 140448, "Olaeta", 14 },
                    { 140455, "Reducción", 14 },
                    { 140462, "Santa Eufemia", 14 },
                    { 140469, "Ucacha", 14 },
                    { 140476, "Alejo Ledesma", 14 },
                    { 140483, "Arias", 14 },
                    { 140490, "Camilo Aldao", 14 },
                    { 140497, "Capitán General Bernardo O'Higgins", 14 },
                    { 140504, "Cavanagh", 14 },
                    { 140511, "Colonia Italiana", 14 },
                    { 140518, "Corral de Bustos Ifflinger", 14 },
                    { 140525, "Cruz Alta", 14 },
                    { 140532, "General Baldissera", 14 },
                    { 140539, "General Roca", 14 },
                    { 140546, "Guatimozín", 14 },
                    { 140553, "Inriville", 14 },
                    { 140560, "Isla Verde", 14 },
                    { 140567, "Leones", 14 },
                    { 140574, "Los Surgentes", 14 },
                    { 140581, "Marcos Juárez", 14 },
                    { 140588, "Monte Buey", 14 },
                    { 140595, "Saira", 14 },
                    { 140602, "San Carlos Minas", 14 },
                    { 140609, "Salsacate", 14 },
                    { 140616, "General Levalle", 14 },
                    { 140623, "La Cesira", 14 },
                    { 140630, "Laboulaye", 14 },
                    { 140637, "Melo", 14 },
                    { 140644, "Rosales", 14 },
                    { 140651, "Serrano", 14 },
                    { 140658, "Villa Rossi", 14 },
                    { 140665, "Bialet Massé", 14 },
                    { 140672, "Capilla del Monte", 14 },
                    { 140679, "Cosquín", 14 },
                    { 140686, "Huerta Grande", 14 },
                    { 140693, "La Cumbre", 14 },
                    { 140700, "La Falda", 14 },
                    { 140707, "Los Cocos", 14 },
                    { 140710, "San Antonio de Arredondo", 14 },
                    { 140714, "San Esteban", 14 },
                    { 140721, "Santa María de Punilla", 14 },
                    { 140728, "Tanti", 14 },
                    { 140735, "Valle Hermoso", 14 },
                    { 140742, "Villa Carlos Paz", 14 },
                    { 140749, "Villa Giardino", 14 },
                    { 140752, "Villa Río Icho Cruz", 14 },
                    { 140754, "Villa Santa Cruz del Lago", 14 },
                    { 140756, "Achiras", 14 },
                    { 140763, "Adelia María", 14 },
                    { 140770, "Alcira", 14 },
                    { 140777, "Alpa Corral", 14 },
                    { 140784, "Berrotarán", 14 },
                    { 140791, "Bulnes", 14 },
                    { 140798, "Chaján", 14 },
                    { 140805, "Coronel Baigorria", 14 },
                    { 140812, "Coronel Moldes", 14 },
                    { 140819, "Elena", 14 },
                    { 140826, "La Cautiva", 14 },
                    { 140833, "Las Acequias", 14 },
                    { 140840, "Las Higueras", 14 },
                    { 140847, "Las Vertientes", 14 },
                    { 140854, "Monte de los Gauchos", 14 },
                    { 140861, "Río Cuarto", 14 },
                    { 140868, "Sampacho", 14 },
                    { 140875, "San Basilio", 14 },
                    { 140882, "Santa Catalina Holmberg", 14 },
                    { 140889, "Tosquita", 14 },
                    { 140896, "Vicuña Mackenna", 14 },
                    { 140903, "La Para", 14 },
                    { 140910, "La Puerta", 14 },
                    { 140917, "Montecristo", 14 },
                    { 140924, "Obispo Trejo", 14 },
                    { 140931, "Piquillín", 14 },
                    { 140938, "Río Primero", 14 },
                    { 140945, "Villa Santa Rosa", 14 },
                    { 140952, "Villa Fontana", 14 },
                    { 140959, "Sebastián Elcano", 14 },
                    { 140966, "Villa de María", 14 },
                    { 140973, "Calchín", 14 },
                    { 140980, "Calchín Oeste", 14 },
                    { 140987, "Capilla del Carmen", 14 },
                    { 140994, "Carrilobo", 14 },
                    { 141001, "Colazo", 14 },
                    { 141008, "Costa Sacate", 14 },
                    { 141015, "Laguna Larga", 14 },
                    { 141022, "Las Junturas", 14 },
                    { 141029, "Luque", 14 },
                    { 141036, "Manfredi", 14 },
                    { 141043, "Matorrales", 14 },
                    { 141050, "Oncativo", 14 },
                    { 141057, "Pilar", 14 },
                    { 141064, "Pozo del Molle", 14 },
                    { 141071, "Río Segundo", 14 },
                    { 141078, "Santiago Temple", 14 },
                    { 141085, "Villa del Rosario", 14 },
                    { 141092, "Mina Clavero", 14 },
                    { 141099, "Nono", 14 },
                    { 141106, "San Pedro", 14 },
                    { 141113, "Villa Cura Brochero", 14 },
                    { 141120, "Villa Sarmiento", 14 },
                    { 141127, "La Paz", 14 },
                    { 141130, "Las Tapias", 14 },
                    { 141132, "Los Cerrillos", 14 },
                    { 141134, "San Javier y Yacanto", 14 },
                    { 141141, "San José", 14 },
                    { 141148, "Villa de las Rosas", 14 },
                    { 141155, "Villa Dolores", 14 },
                    { 141162, "Alicia", 14 },
                    { 141169, "Altos de Chipión", 14 },
                    { 141176, "Arroyito", 14 },
                    { 141183, "Balnearia", 14 },
                    { 141190, "Brinkmann", 14 },
                    { 141197, "Colonia Marina", 14 },
                    { 141204, "Colonia Prosperidad", 14 },
                    { 141211, "Colonia San Bartolomé", 14 },
                    { 141218, "Colonia Vignaud", 14 },
                    { 141225, "Devoto", 14 },
                    { 141232, "El Arañado", 14 },
                    { 141239, "El Fortín", 14 },
                    { 141246, "El Tío", 14 },
                    { 141253, "Freyre", 14 },
                    { 141260, "La Francia", 14 },
                    { 141267, "La Paquita", 14 },
                    { 141274, "La Tordilla", 14 },
                    { 141281, "Las Varas", 14 },
                    { 141288, "Las Varillas", 14 },
                    { 141295, "Marull", 14 },
                    { 141302, "Miramar de Ansenuza", 14 },
                    { 141309, "Morteros", 14 },
                    { 141316, "Porteña", 14 },
                    { 141323, "Quebracho Herrado", 14 },
                    { 141330, "Sacanta", 14 },
                    { 141337, "San Francisco", 14 },
                    { 141344, "Saturnino María Laspiur", 14 },
                    { 141351, "Seeber", 14 },
                    { 141358, "Tránsito", 14 },
                    { 141365, "Villa Concepción del Tío", 14 },
                    { 141372, "Alta Gracia", 14 },
                    { 141375, "Anisacate", 14 },
                    { 141377, "Bouwer", 14 },
                    { 141379, "Despeñaderos", 14 },
                    { 141386, "Lozada", 14 },
                    { 141393, "Malagueño", 14 },
                    { 141400, "Monte Ralo", 14 },
                    { 141407, "Toledo", 14 },
                    { 141410, "Villa Parque Santa Ana", 14 },
                    { 141414, "San Francisco del Chañar", 14 },
                    { 141421, "Almafuerte", 14 },
                    { 141428, "Colonia Almada", 14 },
                    { 141435, "Corralito", 14 },
                    { 141442, "Dalmacio Vélez", 14 },
                    { 141449, "Hernando", 14 },
                    { 141456, "James Craik", 14 },
                    { 141463, "Las Perdices", 14 },
                    { 141470, "Los Zorros", 14 },
                    { 141477, "Oliva", 14 },
                    { 141484, "Pampayasta Sud", 14 },
                    { 141491, "Río Tercero", 14 },
                    { 141498, "Tancacha", 14 },
                    { 141505, "Villa Ascasubi", 14 },
                    { 141512, "Cañada de Luque", 14 },
                    { 141519, "Las Peñas", 14 },
                    { 141526, "Sarmiento", 14 },
                    { 141533, "Sinsacate", 14 },
                    { 141540, "Villa del Totoral", 14 },
                    { 141547, "Las Arrias", 14 },
                    { 141554, "Lucio Victorio Mansilla", 14 },
                    { 141561, "San José de la Dormida", 14 },
                    { 141568, "San José de las Salinas", 14 },
                    { 141575, "San Pedro Norte", 14 },
                    { 141582, "Villa Tulumba", 14 },
                    { 141589, "Alto Alegre", 14 },
                    { 141596, "Ballesteros", 14 },
                    { 141603, "Ballesteros Sud", 14 },
                    { 141610, "Bell Ville", 14 },
                    { 141617, "Benjamín Gould", 14 },
                    { 141624, "Canals", 14 },
                    { 141631, "Chilibroste", 14 },
                    { 141638, "Cintra", 14 },
                    { 141645, "Colonia Bismarck", 14 },
                    { 141652, "Idiazábal", 14 },
                    { 141659, "Justiniano Posse", 14 },
                    { 141666, "Laborde", 14 },
                    { 141673, "Monte Leña", 14 },
                    { 141680, "Monte Maíz", 14 },
                    { 141687, "Morrison", 14 },
                    { 141694, "Noetinger", 14 },
                    { 141701, "Ordóñez", 14 },
                    { 141708, "Pascanas", 14 },
                    { 141715, "Pueblo Italiano", 14 },
                    { 141722, "San Antonio de Litín", 14 },
                    { 141729, "San Marcos Sud", 14 },
                    { 141736, "Viamonte", 14 },
                    { 141743, "Wenceslao Escalante", 14 },
                    { 142007, "Amboy", 14 },
                    { 142014, "Parque Calmayo", 14 },
                    { 142021, "Cañada del Sauce", 14 },
                    { 142028, "Las Bajadas", 14 },
                    { 142035, "Las Caleras", 14 },
                    { 142042, "Los Molinos", 14 },
                    { 142049, "Los Reartes", 14 },
                    { 142056, "Lutti", 14 },
                    { 142063, "San Ignacio", 14 },
                    { 142070, "Segunda Usina", 14 },
                    { 142077, "Villa Amancay", 14 },
                    { 142084, "Villa Ciudad Parque Los Reartes", 14 },
                    { 142091, "Villa Quillinzo", 14 },
                    { 142098, "Colonia Vicente Agüero", 14 },
                    { 142105, "El Manzano", 14 },
                    { 142126, "Villa Cerro Azul", 14 },
                    { 142133, "Alto de los Quebrachos", 14 },
                    { 142140, "Bañado de Soto", 14 },
                    { 142147, "Cruz de Caña", 14 },
                    { 142161, "Guanaco Muerto", 14 },
                    { 142168, "La Batea", 14 },
                    { 142175, "La Higuera", 14 },
                    { 142182, "Las Cañadas", 14 },
                    { 142189, "Las Playas", 14 },
                    { 142196, "Los Chañaritos", 14 },
                    { 142203, "Media Naranja", 14 },
                    { 142210, "Paso Viejo", 14 },
                    { 142217, "Tuclame", 14 },
                    { 142224, "Nicolás Bruzzone", 14 },
                    { 142231, "Onagoity", 14 },
                    { 142238, "Pincén", 14 },
                    { 142245, "Ranqueles", 14 },
                    { 142252, "Villa Sarmiento", 14 },
                    { 142259, "Avellaneda", 14 },
                    { 142266, "Cañada de Río Pinto", 14 },
                    { 142273, "Chuña", 14 },
                    { 142280, "Copacabana", 14 },
                    { 142287, "Los Pozos", 14 },
                    { 142294, "Olivares de San Nicolás", 14 },
                    { 142301, "Villa Gutiérrez", 14 },
                    { 142308, "Assunta", 14 },
                    { 142315, "El Rastreador", 14 },
                    { 142322, "Pacheco de Melo", 14 },
                    { 142329, "Paso del Durazno", 14 },
                    { 142336, "Colonia Barge", 14 },
                    { 142343, "Saladillo", 14 },
                    { 142350, "Villa Elisa", 14 },
                    { 142357, "Ciénaga del Coro", 14 },
                    { 142364, "El Chacho", 14 },
                    { 142371, "Estancia de Guadalupe", 14 },
                    { 142378, "Guasapampa", 14 },
                    { 142385, "La Playa", 14 },
                    { 142392, "Talaini", 14 },
                    { 142399, "Tosno", 14 },
                    { 142406, "Chancani", 14 },
                    { 142413, "Las Palmas", 14 },
                    { 142420, "Los Talares", 14 },
                    { 142427, "San Gerónimo", 14 },
                    { 142434, "Tala Cañada", 14 },
                    { 142441, "Villa de Pocho", 14 },
                    { 142448, "Leguizamón", 14 },
                    { 142455, "Río Bamba", 14 },
                    { 142462, "San Joaquín", 14 },
                    { 142469, "Cabalango", 14 },
                    { 142476, "Casa Grande", 14 },
                    { 142483, "Charbonier", 14 },
                    { 142490, "Cuesta Blanca", 14 },
                    { 142497, "Estancia Vieja", 14 },
                    { 142504, "Mayu Sumaj", 14 },
                    { 142518, "San Roque", 14 },
                    { 142525, "Tala Huasi", 14 },
                    { 142532, "Villa Parque Síquiman", 14 },
                    { 142553, "Chucul", 14 },
                    { 142560, "La Carolina El Potosí", 14 },
                    { 142567, "Las Albahacas", 14 },
                    { 142574, "Las Peñas Sud", 14 },
                    { 142581, "Malena", 14 },
                    { 142588, "Suco", 14 },
                    { 142595, "Villa El Chacay", 14 },
                    { 142602, "Washington", 14 },
                    { 142609, "Atahona", 14 },
                    { 142616, "Cañada de Machado", 14 },
                    { 142623, "Capilla de los Remedios", 14 },
                    { 142630, "Chalacea", 14 },
                    { 142637, "Colonia Las Cuatro Esquinas", 14 },
                    { 142644, "Comechingones", 14 },
                    { 142651, "Diego de Rojas", 14 },
                    { 142658, "El Crispín", 14 },
                    { 142665, "Esquina", 14 },
                    { 142672, "Kilómetro 658", 14 },
                    { 142679, "La Posta", 14 },
                    { 142686, "La Quinta", 14 },
                    { 142693, "Las Gramillas", 14 },
                    { 142700, "Las Saladas", 14 },
                    { 142707, "Maquinista Gallini", 14 },
                    { 142714, "Plaza de Mercedes", 14 },
                    { 142721, "Sagrada Familia", 14 },
                    { 142728, "Tinoco", 14 },
                    { 142735, "Cerro Colorado", 14 },
                    { 142742, "Chañar Viejo", 14 },
                    { 142749, "Eufrasio Loza", 14 },
                    { 142756, "Gutemberg", 14 },
                    { 142763, "La Rinconada", 14 },
                    { 142770, "Los Hoyos", 14 },
                    { 142777, "Puesto de Castro", 14 },
                    { 142784, "Rayo Cortado", 14 },
                    { 142791, "Santa Elena", 14 },
                    { 142798, "Villa Candelaria Norte", 14 },
                    { 142805, "Colonia Videla", 14 },
                    { 142812, "Impira", 14 },
                    { 142819, "Los Chañaritos", 14 },
                    { 142826, "Rincón", 14 },
                    { 142833, "Ambul", 14 },
                    { 142840, "Arroyo de los Patos", 14 },
                    { 142847, "Las Calles", 14 },
                    { 142854, "Las Rabonas", 14 },
                    { 142861, "Panaholma", 14 },
                    { 142868, "San Lorenzo", 14 },
                    { 142875, "San Vicente", 14 },
                    { 142882, "Sauce Arriba", 14 },
                    { 142889, "Conlara", 14 },
                    { 142896, "La Población", 14 },
                    { 142917, "Los Hornillos", 14 },
                    { 142924, "Luyaba", 14 },
                    { 142931, "Colonia Anita", 14 },
                    { 142938, "Colonia Iturraspe", 14 },
                    { 142945, "Colonia Las Pichanas", 14 },
                    { 142952, "Colonia San Pedro", 14 },
                    { 142959, "Colonia Valtelina", 14 },
                    { 142966, "Plaza Luxardo", 14 },
                    { 142973, "Toro Pujio", 14 },
                    { 142980, "Villa San Esteban", 14 },
                    { 143001, "Dique Chico", 14 },
                    { 143008, "Falda del Carmen", 14 },
                    { 143015, "La Cumbrecita", 14 },
                    { 143022, "La Paisanita", 14 },
                    { 143029, "La Rancherita", 14 },
                    { 143036, "La Serranita", 14 },
                    { 143043, "Los Cedros", 14 },
                    { 143050, "Potrero de Garay", 14 },
                    { 143057, "Rafael García", 14 },
                    { 143064, "San Clemente", 14 },
                    { 143071, "Valle de Anisacate", 14 },
                    { 143078, "Villa Ciudad de América", 14 },
                    { 143085, "Villa del Prado", 14 },
                    { 143092, "Villa La Bolsa", 14 },
                    { 143099, "Villa Los Aromos", 14 },
                    { 143113, "Villa San Isidro", 14 },
                    { 143120, "Caminiaga", 14 },
                    { 143127, "Chuña Huasi", 14 },
                    { 143134, "Pozo Nuevo", 14 },
                    { 143141, "General Fotheringham", 14 },
                    { 143148, "Las Isletillas", 14 },
                    { 143155, "Pampayasta Norte", 14 },
                    { 143162, "Punta del Agua", 14 },
                    { 143169, "Candelaria Sud", 14 },
                    { 143176, "Capilla de Sitón", 14 },
                    { 143183, "La Pampa", 14 },
                    { 143190, "Los Mistoles", 14 },
                    { 143197, "Simbolar", 14 },
                    { 143204, "Churqui Cañada", 14 },
                    { 143211, "El Rodeo", 14 },
                    { 143218, "Rosario del Saladillo", 14 },
                    { 143225, "Aldea Santa María", 14 },
                    { 143232, "Ana Zumará", 14 },
                    { 143239, "Colonia Bremen", 14 },
                    { 143246, "Villa Los Patos", 14 },
                    { 180007, "Bella Vista", 18 },
                    { 180010, "Tres de Abril", 18 },
                    { 180014, "San Antonio de Itatí", 18 },
                    { 180021, "Corrientes", 18 },
                    { 180028, "Riachuelo", 18 },
                    { 180035, "Colonia Santa Rosa", 18 },
                    { 180042, "Concepción del Yaguareté Corá", 18 },
                    { 180049, "Tabay", 18 },
                    { 180056, "Tatacuá", 18 },
                    { 180059, "Cazadores Correntinos", 18 },
                    { 180063, "Curuzú Cuatiá", 18 },
                    { 180070, "Perugorría", 18 },
                    { 180073, "El Sombrero", 18 },
                    { 180077, "Empedrado", 18 },
                    { 180084, "Esquina", 18 },
                    { 180091, "Pueblo Libertador", 18 },
                    { 180098, "Alvear", 18 },
                    { 180105, "Estación Torrent", 18 },
                    { 180112, "Caá Catí", 18 },
                    { 180119, "Itá Ibaté", 18 },
                    { 180126, "Lomas de Vallejos", 18 },
                    { 180133, "Palmar Grande", 18 },
                    { 180137, "Carolina", 18 },
                    { 180140, "Goya", 18 },
                    { 180143, "San Isidro", 18 },
                    { 180147, "Itatí", 18 },
                    { 180154, "Ramada Paso", 18 },
                    { 180161, "Colonia Liebig", 18 },
                    { 180168, "Ituzaingó", 18 },
                    { 180175, "San Antonio Isla Apipé Grande", 18 },
                    { 180182, "San Carlos", 18 },
                    { 180186, "Villa Olivari", 18 },
                    { 180188, "Cecilio Echavarría", 18 },
                    { 180189, "Cruz de los Milagros", 18 },
                    { 180196, "Gobernador Martínez", 18 },
                    { 180203, "Lavalle", 18 },
                    { 180210, "Santa Lucía", 18 },
                    { 180217, "Yatay Ti Calle", 18 },
                    { 180224, "Mburucuyá", 18 },
                    { 180231, "Felipe Yofré", 18 },
                    { 180238, "Mariano I. Loza", 18 },
                    { 180245, "Mercedes", 18 },
                    { 180252, "Colonia Libertad", 18 },
                    { 180259, "Juan Pujol", 18 },
                    { 180266, "Mocoretá", 18 },
                    { 180273, "Monte Caseros", 18 },
                    { 180280, "Bonpland", 18 },
                    { 180287, "Parada Pucheta", 18 },
                    { 180294, "Paso de los Libres", 18 },
                    { 180301, "Tapebicuá", 18 },
                    { 180308, "Saladas", 18 },
                    { 180315, "San Lorenzo", 18 },
                    { 180318, "Pago de los Deseos", 18 },
                    { 180322, "Paso de la Patria", 18 },
                    { 180329, "San Cosme", 18 },
                    { 180336, "Santa Ana de los Guácaras", 18 },
                    { 180343, "Herlitzka", 18 },
                    { 180350, "San Luis del Palmar", 18 },
                    { 180357, "Colonia Carlos Pellegrini", 18 },
                    { 180364, "Guaviraví", 18 },
                    { 180371, "La Cruz", 18 },
                    { 180378, "Yapeyú", 18 },
                    { 180385, "Loreto", 18 },
                    { 180392, "San Miguel", 18 },
                    { 180399, "9 de Julio", 18 },
                    { 180406, "Pedro R. Fernández", 18 },
                    { 180413, "Chavarría", 18 },
                    { 180417, "Colonia Pando", 18 },
                    { 180420, "San Roque", 18 },
                    { 180427, "Garruchos", 18 },
                    { 180434, "Gobernador Virasoro", 18 },
                    { 180441, "Garaví", 18 },
                    { 180448, "Santo Tomé", 18 },
                    { 180455, "Sauce", 18 },
                    { 220007, "Concepción del Bermejo", 22 },
                    { 220014, "Los Frentones", 22 },
                    { 220021, "Pampa del Infierno", 22 },
                    { 220028, "Taco Pozo", 22 },
                    { 220035, "General Vedia", 22 },
                    { 220042, "Isla del Cerrito", 22 },
                    { 220049, "La Leonesa", 22 },
                    { 220056, "Las Palmas", 22 },
                    { 220063, "Puerto Bermejo", 22 },
                    { 220070, "Puerto Eva Perón", 22 },
                    { 220077, "Presidencia Roque Sáenz Peña", 22 },
                    { 220084, "Charata", 22 },
                    { 220091, "Gancedo", 22 },
                    { 220098, "General Capdevila", 22 },
                    { 220105, "General Pinedo", 22 },
                    { 220112, "Hermoso Campo", 22 },
                    { 220119, "Chorotis", 22 },
                    { 220126, "Santa Sylvina", 22 },
                    { 220133, "Corzuela", 22 },
                    { 220140, "La Escondida", 22 },
                    { 220147, "Lapachito", 22 },
                    { 220154, "La Verde", 22 },
                    { 220161, "Makallé", 22 },
                    { 220168, "El Sauzalito", 22 },
                    { 220175, "Fuerte Esperanza", 22 },
                    { 220182, "Juan José Castelli", 22 },
                    { 220189, "Miraflores", 22 },
                    { 220196, "Misión Nueva Pompeya", 22 },
                    { 220203, "Villa Río Bermejito", 22 },
                    { 220210, "Avia Terai", 22 },
                    { 220217, "Campo Largo", 22 },
                    { 220224, "Napenay", 22 },
                    { 220231, "Colonia Popular", 22 },
                    { 220238, "Laguna Blanca", 22 },
                    { 220245, "Puerto Tirol", 22 },
                    { 220252, "Ciervo Petiso", 22 },
                    { 220259, "General San Martín", 22 },
                    { 220266, "La Eduvigis", 22 },
                    { 220273, "Laguna Limpia", 22 },
                    { 220280, "Pampa Almirón", 22 },
                    { 220287, "Pampa del Indio", 22 },
                    { 220294, "Presidencia Roca", 22 },
                    { 220301, "Tres Isletas", 22 },
                    { 220308, "Coronel Du Graty", 22 },
                    { 220315, "Enrique Urién", 22 },
                    { 220322, "Villa Ángela", 22 },
                    { 220329, "Las Breñas", 22 },
                    { 220336, "La Clotilde", 22 },
                    { 220343, "La Tigra", 22 },
                    { 220350, "San Bernardo", 22 },
                    { 220357, "Presidencia de la Plaza", 22 },
                    { 220364, "Colonia Benítez", 22 },
                    { 220371, "Margarita Belén", 22 },
                    { 220378, "Quitilipi", 22 },
                    { 220385, "Barranqueras", 22 },
                    { 220392, "Basail", 22 },
                    { 220399, "Fontana", 22 },
                    { 220406, "Puerto Vilelas", 22 },
                    { 220413, "Resistencia", 22 },
                    { 220420, "Samuhú", 22 },
                    { 220427, "Villa Berthet", 22 },
                    { 220434, "Capitán Solari", 22 },
                    { 220441, "Colonia Elisa", 22 },
                    { 220448, "Colonias Unidas", 22 },
                    { 220455, "Las Garcitas", 22 },
                    { 220462, "Cote Lai", 22 },
                    { 220469, "Charadai", 22 },
                    { 220476, "Machagai", 22 },
                    { 260007, "Puerto Madryn", 26 },
                    { 260014, "Cholila", 26 },
                    { 260021, "El Hoyo", 26 },
                    { 260028, "El Maitén", 26 },
                    { 260035, "Epuyén", 26 },
                    { 260042, "Lago Puelo", 26 },
                    { 260049, "Comodoro Rivadavia", 26 },
                    { 260056, "Rada Tilly", 26 },
                    { 260063, "Camarones", 26 },
                    { 260070, "Corcovado", 26 },
                    { 260077, "Esquel", 26 },
                    { 260084, "Trevelin", 26 },
                    { 260091, "Dolavon", 26 },
                    { 260098, "Gaiman", 26 },
                    { 260105, "Tecka", 26 },
                    { 260112, "Rawson", 26 },
                    { 260119, "Trelew", 26 },
                    { 260126, "Alto Río Senguer", 26 },
                    { 260133, "Río Mayo", 26 },
                    { 260140, "Sarmiento", 26 },
                    { 260147, "Gobernador Costa", 26 },
                    { 260154, "José de San Martín", 26 },
                    { 260161, "Río Pico", 26 },
                    { 265007, "Gualjaina", 26 },
                    { 265014, "28 de Julio", 26 },
                    { 265021, "Paso de Indios", 26 },
                    { 265028, "Puerto Pirámides", 26 },
                    { 268014, "Cushamen", 26 },
                    { 268021, "Cerro Centinela", 26 },
                    { 268028, "Dique Florentino Ameghino", 26 },
                    { 268035, "Gastre", 26 },
                    { 268042, "Lagunita Salada", 26 },
                    { 268049, "Aldea Epulef", 26 },
                    { 268056, "Carrenleufú", 26 },
                    { 268063, "Colan Conhue", 26 },
                    { 268070, "Paso del Sapo", 26 },
                    { 268077, "Las Plumas", 26 },
                    { 268084, "Los Altares", 26 },
                    { 268091, "Aldea Beleiro", 26 },
                    { 268098, "Doctor Ricardo Rojas", 26 },
                    { 268105, "Facundo", 26 },
                    { 268112, "Lago Blanco", 26 },
                    { 268119, "Buen Pasto", 26 },
                    { 268126, "Gan Gan", 26 },
                    { 268133, "Telsen", 26 },
                    { 268147, "Dr. Atilio Oscar Viglione", 26 },
                    { 300007, "Colón", 30 },
                    { 300014, "San José", 30 },
                    { 300021, "Ubajay", 30 },
                    { 300028, "Villa Elisa", 30 },
                    { 300035, "Colonia Ayuí", 30 },
                    { 300042, "Concordia", 30 },
                    { 300049, "Estancia Grande", 30 },
                    { 300056, "La Criolla", 30 },
                    { 300063, "Los Charrúas", 30 },
                    { 300070, "Puerto Yeruá", 30 },
                    { 300077, "Aldea Valle María", 30 },
                    { 300084, "Diamante", 30 },
                    { 300091, "General Ramírez", 30 },
                    { 300098, "Villa Libertador San Martín", 30 },
                    { 300105, "Chajarí", 30 },
                    { 300112, "Federación", 30 },
                    { 300115, "Los Conquistadores", 30 },
                    { 300119, "San Jaime de la Frontera", 30 },
                    { 300126, "Santa Ana", 30 },
                    { 300133, "Villa del Rosario", 30 },
                    { 300140, "Conscripto Bernardi", 30 },
                    { 300147, "Federal", 30 },
                    { 300154, "Sauce de Luna", 30 },
                    { 300161, "San José de Feliciano", 30 },
                    { 300168, "General Galarza", 30 },
                    { 300175, "Gualeguay", 30 },
                    { 300182, "Aldea San Antonio", 30 },
                    { 300184, "Enrique Carbó", 30 },
                    { 300185, "Gilbert", 30 },
                    { 300189, "San José de Gualeguaychú", 30 },
                    { 300196, "Larroque", 30 },
                    { 300199, "Pueblo General Belgrano", 30 },
                    { 300203, "Urdinarrain", 30 },
                    { 300210, "Ceibas", 30 },
                    { 300217, "Ibicuy", 30 },
                    { 300224, "Villa Paranacito", 30 },
                    { 300231, "Alcaraz", 30 },
                    { 300238, "Bovril", 30 },
                    { 300245, "La Paz", 30 },
                    { 300252, "Piedras Blancas", 30 },
                    { 300255, "San Gustavo", 30 },
                    { 300259, "Santa Elena", 30 },
                    { 300266, "Villa Aranguren", 30 },
                    { 300273, "Villa Sabá Z. Hernández", 30 },
                    { 300280, "Lucas González", 30 },
                    { 300287, "Nogoyá", 30 },
                    { 300294, "Cerrito", 30 },
                    { 300297, "Colonia Avellaneda", 30 },
                    { 300301, "Crespo", 30 },
                    { 300308, "Hasenkamp", 30 },
                    { 300315, "Hernandarias", 30 },
                    { 300322, "María Grande", 30 },
                    { 300329, "Oro Verde", 30 },
                    { 300336, "Paraná", 30 },
                    { 300343, "San Benito", 30 },
                    { 300350, "Seguí", 30 },
                    { 300357, "Tabossi", 30 },
                    { 300364, "Viale", 30 },
                    { 300371, "Villa Urquiza", 30 },
                    { 300378, "General Campos", 30 },
                    { 300385, "San Salvador", 30 },
                    { 300392, "Gobernador Mansilla", 30 },
                    { 300399, "Maciá", 30 },
                    { 300406, "Rosario del Tala", 30 },
                    { 300413, "Basavilbaso", 30 },
                    { 300420, "Caseros", 30 },
                    { 300423, "Colonia Elía", 30 },
                    { 300427, "Concepción del Uruguay", 30 },
                    { 300434, "Herrera", 30 },
                    { 300437, "1º de Mayo", 30 },
                    { 300441, "Pronunciamiento", 30 },
                    { 300448, "San Justo", 30 },
                    { 300455, "Santa Anita", 30 },
                    { 300462, "Villa Mantero", 30 },
                    { 300469, "Victoria", 30 },
                    { 300476, "Villa Clara", 30 },
                    { 300483, "Villa Domínguez", 30 },
                    { 300490, "Villaguay", 30 },
                    { 302007, "Arroyo Barú", 30 },
                    { 302035, "La Clarita", 30 },
                    { 302042, "Pueblo Cazes", 30 },
                    { 302077, "General Roca", 30 },
                    { 302084, "Nueva Escocia", 30 },
                    { 302091, "Pedernal", 30 },
                    { 302112, "Aldea Protestante", 30 },
                    { 302126, "Aldea Spatzenkutter", 30 },
                    { 302133, "Colonia Ensayo", 30 },
                    { 302161, "Gobernador Racedo", 30 },
                    { 302175, "Las Cuevas", 30 },
                    { 302287, "El Cimarrón", 30 },
                    { 302308, "Nueva Vizcaya", 30 },
                    { 302376, "San Víctor", 30 },
                    { 302383, "Aldea Asunción", 30 },
                    { 302411, "Distrito Sexto", 30 },
                    { 302453, "Aldea San Juan", 30 },
                    { 302512, "Estación Parera", 30 },
                    { 302526, "Irazusta", 30 },
                    { 302596, "Colonia Avigdor", 30 },
                    { 302638, "El Solar", 30 },
                    { 302666, "Ombú", 30 },
                    { 302780, "Don Cristóbal II", 30 },
                    { 302787, "Febre", 30 },
                    { 302808, "XX de Septiembre", 30 },
                    { 302836, "Aldea Santa María", 30 },
                    { 302843, "Aldea Santa Rosa", 30 },
                    { 302899, "Colonia Crespo", 30 },
                    { 302927, "El Palenque", 30 },
                    { 302941, "Estación Sosa", 30 },
                    { 302948, "Gobernador Etchevehere", 30 },
                    { 302955, "La Picada", 30 },
                    { 302962, "Las Garzas", 30 },
                    { 302976, "Paraje Las Tunas", 30 },
                    { 302999, "Puerto Curtiembre", 30 },
                    { 303020, "Sauce Montrull", 30 },
                    { 303027, "Sauce Pinto", 30 },
                    { 303034, "Tezanos Pinto", 30 },
                    { 303041, "Villa Fontana", 30 },
                    { 303091, "Durazno", 30 },
                    { 303098, "Gobernador Echagüe", 30 },
                    { 303112, "Gobernador Sola", 30 },
                    { 303119, "Guardamonte", 30 },
                    { 303154, "Comuna Tala", 30 },
                    { 303161, "Las Moscas", 30 },
                    { 303168, "Líbaros", 30 },
                    { 303175, "Rocamora", 30 },
                    { 303182, "San Cipriano", 30 },
                    { 303189, "San Marcial", 30 },
                    { 303196, "Antelo", 30 },
                    { 303245, "Rincón de Nogoyá", 30 },
                    { 303252, "Rincón del Doll", 30 },
                    { 303273, "Ingeniero Sajaroff", 30 },
                    { 303280, "Jubileo", 30 },
                    { 303329, "Paso de La Laguna", 30 },
                    { 309005, "San Miguel", 30 },
                    { 309007, "Colonia San Anselmo y Aledañas", 30 },
                    { 309010, "Hambis", 30 },
                    { 309015, "Hocker", 30 },
                    { 309030, "Pueblo Liebig", 30 },
                    { 309035, "Clodomiro Ledesma", 30 },
                    { 309045, "El Redomón", 30 },
                    { 309050, "Estación Yeruá", 30 },
                    { 309055, "Estación Yuquerí", 30 },
                    { 309070, "San Justo", 30 },
                    { 309075, "Aldea Brasilera", 30 },
                    { 309080, "Aldea Grapschental", 30 },
                    { 309090, "Aldea Salto", 30 },
                    { 309105, "Costa Grande", 30 },
                    { 309110, "Estación Camps", 30 },
                    { 309120, "General Alvear", 30 },
                    { 309125, "Isletas", 30 },
                    { 309135, "Colonia Alemana", 30 },
                    { 309140, "Colonia La Argentina", 30 },
                    { 309143, "Colonia Santa María y Las Margaritas", 30 },
                    { 309145, "Colonia Tunas", 30 },
                    { 309150, "Gualeguaycito", 30 },
                    { 309155, "La Florida", 30 },
                    { 309160, "La Fraternidad y Santa Juana", 30 },
                    { 309165, "Paraje Guayaquil", 30 },
                    { 309175, "San Pedro", 30 },
                    { 309180, "San Ramón", 30 },
                    { 309185, "San Roque", 30 },
                    { 309190, "Arroyo del Medio", 30 },
                    { 309192, "Arroyo Las Tunas", 30 },
                    { 309193, "Banderas", 30 },
                    { 309195, "Distrito Diego López", 30 },
                    { 309205, "El Gramiyal", 30 },
                    { 309210, "Loma Limpia", 30 },
                    { 309220, "Paso Duarte", 30 },
                    { 309225, "Santa Lucía", 30 },
                    { 309230, "Distrito Chañar", 30 },
                    { 309235, "La Esmeralda", 30 },
                    { 309240, "La Hierra", 30 },
                    { 309245, "La Verbena", 30 },
                    { 309250, "Laguna Benítez", 30 },
                    { 309255, "Las Mulitas", 30 },
                    { 309260, "Mulas Grandes", 30 },
                    { 309275, "Distrito Cuarto", 30 },
                    { 309280, "Distrito Primero", 30 },
                    { 309285, "Distrito Quinto", 30 },
                    { 309295, "Estación Lazo", 30 },
                    { 309300, "González Calderón", 30 },
                    { 309305, "Monte Redondo", 30 },
                    { 309310, "Punta del Monte", 30 },
                    { 309325, "Costa San Antonio", 30 },
                    { 309330, "Costa Uruguay Norte", 30 },
                    { 309335, "Costa Uruguay Sur", 30 },
                    { 309340, "Cuchilla Redonda", 30 },
                    { 309345, "Distrito Talitas", 30 },
                    { 309355, "Estación Escriña", 30 },
                    { 309365, "General Almada", 30 },
                    { 309375, "Las Mercedes", 30 },
                    { 309380, "Pastor Britos", 30 },
                    { 309385, "Perdices", 30 },
                    { 309395, "Rincón del Cinto", 30 },
                    { 309400, "Rincón del Gato", 30 },
                    { 309405, "Médanos", 30 },
                    { 309410, "Ñancay", 30 },
                    { 309415, "Alcaraz Norte", 30 },
                    { 309420, "Alcaraz Sur", 30 },
                    { 309430, "Colonia Carrasco", 30 },
                    { 309435, "Colonia Oficial N° 13", 30 },
                    { 309440, "Colonia Oficial Nº 3 y 14", 30 },
                    { 309445, "Colonia Viraró", 30 },
                    { 309450, "El Quebracho", 30 },
                    { 309460, "Estaquitas", 30 },
                    { 309465, "La Providencia", 30 },
                    { 309470, "Las Toscas", 30 },
                    { 309480, "Picada Berón", 30 },
                    { 309485, "Puerto Algarrobo", 30 },
                    { 309495, "San Ramírez", 30 },
                    { 309497, "Saucecito", 30 },
                    { 309500, "Sir Leonard", 30 },
                    { 309505, "Yacaré", 30 },
                    { 309510, "Yeso Oeste", 30 },
                    { 309515, "Aldea San Miguel", 30 },
                    { 309520, "Betbeder", 30 },
                    { 309525, "Crucesitas Octava", 30 },
                    { 309530, "Crucesitas Séptima", 30 },
                    { 309535, "Crucesitas Tercera", 30 },
                    { 309540, "Distrito Chiqueros", 30 },
                    { 309543, "Distrito Sauce", 30 },
                    { 309545, "Don Cristóbal I", 30 },
                    { 309560, "Justo José de Urquiza", 30 },
                    { 309565, "Laurencena", 30 },
                    { 309575, "Aldea Eigenfeld", 30 },
                    { 309580, "Maria Luisa", 30 },
                    { 309585, "Aldea San Antonio", 30 },
                    { 309590, "Aldea San Rafael", 30 },
                    { 309605, "Antonio Tomás", 30 },
                    { 309610, "Arroyo Burgos", 30 },
                    { 309615, "Arroyo Corralito", 30 },
                    { 309620, "Arroyo Maturrango", 30 },
                    { 309625, "Arroyo Palo Seco", 30 },
                    { 309635, "Colonia Celina", 30 },
                    { 309650, "Colonia Merou", 30 },
                    { 309670, "Distrito Tala", 30 },
                    { 309680, "El Pingo", 30 },
                    { 309685, "Espinillo Norte", 30 },
                    { 309705, "María Grande 2º", 30 },
                    { 309710, "Paso de la Arena", 30 },
                    { 309715, "Paso de las Piedras", 30 },
                    { 309720, "Pueblo Brugo", 30 },
                    { 309730, "Quebracho", 30 },
                    { 309735, "Santa Luisa", 30 },
                    { 309770, "Colonia Baylina", 30 },
                    { 309775, "Colonia Oficial Nº 5", 30 },
                    { 309780, "San Ernesto", 30 },
                    { 309785, "Walter Moss", 30 },
                    { 309790, "Altamirano Sur", 30 },
                    { 309795, "Arroyo Cle", 30 },
                    { 309820, "La Ollita", 30 },
                    { 309825, "Las Guachas", 30 },
                    { 309830, "Sauce Sur", 30 },
                    { 309832, "Arroyo Gená", 30 },
                    { 309880, "Chilcas", 30 },
                    { 309885, "Distrito Pajonal", 30 },
                    { 309890, "Hinojal", 30 },
                    { 309895, "Laguna del Pescado", 30 },
                    { 309900, "Molino Doll", 30 },
                    { 309905, "Montoya", 30 },
                    { 309917, "Colonia Adivino", 30 },
                    { 309920, "Estación Raíces", 30 },
                    { 309935, "Lucas Norte", 30 },
                    { 309940, "Lucas Sur Primero", 30 },
                    { 309945, "Lucas Sur Segundo", 30 },
                    { 309950, "Mojones Norte", 30 },
                    { 309955, "Mojones Sur", 30 },
                    { 309957, "Paraje Los Algarrobos", 30 },
                    { 309965, "Raíces Oeste", 30 },
                    { 340007, "Laguna Yema", 34 },
                    { 340028, "Formosa", 34 },
                    { 340049, "General Lucio Victorio Mansilla", 34 },
                    { 340056, "Herradura", 34 },
                    { 340063, "Misión San Francisco de Laishi", 34 },
                    { 340070, "Villa Escolar", 34 },
                    { 340077, "Ingeniero Guillermo Nicasio Juárez", 34 },
                    { 340091, "Comandante Fontana", 34 },
                    { 340098, "Estanislao del Campo", 34 },
                    { 340112, "General Manuel Belgrano", 34 },
                    { 340119, "Villa General Güemes", 34 },
                    { 340126, "Ibarreta", 34 },
                    { 340133, "Las Lomitas", 34 },
                    { 340140, "Pozo del Tigre", 34 },
                    { 340147, "San Martín Dos", 34 },
                    { 340168, "El Espinillo", 34 },
                    { 340175, "Misión Tacaaglé", 34 },
                    { 340189, "Clorinda", 34 },
                    { 340196, "Laguna Blanca", 34 },
                    { 340203, "Laguna Naick Neck", 34 },
                    { 340210, "Riacho He He", 34 },
                    { 340224, "El Colorado", 34 },
                    { 340231, "Mayor Villafañe", 34 },
                    { 340238, "Palo Santo", 34 },
                    { 340245, "Pirané", 34 },
                    { 340252, "Villa Dos Trece", 34 },
                    { 340259, "El Chorro", 34 },
                    { 345007, "Los Chiriguanos", 34 },
                    { 345014, "Colonia Pastoril", 34 },
                    { 345021, "Gran Guardia", 34 },
                    { 345028, "San Hilario", 34 },
                    { 345042, "Fortín Lugones", 34 },
                    { 345049, "Subteniente Perín", 34 },
                    { 345056, "Buena Vista", 34 },
                    { 345063, "Tres Lagunas", 34 },
                    { 345070, "Siete Palmas", 34 },
                    { 349105, "Portón Negro", 34 },
                    { 380014, "Abra Pampa", 38 },
                    { 380035, "San Salvador de Jujuy", 38 },
                    { 380042, "Yala", 38 },
                    { 380049, "Aguas Calientes", 38 },
                    { 380056, "El Carmen", 38 },
                    { 380063, "Monterrico", 38 },
                    { 380070, "Pampa Blanca", 38 },
                    { 380074, "Puesto Viejo", 38 },
                    { 380077, "Perico", 38 },
                    { 380091, "El Aguilar", 38 },
                    { 380105, "Humahuaca", 38 },
                    { 380119, "Caimancito", 38 },
                    { 380126, "Calilegua", 38 },
                    { 380133, "Fraile Pintado", 38 },
                    { 380140, "Libertador General San Martín", 38 },
                    { 380147, "Yuto", 38 },
                    { 380154, "Palpalá", 38 },
                    { 380161, "San Antonio", 38 },
                    { 380196, "La Esperanza", 38 },
                    { 380203, "La Mendieta", 38 },
                    { 380224, "San Pedro de Jujuy", 38 },
                    { 380238, "El Talar", 38 },
                    { 380245, "Palma Sola", 38 },
                    { 380252, "Santa Clara", 38 },
                    { 380322, "Maimará", 38 },
                    { 380329, "Tilcara", 38 },
                    { 380406, "La Quiaca", 38 },
                    { 386007, "Abdón Castro Tolay", 38 },
                    { 386014, "Abralaite", 38 },
                    { 386021, "Puesto del Marquez", 38 },
                    { 386056, "Hipólito Yrigoyen", 38 },
                    { 386060, "Palca de Aparzo", 38 },
                    { 386063, "Tres Cruces", 38 },
                    { 386067, "Uquía", 38 },
                    { 386070, "Mina Pirquitas", 38 },
                    { 386077, "Rinconada", 38 },
                    { 386091, "Arrayanal", 38 },
                    { 386098, "El Fuerte", 38 },
                    { 386105, "Rodeito", 38 },
                    { 386112, "Rosario de Río Grande", 38 },
                    { 386119, "El Piquete", 38 },
                    { 386126, "Vinalito", 38 },
                    { 386133, "Cieneguillas", 38 },
                    { 386140, "Cusi Cusi", 38 },
                    { 386147, "Santa Catalina", 38 },
                    { 386154, "Catua", 38 },
                    { 386161, "Coranzulí", 38 },
                    { 386168, "Susques", 38 },
                    { 386175, "Huacalera", 38 },
                    { 386179, "El Moreno", 38 },
                    { 386189, "Purmamarca", 38 },
                    { 386196, "Tumbaya", 38 },
                    { 386203, "Volcán", 38 },
                    { 386210, "Caspalá", 38 },
                    { 386217, "Pampichuela", 38 },
                    { 386224, "San Francisco", 38 },
                    { 386231, "Santa Ana", 38 },
                    { 386238, "Valle Grande", 38 },
                    { 386245, "Barrios", 38 },
                    { 386252, "Cangrejillos", 38 },
                    { 386259, "El Cóndor", 38 },
                    { 386266, "Pumahuasi", 38 },
                    { 386273, "Yavi", 38 },
                    { 420007, "Abramo", 42 },
                    { 420011, "Algarrobo del Águila", 42 },
                    { 420014, "Alpachiri", 42 },
                    { 420021, "Alta Italia", 42 },
                    { 420028, "Anguil", 42 },
                    { 420035, "Arata", 42 },
                    { 420042, "Ataliva Roca", 42 },
                    { 420049, "Bernardo Larroudé", 42 },
                    { 420056, "Bernasconi", 42 },
                    { 420063, "Caleufú", 42 },
                    { 420070, "Carro Quemado", 42 },
                    { 420077, "Catriló", 42 },
                    { 420084, "Ceballos", 42 },
                    { 420091, "Colonia Barón", 42 },
                    { 420098, "Conhelo", 42 },
                    { 420105, "Coronel Hilario Lagos", 42 },
                    { 420112, "Doblas", 42 },
                    { 420116, "Dorila", 42 },
                    { 420119, "Eduardo Castex", 42 },
                    { 420126, "Embajador Martini", 42 },
                    { 420133, "General Acha", 42 },
                    { 420140, "General Campos", 42 },
                    { 420147, "General Pico", 42 },
                    { 420154, "General San Martín", 42 },
                    { 420158, "Gobernador Duval", 42 },
                    { 420161, "Guatraché", 42 },
                    { 420168, "Ingeniero Luiggi", 42 },
                    { 420175, "Intendente Alvear", 42 },
                    { 420182, "Jacinto Aráuz", 42 },
                    { 420189, "La Adela", 42 },
                    { 420196, "La Humada", 42 },
                    { 420210, "La Maruja", 42 },
                    { 420217, "Lonquimay", 42 },
                    { 420224, "Luan Toro", 42 },
                    { 420231, "Macachín", 42 },
                    { 420238, "Mauricio Mayer", 42 },
                    { 420245, "Metileo", 42 },
                    { 420252, "Miguel Cané", 42 },
                    { 420259, "Miguel Riglos", 42 },
                    { 420266, "Monte Nievas", 42 },
                    { 420273, "Parera", 42 },
                    { 420280, "Puelches", 42 },
                    { 420287, "Puelén", 42 },
                    { 420294, "Quehué", 42 },
                    { 420301, "Quemú Quemú", 42 },
                    { 420308, "Rancul", 42 },
                    { 420315, "Realicó", 42 },
                    { 420322, "Rolón", 42 },
                    { 420329, "Santa Isabel", 42 },
                    { 420336, "Santa Rosa", 42 },
                    { 420343, "Colonia Santa Teresa", 42 },
                    { 420350, "Telén", 42 },
                    { 420357, "Toay", 42 },
                    { 420364, "Tomás M. Anchorena", 42 },
                    { 420371, "Trenel", 42 },
                    { 420378, "Uriburu", 42 },
                    { 420385, "Colonia 25 de Mayo", 42 },
                    { 420392, "Vértiz", 42 },
                    { 420399, "Victorica", 42 },
                    { 420406, "Villa Mirasol", 42 },
                    { 420413, "Winifreda", 42 },
                    { 422007, "Casa de Piedra", 42 },
                    { 425007, "Adolfo Van Praet", 42 },
                    { 425014, "Agustoni", 42 },
                    { 425028, "Colonia Santa María", 42 },
                    { 425042, "Cuchillo Co", 42 },
                    { 425049, "Chacharramendi", 42 },
                    { 425063, "Falucho", 42 },
                    { 425077, "La Reforma", 42 },
                    { 425084, "Limay Mahuida", 42 },
                    { 425091, "Loventué", 42 },
                    { 425098, "Maisonave", 42 },
                    { 425105, "Perú", 42 },
                    { 425112, "Pichi Huinca", 42 },
                    { 425119, "Quetrequén", 42 },
                    { 425126, "Relmo", 42 },
                    { 425133, "Rucanelo", 42 },
                    { 425140, "Sarah", 42 },
                    { 425147, "Speluzzi", 42 },
                    { 425154, "Unanu", 42 },
                    { 460007, "Arauco", 46 },
                    { 460014, "La Rioja", 46 },
                    { 460021, "Castro Barros", 46 },
                    { 460028, "General Felipe Varela", 46 },
                    { 460035, "Chamical", 46 },
                    { 460042, "Chilecito", 46 },
                    { 460049, "Famatina", 46 },
                    { 460056, "Ángel Vicente Peñaloza", 46 },
                    { 460063, "General Belgrano", 46 },
                    { 460070, "General Juan Facundo Quiroga", 46 },
                    { 460077, "General Lamadrid", 46 },
                    { 460084, "General Ortiz de Ocampo", 46 },
                    { 460091, "General San Martín", 46 },
                    { 460098, "Vinchina", 46 },
                    { 460105, "Independencia", 46 },
                    { 460112, "Rosario Vera Peñaloza", 46 },
                    { 460119, "San Blas de Los Sauces", 46 },
                    { 460126, "Sanagasta", 46 },
                    { 500007, "Mendoza", 50 },
                    { 500014, "General Alvear", 50 },
                    { 500021, "Godoy Cruz", 50 },
                    { 500028, "Guaymallén", 50 },
                    { 500035, "Junín", 50 },
                    { 500042, "La Paz", 50 },
                    { 500049, "Las Heras", 50 },
                    { 500056, "Lavalle", 50 },
                    { 500063, "Luján de Cuyo", 50 },
                    { 500070, "Maipú", 50 },
                    { 500077, "Malargüe", 50 },
                    { 500084, "Rivadavia", 50 },
                    { 500091, "San Carlos", 50 },
                    { 500098, "San Martín", 50 },
                    { 500105, "San Rafael", 50 },
                    { 500112, "Santa Rosa", 50 },
                    { 500119, "Tunuyán", 50 },
                    { 500126, "Tupungato", 50 },
                    { 540007, "Apóstoles", 54 },
                    { 540014, "Azara", 54 },
                    { 540021, "San José", 54 },
                    { 540028, "Tres Capones", 54 },
                    { 540035, "Aristóbulo del Valle", 54 },
                    { 540042, "Campo Grande", 54 },
                    { 540049, "Dos de Mayo", 54 },
                    { 540056, "Bonpland", 54 },
                    { 540063, "Candelaria", 54 },
                    { 540070, "Cerro Corá", 54 },
                    { 540077, "Loreto", 54 },
                    { 540084, "Mártires", 54 },
                    { 540091, "Profundidad", 54 },
                    { 540098, "Santa Ana", 54 },
                    { 540105, "Fachinal", 54 },
                    { 540112, "Garupá", 54 },
                    { 540119, "Posadas", 54 },
                    { 540126, "Concepción de la Sierra", 54 },
                    { 540133, "Santa María", 54 },
                    { 540140, "Colonia Delicia", 54 },
                    { 540147, "Colonia Victoria", 54 },
                    { 540154, "Eldorado", 54 },
                    { 540161, "9 de Julio", 54 },
                    { 540168, "Santiago de Liniers", 54 },
                    { 540175, "Bernardo de Irigoyen", 54 },
                    { 540182, "Comandante Andresito", 54 },
                    { 540189, "San Antonio", 54 },
                    { 540196, "El Soberbio", 54 },
                    { 540203, "San Vicente", 54 },
                    { 540210, "Puerto Esperanza", 54 },
                    { 540217, "Puerto Iguazú", 54 },
                    { 540224, "Libertad", 54 },
                    { 540231, "Colonia Wanda", 54 },
                    { 540238, "Almafuerte", 54 },
                    { 540245, "Arroyo del Medio", 54 },
                    { 540252, "Caá Yarí", 54 },
                    { 540259, "Cerro Azul", 54 },
                    { 540266, "Dos Arroyos", 54 },
                    { 540273, "Gobernador López", 54 },
                    { 540280, "Leandro N. Alem", 54 },
                    { 540287, "Olegario V. Andrade", 54 },
                    { 540294, "Capioví", 54 },
                    { 540301, "El Alcázar", 54 },
                    { 540308, "Garuhapé", 54 },
                    { 540315, "Puerto Leoni", 54 },
                    { 540322, "Puerto Rico", 54 },
                    { 540329, "Ruiz de Montoya", 54 },
                    { 540336, "Caraguatay", 54 },
                    { 540343, "Montecarlo", 54 },
                    { 540350, "Puerto Piray", 54 },
                    { 540357, "Campo Ramón", 54 },
                    { 540364, "Campo Viera", 54 },
                    { 540371, "Colonia Alberdi", 54 },
                    { 540378, "General Alvear", 54 },
                    { 540385, "Guaraní", 54 },
                    { 540392, "Los Helechos", 54 },
                    { 540399, "Oberá", 54 },
                    { 540406, "Panambí", 54 },
                    { 540413, "San Martín", 54 },
                    { 540420, "Colonia Polana", 54 },
                    { 540427, "Corpus Christi", 54 },
                    { 540434, "General Urquiza", 54 },
                    { 540441, "Gobernador Roca", 54 },
                    { 540448, "Hipólito Yrigoyen", 54 },
                    { 540455, "Jardín América", 54 },
                    { 540462, "San Ignacio", 54 },
                    { 540469, "Santo Pipó", 54 },
                    { 540476, "Florentino Ameghino", 54 },
                    { 540483, "Itacaruare", 54 },
                    { 540490, "Mojón Grande", 54 },
                    { 540497, "San Javier", 54 },
                    { 540501, "Pozo Azul", 54 },
                    { 540504, "San Pedro", 54 },
                    { 540511, "Alba Posse", 54 },
                    { 540518, "Colonia Aurora", 54 },
                    { 540525, "25 de Mayo", 54 },
                    { 580007, "Aluminé", 58 },
                    { 580014, "Añelo", 58 },
                    { 580021, "San Patricio del Chañar", 58 },
                    { 580028, "Las Coloradas", 58 },
                    { 580035, "Piedra del Águila", 58 },
                    { 580042, "Centenario", 58 },
                    { 580049, "Cutral Co", 58 },
                    { 580056, "Neuquén", 58 },
                    { 580063, "Plaza Huincul", 58 },
                    { 580070, "Plottier", 58 },
                    { 580077, "Senillosa", 58 },
                    { 580084, "Villa El Chocón", 58 },
                    { 580091, "Vista Alegre", 58 },
                    { 580098, "Chos Malal", 58 },
                    { 580105, "Tricao Malal", 58 },
                    { 580112, "Junín de los Andes", 58 },
                    { 580119, "San Martín de los Andes", 58 },
                    { 580126, "Loncopué", 58 },
                    { 580133, "Villa La Angostura", 58 },
                    { 580140, "Andacollo", 58 },
                    { 580147, "Huinganco", 58 },
                    { 580154, "Las Ovejas", 58 },
                    { 580161, "Los Miches", 58 },
                    { 580168, "Caviahue - Copahue", 58 },
                    { 580175, "El Cholar", 58 },
                    { 580182, "El Huecú", 58 },
                    { 580189, "Taquimilán", 58 },
                    { 580196, "Barrancas", 58 },
                    { 580203, "Buta Ranquil", 58 },
                    { 580210, "Rincón de los Sauces", 58 },
                    { 580217, "Picún Leufú", 58 },
                    { 580224, "Bajada del Agrio", 58 },
                    { 580231, "Las Lajas", 58 },
                    { 580238, "Mariano Moreno", 58 },
                    { 580245, "Zapala", 58 },
                    { 580252, "Villa Pehuenia", 58 },
                    { 585014, "Aguada San Roque", 58 },
                    { 585021, "Los Chihuidos", 58 },
                    { 585028, "Pilo Lil", 58 },
                    { 585035, "Santo Tomás", 58 },
                    { 585042, "Sauzal Bonito", 58 },
                    { 585049, "Coyuco - Cochico", 58 },
                    { 585056, "Villa Curi Leuvú", 58 },
                    { 585063, "Chorriaca", 58 },
                    { 585070, "Villa Traful", 58 },
                    { 585077, "Guañacos", 58 },
                    { 585084, "Manzano Amargo", 58 },
                    { 585091, "Varvarco - Invernada Vieja", 58 },
                    { 585098, "Villa del Nahueve", 58 },
                    { 585105, "Octavio Pico", 58 },
                    { 585112, "El Sauce", 58 },
                    { 585119, "Paso Aguerre", 58 },
                    { 585126, "Quili Malal", 58 },
                    { 585133, "Covunco Abajo", 58 },
                    { 585140, "Los Catutos", 58 },
                    { 585147, "Ramón M. Castro", 58 },
                    { 585154, "Villa Puente Picún Leufú", 58 },
                    { 620007, "Guardia Mitre", 62 },
                    { 620014, "Viedma", 62 },
                    { 620021, "Chimpay", 62 },
                    { 620028, "Choele Choel", 62 },
                    { 620035, "Coronel Belisle", 62 },
                    { 620042, "Darwin", 62 },
                    { 620049, "Lamarque", 62 },
                    { 620056, "Luis Beltrán", 62 },
                    { 620063, "Pomona", 62 },
                    { 620070, "El Bolsón", 62 },
                    { 620077, "San Carlos de Bariloche", 62 },
                    { 620084, "General Conesa", 62 },
                    { 620091, "Allen", 62 },
                    { 620098, "Campo Grande", 62 },
                    { 620105, "Catriel", 62 },
                    { 620112, "Cervantes", 62 },
                    { 620119, "Chichinales", 62 },
                    { 620126, "Cinco Saltos", 62 },
                    { 620133, "Cipolletti", 62 },
                    { 620140, "Contralmirante Cordero", 62 },
                    { 620147, "General Enrique Godoy", 62 },
                    { 620154, "General Fernández Oro", 62 },
                    { 620161, "General Roca", 62 },
                    { 620168, "Ingeniero Huergo", 62 },
                    { 620175, "Mainquè", 62 },
                    { 620182, "Villa Regina", 62 },
                    { 620189, "Ministro Ramos Mexía", 62 },
                    { 620196, "Sierra Colorada", 62 },
                    { 620203, "Ñorquinco", 62 },
                    { 620210, "Río Colorado", 62 },
                    { 620217, "Comallo", 62 },
                    { 620224, "Pilcaniyeu", 62 },
                    { 620231, "San Antonio Oeste", 62 },
                    { 620238, "Sierra Grande", 62 },
                    { 620245, "Valcheta", 62 },
                    { 620252, "Ingeniero Jacobacci", 62 },
                    { 620259, "Los Menucos", 62 },
                    { 620266, "Maquinchao", 62 },
                    { 620273, "Dina Huapi", 62 },
                    { 660007, "Apolinario Saravia", 66 },
                    { 660014, "El Quebrachal", 66 },
                    { 660021, "General Pizarro", 66 },
                    { 660028, "Joaquín V. González", 66 },
                    { 660035, "Las Lajitas", 66 },
                    { 660042, "Cachi", 66 },
                    { 660049, "Payogasta", 66 },
                    { 660056, "Cafayate", 66 },
                    { 660063, "Salta", 66 },
                    { 660070, "San Lorenzo", 66 },
                    { 660077, "San José de los Cerrillos", 66 },
                    { 660084, "La Merced", 66 },
                    { 660091, "Chicoana", 66 },
                    { 660098, "El Carril", 66 },
                    { 660105, "Campo Santo", 66 },
                    { 660112, "El Bordo", 66 },
                    { 660119, "General Güemes", 66 },
                    { 660126, "Aguaray", 66 },
                    { 660133, "Embarcación", 66 },
                    { 660140, "General Ballivián", 66 },
                    { 660147, "General Mosconi", 66 },
                    { 660154, "Profesor Salvador Mazza", 66 },
                    { 660161, "Tartagal", 66 },
                    { 660168, "Guachipas", 66 },
                    { 660175, "Iruya", 66 },
                    { 660182, "Isla de Cañas", 66 },
                    { 660189, "La Caldera", 66 },
                    { 660196, "Vaqueros", 66 },
                    { 660203, "El Jardín", 66 },
                    { 660210, "El Tala", 66 },
                    { 660217, "La Candelaria", 66 },
                    { 660224, "La Poma", 66 },
                    { 660231, "Coronel Moldes", 66 },
                    { 660238, "La Viña", 66 },
                    { 660245, "San Antonio de los Cobres", 66 },
                    { 660252, "Tolar Grande", 66 },
                    { 660259, "El Galpón", 66 },
                    { 660266, "San José de Metán", 66 },
                    { 660273, "Molinos", 66 },
                    { 660280, "Río Piedras", 66 },
                    { 660287, "Seclantás", 66 },
                    { 660290, "Aguas Blancas", 66 },
                    { 660294, "Colonia Santa Rosa", 66 },
                    { 660301, "Hipólito Yrigoyen", 66 },
                    { 660308, "Pichanal", 66 },
                    { 660315, "San Ramón de la Nueva Orán", 66 },
                    { 660322, "Urundel", 66 },
                    { 660329, "Rivadavia Banda Norte", 66 },
                    { 660336, "Rivadavia Banda Sur", 66 },
                    { 660343, "Santa Victoria Este", 66 },
                    { 660350, "El Potrero", 66 },
                    { 660357, "Rosario de la Frontera", 66 },
                    { 660364, "Campo Quijano", 66 },
                    { 660371, "Rosario de Lerma", 66 },
                    { 660378, "Angastaco", 66 },
                    { 660385, "Animaná", 66 },
                    { 660392, "San Carlos", 66 },
                    { 660399, "Los Toldos", 66 },
                    { 660406, "Nazareno", 66 },
                    { 660413, "Santa Victoria Oeste", 66 },
                    { 700007, "Albardón", 70 },
                    { 700014, "Angaco", 70 },
                    { 700021, "Calingasta", 70 },
                    { 700028, "San Juan", 70 },
                    { 700035, "Caucete", 70 },
                    { 700042, "Chimbas", 70 },
                    { 700049, "Iglesia", 70 },
                    { 700056, "Jáchal", 70 },
                    { 700063, "9 de Julio", 70 },
                    { 700070, "Pocito", 70 },
                    { 700077, "Rawson", 70 },
                    { 700084, "Rivadavia", 70 },
                    { 700091, "San Martín", 70 },
                    { 700098, "Santa Lucía", 70 },
                    { 700105, "Sarmiento", 70 },
                    { 700112, "Ullum", 70 },
                    { 700119, "Valle Férti", 70 },
                    { 700126, "25 de Mayo", 70 },
                    { 700133, "Zonda", 70 },
                    { 740007, "Candelaria", 74 },
                    { 740014, "Luján", 74 },
                    { 740021, "Quines", 74 },
                    { 740028, "San Francisco", 74 },
                    { 740035, "Los Manantiales", 74 },
                    { 740038, "Estancia Grande", 74 },
                    { 740039, "El Trapiche", 74 },
                    { 740042, "La Toma", 74 },
                    { 740049, "Concarán", 74 },
                    { 740056, "Naschel", 74 },
                    { 740063, "Tilisarao", 74 },
                    { 740070, "Justo Daract", 74 },
                    { 740073, "Nación Ranquel", 74 },
                    { 740077, "Villa Mercedes", 74 },
                    { 740084, "Buena Esperanza", 74 },
                    { 740091, "Unión", 74 },
                    { 740095, "Carpintería", 74 },
                    { 740098, "Santa Rosa", 74 },
                    { 740105, "Villa de Merlo", 74 },
                    { 740108, "Desaguadero", 74 },
                    { 740112, "El Volcán", 74 },
                    { 740119, "Juana Koslay", 74 },
                    { 740126, "La Punta", 74 },
                    { 740130, "Potrero de los Funes", 74 },
                    { 740133, "San Luis", 74 },
                    { 740140, "San Martín", 74 },
                    { 746007, "Leandro N. Alem", 74 },
                    { 746014, "La Calera", 74 },
                    { 746021, "Nogolí", 74 },
                    { 746028, "Villa de la Quebrada", 74 },
                    { 746035, "La Carolina", 74 },
                    { 746049, "Fraga", 74 },
                    { 746063, "Saladillo", 74 },
                    { 746070, "Cortaderas", 74 },
                    { 746077, "Papagayos", 74 },
                    { 746084, "Renca", 74 },
                    { 746091, "San Pablo", 74 },
                    { 746098, "Villa del Carmen", 74 },
                    { 746105, "Villa Larca", 74 },
                    { 746112, "San José del Morro", 74 },
                    { 746119, "Juan Jorba", 74 },
                    { 746126, "Juan Llerena", 74 },
                    { 746133, "La Punilla", 74 },
                    { 746140, "Lavaisse", 74 },
                    { 746147, "Anchorena", 74 },
                    { 746154, "Arizona", 74 },
                    { 746161, "Bagual", 74 },
                    { 746168, "Batavia", 74 },
                    { 746175, "Fortín El Patria", 74 },
                    { 746182, "Fortuna", 74 },
                    { 746189, "Navia", 74 },
                    { 746196, "Nueva Galia", 74 },
                    { 746210, "Lafinur", 74 },
                    { 746217, "Los Molles", 74 },
                    { 746224, "Talita", 74 },
                    { 746231, "Alto Pelado", 74 },
                    { 746238, "Alto Pencoso", 74 },
                    { 746245, "Balde", 74 },
                    { 746252, "Beazley", 74 },
                    { 746273, "San Jerónimo", 74 },
                    { 746280, "Zanjitas", 74 },
                    { 746287, "La Vertiente", 74 },
                    { 746294, "Las Aguadas", 74 },
                    { 746301, "Las Chacras", 74 },
                    { 746308, "Las Lagunas", 74 },
                    { 746315, "Paso Grande", 74 },
                    { 746322, "Villa de Praga", 74 },
                    { 820007, "Armstrong", 82 },
                    { 820014, "Las Parejas", 82 },
                    { 820021, "Las Rosas", 82 },
                    { 820028, "Casilda", 82 },
                    { 820035, "Frontera", 82 },
                    { 820042, "Rafaela", 82 },
                    { 820045, "San Vicente", 82 },
                    { 820049, "Sunchales", 82 },
                    { 820056, "Villa Constitución", 82 },
                    { 820063, "Firmat", 82 },
                    { 820070, "Rufino", 82 },
                    { 820077, "Venado Tuerto", 82 },
                    { 820084, "Villa Cañás", 82 },
                    { 820091, "Avellaneda", 82 },
                    { 820095, "Florencia", 82 },
                    { 820098, "Las Toscas", 82 },
                    { 820105, "Malabrigo", 82 },
                    { 820112, "Reconquista", 82 },
                    { 820119, "Villa Ocampo", 82 },
                    { 820126, "Cañada de Gómez", 82 },
                    { 820133, "Totoras", 82 },
                    { 820140, "Laguna Paiva", 82 },
                    { 820142, "Recreo", 82 },
                    { 820143, "San José del Rincón", 82 },
                    { 820147, "Santa Fe", 82 },
                    { 820154, "Santo Tomé", 82 },
                    { 820158, "Sauce Viejo", 82 },
                    { 820161, "Esperanza", 82 },
                    { 820168, "San Carlos Centro", 82 },
                    { 820171, "San Jerónimo Norte", 82 },
                    { 820175, "Tostado", 82 },
                    { 820182, "Arroyo Seco", 82 },
                    { 820189, "Funes", 82 },
                    { 820196, "Granadero Baigorria", 82 },
                    { 820203, "Pérez", 82 },
                    { 820207, "Pueblo Esther", 82 },
                    { 820210, "Rosario", 82 },
                    { 820217, "Villa Gobernador Gálvez", 82 },
                    { 820224, "Ceres", 82 },
                    { 820231, "San Cristóbal", 82 },
                    { 820233, "San Guillermo", 82 },
                    { 820235, "Suardi", 82 },
                    { 820237, "Romang", 82 },
                    { 820238, "San Javier", 82 },
                    { 820245, "Coronda", 82 },
                    { 820252, "Gálvez", 82 },
                    { 820256, "San Genaro", 82 },
                    { 820259, "San Justo", 82 },
                    { 820266, "Capitán Bermúdez", 82 },
                    { 820273, "Carcarañá", 82 },
                    { 820280, "Fray Luis Beltrán", 82 },
                    { 820287, "Puerto General San Martín", 82 },
                    { 820294, "Roldán", 82 },
                    { 820301, "San Lorenzo", 82 },
                    { 820308, "El Trébol", 82 },
                    { 820315, "San Jorge", 82 },
                    { 820322, "Sastre y Ortiz", 82 },
                    { 820329, "Calchaquí", 82 },
                    { 820336, "Vera", 82 },
                    { 822007, "Bouquet", 82 },
                    { 822014, "Montes de Oca", 82 },
                    { 822021, "Tortugas", 82 },
                    { 822028, "Arequito", 82 },
                    { 822035, "Arteaga", 82 },
                    { 822042, "Berabevú", 82 },
                    { 822049, "Bigand", 82 },
                    { 822056, "Chabas", 82 },
                    { 822063, "Chañar Ladeado", 82 },
                    { 822070, "Gödeken", 82 },
                    { 822077, "Los Molinos", 82 },
                    { 822084, "Los Quirquinchos", 82 },
                    { 822091, "San José de la Esquina", 82 },
                    { 822098, "Sanford", 82 },
                    { 822105, "Villada", 82 },
                    { 822112, "Angélica", 82 },
                    { 822119, "Ataliva", 82 },
                    { 822126, "Aurelia", 82 },
                    { 822133, "Bauer y Sigel", 82 },
                    { 822140, "Bella Italia", 82 },
                    { 822147, "Colonia Aldao", 82 },
                    { 822154, "Colonia Bicha", 82 },
                    { 822161, "Colonia Bigand", 82 },
                    { 822168, "Castellanos", 82 },
                    { 822175, "Colonia Cello", 82 },
                    { 822182, "Colonia Iturraspe", 82 },
                    { 822189, "Colonia Margarita", 82 },
                    { 822196, "Colonia Raquel", 82 },
                    { 822203, "Coronel Fraga", 82 },
                    { 822210, "Egusquiza", 82 },
                    { 822217, "Esmeralda", 82 },
                    { 822224, "Estación Clucellas", 82 },
                    { 822231, "Eusebia y Carolina", 82 },
                    { 822238, "Eustolia", 82 },
                    { 822245, "Fidela", 82 },
                    { 822252, "Galisteo", 82 },
                    { 822259, "Garibaldi", 82 },
                    { 822266, "Hugentobler", 82 },
                    { 822273, "Humberto Primo", 82 },
                    { 822280, "Josefina", 82 },
                    { 822287, "Lehmann", 82 },
                    { 822294, "María Juana", 82 },
                    { 822301, "Colonia Maua", 82 },
                    { 822308, "Plaza Clucellas", 82 },
                    { 822315, "Presidente Roca", 82 },
                    { 822322, "Pueblo Marini", 82 },
                    { 822329, "Ramona", 82 },
                    { 822336, "Saguier", 82 },
                    { 822343, "San Antonio", 82 },
                    { 822357, "Santa Clara de Saguier", 82 },
                    { 822364, "Susana", 82 },
                    { 822371, "Tacural", 82 },
                    { 822378, "Tacurales", 82 },
                    { 822385, "Vila", 82 },
                    { 822392, "Villa San José", 82 },
                    { 822399, "Virginia", 82 },
                    { 822406, "Zenón Pereyra", 82 },
                    { 822413, "Alcorta", 82 },
                    { 822420, "Bombal", 82 },
                    { 822427, "Cañada Rica", 82 },
                    { 822434, "Cepeda", 82 },
                    { 822441, "Empalme Villa Constitución", 82 },
                    { 822448, "General Gelly", 82 },
                    { 822455, "Godoy", 82 },
                    { 822462, "Juan B. Molina", 82 },
                    { 822469, "Juncal", 82 },
                    { 822476, "La Vanguardia", 82 },
                    { 822483, "Máximo Paz", 82 },
                    { 822490, "Pavón", 82 },
                    { 822497, "Pavón Arriba", 82 },
                    { 822504, "Peyrano", 82 },
                    { 822511, "Rueda", 82 },
                    { 822518, "Santa Teresa", 82 },
                    { 822525, "Sargento Cabral", 82 },
                    { 822532, "Theobald", 82 },
                    { 822539, "Cayastá", 82 },
                    { 822546, "Colonia Mascías", 82 },
                    { 822553, "Helvecia", 82 },
                    { 822560, "Saladero Mariano Cabal", 82 },
                    { 822567, "Santa Rosa de Calchines", 82 },
                    { 822574, "Aarón Castellanos", 82 },
                    { 822581, "Amenábar", 82 },
                    { 822588, "Cafferata", 82 },
                    { 822595, "Cañada del Ucle", 82 },
                    { 822602, "Carmen", 82 },
                    { 822609, "Carreras", 82 },
                    { 822616, "Chapuy", 82 },
                    { 822623, "Chovet", 82 },
                    { 822630, "Christophersen", 82 },
                    { 822637, "Diego de Alvear", 82 },
                    { 822644, "Elortondo", 82 },
                    { 822651, "Hughes", 82 },
                    { 822658, "La Chispa", 82 },
                    { 822665, "Labordeboy", 82 },
                    { 822672, "Lazzarino", 82 },
                    { 822679, "Maggiolo", 82 },
                    { 822686, "María Teresa", 82 },
                    { 822693, "Melincué", 82 },
                    { 822700, "Miguel Torres", 82 },
                    { 822707, "Murphy", 82 },
                    { 822714, "San Eduardo", 82 },
                    { 822721, "San Francisco de Santa Fe", 82 },
                    { 822728, "San Gregorio", 82 },
                    { 822735, "Sancti Spiritu", 82 },
                    { 822742, "Santa Isabel", 82 },
                    { 822749, "Teodelina", 82 },
                    { 822756, "Wheelwright", 82 },
                    { 822763, "Arroyo Ceibal", 82 },
                    { 822770, "Berna", 82 },
                    { 822777, "El Araza", 82 },
                    { 822784, "El Rabón", 82 },
                    { 822791, "El Sombrerito", 82 },
                    { 822805, "Guadalupe Norte", 82 },
                    { 822812, "Ingeniero Chanourdie", 82 },
                    { 822819, "La Sarita", 82 },
                    { 822826, "Lanteri", 82 },
                    { 822833, "Las Garzas", 82 },
                    { 822840, "Los Laureles", 82 },
                    { 822847, "Nicanor Molinas", 82 },
                    { 822854, "San Antonio de Obligado", 82 },
                    { 822861, "Tacuarendi", 82 },
                    { 822868, "Villa Ana", 82 },
                    { 822875, "Villa Guillermina", 82 },
                    { 822882, "Bustinza", 82 },
                    { 822889, "Carrizales", 82 },
                    { 822896, "Classon", 82 },
                    { 822903, "Correa", 82 },
                    { 822910, "Lucio V. López", 82 },
                    { 822917, "Oliveros", 82 },
                    { 822924, "Pueblo Andino", 82 },
                    { 822931, "Salto Grande", 82 },
                    { 822938, "Serodino", 82 },
                    { 822945, "Villa Eloísa", 82 },
                    { 822952, "Arroyo Aguiar", 82 },
                    { 822959, "Arroyo Leyes", 82 },
                    { 822966, "Cabal", 82 },
                    { 822973, "Campo Andino", 82 },
                    { 822980, "Candioti", 82 },
                    { 822987, "Emilia", 82 },
                    { 822994, "Llambí Campbell", 82 },
                    { 823001, "Monte Vera", 82 },
                    { 823008, "Nelson", 82 },
                    { 823036, "Cavour", 82 },
                    { 823043, "San José", 82 },
                    { 823050, "Cululú", 82 },
                    { 823057, "Elisa", 82 },
                    { 823064, "Empalme San Carlos", 82 },
                    { 823071, "Felicia", 82 },
                    { 823078, "Franck", 82 },
                    { 823085, "Grutly", 82 },
                    { 823092, "Hipatía", 82 },
                    { 823099, "Humboldt", 82 },
                    { 823106, "Ituzaingó", 82 },
                    { 823113, "Jacinto L. Aráuz", 82 },
                    { 823120, "La Pelada", 82 },
                    { 823127, "Las Tunas", 82 },
                    { 823134, "María Luisa", 82 },
                    { 823141, "Matilde", 82 },
                    { 823148, "Nuevo Torino", 82 },
                    { 823155, "Pilar", 82 },
                    { 823162, "Progreso", 82 },
                    { 823169, "Providencia", 82 },
                    { 823176, "Pujato Norte", 82 },
                    { 823183, "Rivadavia", 82 },
                    { 823190, "Sa Pereyra", 82 },
                    { 823197, "San Agustín", 82 },
                    { 823204, "San Carlos Norte", 82 },
                    { 823211, "San Carlos Sud", 82 },
                    { 823218, "San Jerónimo del Sauce", 82 },
                    { 823232, "San Mariano", 82 },
                    { 823239, "Santa Clara de Buena Vista", 82 },
                    { 823246, "Santa María Centro", 82 },
                    { 823253, "Santa María Norte", 82 },
                    { 823260, "Santo Domingo", 82 },
                    { 823267, "Sarmiento", 82 },
                    { 823274, "Soutomayor", 82 },
                    { 823281, "Esteban Rams", 82 },
                    { 823288, "Gato Colorado", 82 },
                    { 823295, "Gregoria Pérez de Denis", 82 },
                    { 823302, "Juan de Garay", 82 },
                    { 823309, "Logroño", 82 },
                    { 823316, "Montefiore", 82 },
                    { 823323, "Pozo Borrado", 82 },
                    { 823330, "San Bernardo", 82 },
                    { 823337, "Santa Margarita", 82 },
                    { 823344, "Villa Minetti", 82 },
                    { 823351, "Acebal", 82 },
                    { 823358, "Albarellos", 82 },
                    { 823365, "Álvarez", 82 },
                    { 823372, "Alvear", 82 },
                    { 823379, "Arminda", 82 },
                    { 823386, "Carmen del Sauce", 82 },
                    { 823393, "Coronel Bogado", 82 },
                    { 823400, "Fighiera", 82 },
                    { 823407, "General Lagos", 82 },
                    { 823414, "Ibarlucea", 82 },
                    { 823421, "Piñero", 82 },
                    { 823435, "Pueblo Muñoz", 82 },
                    { 823442, "Soldini", 82 },
                    { 823449, "Uranga", 82 },
                    { 823456, "Villa Amelia", 82 },
                    { 823463, "Zavalla", 82 },
                    { 823470, "Coronel Domínguez", 82 },
                    { 823477, "Aguará Grande", 82 },
                    { 823484, "Ambrosetti", 82 },
                    { 823491, "Arrufo", 82 },
                    { 823498, "Capivara", 82 },
                    { 823505, "Colonia Ana", 82 },
                    { 823512, "Colonia Bossi", 82 },
                    { 823519, "Colonia Rosa", 82 },
                    { 823526, "Constanza", 82 },
                    { 823533, "Curupaity", 82 },
                    { 823540, "Dos Rosas y La Legua", 82 },
                    { 823547, "Hersilia", 82 },
                    { 823554, "Huanqueros", 82 },
                    { 823561, "La Cabral", 82 },
                    { 823568, "Colonia Clara", 82 },
                    { 823575, "La Lucila", 82 },
                    { 823582, "La Rubia", 82 },
                    { 823589, "Las Avispas", 82 },
                    { 823596, "Las Palmeras", 82 },
                    { 823603, "Moisés Ville", 82 },
                    { 823610, "Monigotes", 82 },
                    { 823617, "Monte Oscuridad", 82 },
                    { 823624, "Ñanducita", 82 },
                    { 823631, "Palacios", 82 },
                    { 823638, "Portugalete", 82 },
                    { 823652, "Santurce", 82 },
                    { 823659, "Soledad", 82 },
                    { 823673, "Villa Saralegui", 82 },
                    { 823680, "Villa Trinidad", 82 },
                    { 823687, "Alejandra", 82 },
                    { 823694, "Cacique Ariacaiquín", 82 },
                    { 823701, "Colonia Durán", 82 },
                    { 823708, "La Brava", 82 },
                    { 823722, "Arocena", 82 },
                    { 823729, "Barrancas", 82 },
                    { 823736, "Bernardo de Irigoyen", 82 },
                    { 823743, "Campo Piaggio", 82 },
                    { 823750, "Casalegno", 82 },
                    { 823757, "Centeno", 82 },
                    { 823764, "Desvío Arijón", 82 },
                    { 823771, "Díaz", 82 },
                    { 823778, "Gaboto", 82 },
                    { 823785, "Gessler", 82 },
                    { 823792, "Irigoyen", 82 },
                    { 823799, "Larrechea", 82 },
                    { 823806, "Loma Alta", 82 },
                    { 823813, "López", 82 },
                    { 823820, "Maciel", 82 },
                    { 823827, "Monje", 82 },
                    { 823834, "San Eugenio", 82 },
                    { 823841, "San Fabián", 82 },
                    { 823862, "Angeloni", 82 },
                    { 823869, "Cayastacito", 82 },
                    { 823876, "Colonia Dolores", 82 },
                    { 823883, "Esther", 82 },
                    { 823890, "Gobernador Crespo", 82 },
                    { 823897, "La Camila", 82 },
                    { 823904, "La Criolla", 82 },
                    { 823911, "La Penca y Caraguatá", 82 },
                    { 823918, "Marcelino Escalada", 82 },
                    { 823925, "Naré", 82 },
                    { 823932, "Pedro Gómez Cello", 82 },
                    { 823939, "Ramayón", 82 },
                    { 823946, "San Bernardo", 82 },
                    { 823953, "San Martín Norte", 82 },
                    { 823960, "Silva", 82 },
                    { 823967, "Vera y Pintado", 82 },
                    { 823974, "Videla", 82 },
                    { 823981, "Aldao", 82 },
                    { 823988, "Coronel Arnold", 82 },
                    { 823995, "Fuentes", 82 },
                    { 824002, "Luis Palacios", 82 },
                    { 824009, "Pujato", 82 },
                    { 824016, "Ricardone", 82 },
                    { 824023, "San Jerónimo Sud", 82 },
                    { 824030, "Timbúes", 82 },
                    { 824037, "Villa Mugueta", 82 },
                    { 824044, "Cañada Rosquín", 82 },
                    { 824051, "Carlos Pellegrini", 82 },
                    { 824058, "Casas", 82 },
                    { 824065, "Castelar", 82 },
                    { 824072, "Colonia Belgrano", 82 },
                    { 824079, "Crispi", 82 },
                    { 824086, "Landeta", 82 },
                    { 824093, "Las Bandurrias", 82 },
                    { 824100, "Las Petacas", 82 },
                    { 824107, "Los Cardos", 82 },
                    { 824114, "María Susana", 82 },
                    { 824121, "Piamonte", 82 },
                    { 824128, "San Martín de las Escobas", 82 },
                    { 824135, "Traill", 82 },
                    { 824142, "Cañada Ombú", 82 },
                    { 824149, "Fortín Olmos", 82 },
                    { 824156, "Garabato", 82 },
                    { 824163, "Golondrina", 82 },
                    { 824170, "Intiyaco", 82 },
                    { 824177, "La Gallareta", 82 },
                    { 824184, "Los Amores", 82 },
                    { 824188, "Los Tábanos", 82 },
                    { 824191, "Margarita", 82 },
                    { 824198, "Tartagal", 82 },
                    { 824205, "Toba", 82 },
                    { 900007, "Burruyacú", 90 },
                    { 900014, "San Miguel de Tucumán", 90 },
                    { 900021, "Alderetes", 90 },
                    { 900028, "Banda del Río Salí", 90 },
                    { 900035, "Concepción", 90 },
                    { 900042, "Famaillá", 90 },
                    { 900049, "Graneros", 90 },
                    { 900056, "Juan Bautista Alberdi", 90 },
                    { 900063, "La Cocha", 90 },
                    { 900070, "Bella Vista", 90 },
                    { 900077, "San Isidro de Lules", 90 },
                    { 900084, "Monteros", 90 },
                    { 900091, "Aguilares", 90 },
                    { 900098, "Simoca", 90 },
                    { 900105, "Tafí del Valle", 90 },
                    { 900112, "Las Talitas", 90 },
                    { 900119, "Tafí Viejo", 90 },
                    { 900126, "Trancas", 90 },
                    { 900133, "Yerba Buena", 90 },
                    { 908007, "7 de Abril", 90 },
                    { 908014, "El Chañar", 90 },
                    { 908021, "El Naranjo y El Sunchal", 90 },
                    { 908028, "El Puestito", 90 },
                    { 908035, "El Timbó", 90 },
                    { 908042, "Garmendia", 90 },
                    { 908049, "Gobernador Piedrabuena", 90 },
                    { 908056, "La Ramada y La Cruz", 90 },
                    { 908063, "Benjamín Aráoz y El Tajamar", 90 },
                    { 908070, "Villa Padre Monti", 90 },
                    { 908077, "Colombres", 90 },
                    { 908084, "Delfín Gallo", 90 },
                    { 908091, "El Bracho y El Cevilar", 90 },
                    { 908098, "El Naranjito", 90 },
                    { 908105, "La Florida y Luisiana", 90 },
                    { 908112, "Las Cejas", 90 },
                    { 908119, "Los Bulacio y Los Villagra", 90 },
                    { 908126, "Los Pereyra", 90 },
                    { 908133, "Los Pérez", 90 },
                    { 908140, "Los Ralos", 90 },
                    { 908147, "Ranchillos y San Miguel", 90 },
                    { 908154, "San Andrés", 90 },
                    { 908161, "Alpachiri y El Molino", 90 },
                    { 908168, "Alto Verde y Los Guchea", 90 },
                    { 908175, "Arcadia", 90 },
                    { 908182, "Gastona y Belicha", 90 },
                    { 908189, "La Trinidad", 90 },
                    { 908196, "Medina", 90 },
                    { 908203, "Lamadrid", 90 },
                    { 908210, "Taco Ralo", 90 },
                    { 908217, "Escaba", 90 },
                    { 908224, "Villa Belgrano", 90 },
                    { 908231, "El Sacrificio", 90 },
                    { 908238, "Huasa Pampa", 90 },
                    { 908245, "Rumi Punco", 90 },
                    { 908252, "San Ignacio", 90 },
                    { 908259, "San José de la Cocha", 90 },
                    { 908266, "Yánima y El Corralito", 90 },
                    { 908273, "Agua Dulce y La Soledad", 90 },
                    { 908280, "El Mojón", 90 },
                    { 908287, "Esquina y Mancopa", 90 },
                    { 908294, "Estación Aráoz y Tacanas", 90 },
                    { 908301, "Las Talas", 90 },
                    { 908308, "Los Gómez", 90 },
                    { 908315, "Los Puestos", 90 },
                    { 908322, "Manuel García Fernández", 90 },
                    { 908329, "Quilmes y Los Sueldos", 90 },
                    { 908336, "Río Colorado", 90 },
                    { 908343, "Santa Rosa de Leales y Laguna Blanca", 90 },
                    { 908350, "Villa de Leales", 90 },
                    { 908357, "El Manantial", 90 },
                    { 908364, "San Felipe y Santa Bárbara", 90 },
                    { 908371, "San Pablo y Villa Nougués", 90 },
                    { 908378, "Acheral", 90 },
                    { 908385, "Amberes", 90 },
                    { 908392, "Capitán Cáceres", 90 },
                    { 908399, "El Cercado", 90 },
                    { 908406, "León Rouges y Santa Rosa", 90 },
                    { 908413, "Los Sosa", 90 },
                    { 908420, "Río Seco", 90 },
                    { 908427, "Santa Lucía", 90 },
                    { 908434, "Sargento Moya", 90 },
                    { 908441, "Soldado Maldonado", 90 },
                    { 908448, "Teniente Berdina", 90 },
                    { 908455, "Villa Quinteros", 90 },
                    { 908462, "El Polear y Los Córdoba", 90 },
                    { 908469, "Los Sarmiento y La Tipa", 90 },
                    { 908476, "Monte Bello", 90 },
                    { 908483, "Santa Ana", 90 },
                    { 908490, "Atahona", 90 },
                    { 908497, "Buena Vista", 90 },
                    { 908504, "Ciudacita", 90 },
                    { 908511, "Manuela Pedraza", 90 },
                    { 908518, "Monteagudo", 90 },
                    { 908525, "Pampa Mayo", 90 },
                    { 908532, "Río Chico y Nueva Trinidad", 90 },
                    { 908539, "San Pedro y San Antonio", 90 },
                    { 908546, "Santa Cruz y La Tuna", 90 },
                    { 908553, "Villa Chicligasta", 90 },
                    { 908560, "Yerba Buena", 90 },
                    { 908567, "Amaicha del Valle", 90 },
                    { 908574, "Colalao del Valle", 90 },
                    { 908581, "El Mollar", 90 },
                    { 908588, "Raco", 90 },
                    { 908595, "Anca Juli", 90 },
                    { 908602, "El Cadillal", 90 },
                    { 908609, "La Esperanza", 90 },
                    { 908616, "Los Nogales", 90 },
                    { 908623, "Choromoro", 90 },
                    { 908630, "San Pedro de Colalao", 90 },
                    { 908637, "Tapia", 90 },
                    { 908644, "Cevil Redondo", 90 },
                    { 908651, "San Javier", 90 },
                    { 940007, "Río Grande", 94 },
                    { 940014, "Ushuaia", 94 },
                    { 940021, "Tolhuin", 94 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60134);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60218);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60260);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60270);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60274);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60277);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60351);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60408);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60410);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60412);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60466);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60483);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60490);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60497);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60505);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60511);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60515);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60518);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60525);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60532);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60539);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60547);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60553);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60560);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60568);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60574);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60581);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60588);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60595);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60602);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60609);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60616);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60623);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60630);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60638);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60644);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60648);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60651);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60655);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60658);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60665);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60672);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60679);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60686);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60693);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60700);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60707);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60714);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60721);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60728);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60735);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60742);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60749);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60756);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60760);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60763);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60770);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60778);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60784);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60791);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60798);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60805);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60812);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60819);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60826);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60833);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60840);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60847);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60854);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60861);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60868);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60875);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 60882);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100185);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100213);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 100238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140102);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140143);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140185);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140483);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140490);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140497);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140504);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140511);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140518);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140525);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140532);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140539);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140546);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140553);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140560);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140567);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140574);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140581);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140588);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140595);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140602);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140609);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140616);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140623);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140630);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140637);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140644);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140651);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140658);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140665);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140672);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140679);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140686);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140693);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140700);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140707);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140710);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140714);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140721);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140728);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140735);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140742);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140749);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140752);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140754);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140756);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140763);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140770);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140777);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140784);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140791);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140798);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140805);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140812);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140819);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140826);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140833);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140840);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140847);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140854);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140861);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140868);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140875);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140882);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140889);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140896);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140903);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140910);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140917);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140924);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140931);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140938);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140945);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140952);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140959);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140966);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140973);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140980);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140987);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 140994);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141001);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141008);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141015);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141022);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141029);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141036);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141043);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141050);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141057);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141064);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141071);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141078);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141085);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141092);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141099);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141106);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141113);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141120);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141127);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141130);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141132);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141134);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141141);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141148);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141155);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141162);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141169);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141176);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141183);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141190);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141197);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141204);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141211);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141218);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141225);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141232);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141239);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141246);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141253);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141260);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141267);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141274);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141281);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141288);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141295);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141302);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141309);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141316);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141323);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141330);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141337);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141344);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141351);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141358);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141365);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141372);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141375);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141377);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141379);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141386);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141393);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141400);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141407);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141410);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141414);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141421);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141428);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141435);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141442);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141449);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141456);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141463);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141470);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141477);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141484);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141491);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141498);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141505);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141512);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141519);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141526);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141533);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141540);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141547);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141554);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141561);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141568);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141575);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141582);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141589);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141596);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141603);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141610);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141617);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141624);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141631);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141638);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141645);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141652);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141659);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141666);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141673);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141680);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141687);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141694);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141701);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141708);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141715);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141722);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141729);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141736);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 141743);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142483);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142490);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142497);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142504);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142518);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142525);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142532);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142553);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142560);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142567);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142574);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142581);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142588);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142595);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142602);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142609);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142616);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142623);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142630);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142637);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142644);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142651);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142658);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142665);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142672);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142679);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142686);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142693);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142700);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142707);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142714);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142721);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142728);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142735);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142742);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142749);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142756);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142763);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142770);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142777);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142784);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142791);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142798);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142805);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142812);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142819);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142826);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142833);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142840);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142847);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142854);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142861);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142868);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142875);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142882);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142889);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142896);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142917);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142924);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142931);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142938);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142945);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142952);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142959);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142966);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142973);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 142980);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143001);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143008);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143015);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143022);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143029);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143036);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143043);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143050);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143057);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143064);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143071);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143078);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143085);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143092);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143099);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143113);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143120);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143127);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143134);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143141);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143148);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143155);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143162);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143169);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143176);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143183);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143190);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143197);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143204);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143211);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143218);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143225);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143232);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143239);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 143246);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180010);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180059);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180073);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180137);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180143);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180186);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180188);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180318);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180417);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 180455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 220476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 260161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 265007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 265014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 265021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 265028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 268147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300115);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300184);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300185);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300199);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300255);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300297);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300423);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300437);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300483);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 300490);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302376);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302383);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302411);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302453);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302512);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302526);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302596);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302638);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302666);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302780);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302787);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302808);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302836);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302843);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302899);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302927);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302941);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302948);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302955);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302962);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302976);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 302999);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303020);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303027);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303034);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303041);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 303329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309005);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309010);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309015);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309030);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309045);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309050);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309055);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309075);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309080);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309090);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309110);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309120);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309125);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309135);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309143);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309145);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309150);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309155);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309160);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309165);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309180);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309185);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309190);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309192);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309193);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309195);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309205);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309220);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309225);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309230);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309235);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309240);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309250);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309255);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309260);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309275);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309285);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309295);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309300);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309305);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309310);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309325);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309330);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309335);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309340);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309345);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309355);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309365);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309375);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309380);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309395);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309400);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309405);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309410);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309415);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309430);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309435);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309440);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309445);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309450);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309460);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309465);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309470);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309480);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309485);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309495);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309497);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309500);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309505);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309510);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309515);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309520);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309525);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309530);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309535);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309540);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309543);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309545);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309560);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309565);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309575);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309580);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309585);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309590);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309605);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309610);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309615);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309620);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309625);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309635);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309650);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309670);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309680);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309685);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309705);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309710);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309715);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309720);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309730);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309735);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309770);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309775);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309780);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309785);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309790);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309795);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309820);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309825);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309830);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309832);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309880);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309885);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309890);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309895);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309900);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309905);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309917);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309920);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309935);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309940);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309945);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309950);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309955);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309957);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 309965);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 340259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 345070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 349105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380074);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 380406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386060);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386067);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386179);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 386273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420011);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420116);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420158);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 420413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 422007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 425154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 460126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 500126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540483);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540490);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540497);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540501);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540504);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540511);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540518);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 540525);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 580252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 585154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 620273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660290);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 660413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 700133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740038);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740039);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740073);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740095);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740108);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740130);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 740140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 746322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820045);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820095);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820142);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820143);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820158);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820171);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820207);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820233);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820235);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820237);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820256);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 820336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822483);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822490);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822497);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822504);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822511);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822518);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822525);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822532);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822539);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822546);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822553);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822560);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822567);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822574);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822581);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822588);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822595);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822602);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822609);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822616);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822623);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822630);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822637);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822644);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822651);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822658);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822665);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822672);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822679);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822686);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822693);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822700);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822707);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822714);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822721);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822728);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822735);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822742);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822749);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822756);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822763);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822770);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822777);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822784);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822791);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822805);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822812);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822819);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822826);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822833);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822840);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822847);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822854);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822861);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822868);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822875);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822882);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822889);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822896);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822903);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822910);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822917);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822924);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822931);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822938);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822945);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822952);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822959);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822966);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822973);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822980);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822987);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 822994);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823001);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823008);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823036);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823043);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823050);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823057);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823064);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823071);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823078);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823085);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823092);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823099);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823106);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823113);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823120);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823127);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823134);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823141);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823148);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823155);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823162);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823169);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823176);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823183);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823190);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823197);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823204);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823211);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823218);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823232);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823239);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823246);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823253);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823260);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823267);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823274);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823281);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823288);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823295);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823302);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823309);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823316);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823323);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823330);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823337);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823344);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823351);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823358);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823365);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823372);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823379);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823386);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823393);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823400);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823407);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823414);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823421);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823435);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823442);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823449);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823456);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823463);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823470);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823477);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823484);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823491);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823498);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823505);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823512);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823519);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823526);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823533);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823540);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823547);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823554);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823561);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823568);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823575);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823582);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823589);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823596);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823603);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823610);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823617);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823624);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823631);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823638);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823652);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823659);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823673);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823680);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823687);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823694);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823701);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823708);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823722);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823729);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823736);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823743);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823750);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823757);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823764);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823771);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823778);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823785);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823792);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823799);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823806);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823813);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823820);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823827);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823834);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823841);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823862);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823869);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823876);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823883);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823890);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823897);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823904);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823911);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823918);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823925);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823932);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823939);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823946);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823953);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823960);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823967);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823974);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823981);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823988);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 823995);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824002);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824009);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824016);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824023);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824030);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824037);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824044);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824051);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824058);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824065);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824072);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824079);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824086);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824093);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824100);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824107);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824114);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824121);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824128);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824135);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824142);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824149);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824156);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824163);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824170);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824177);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824184);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824188);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824191);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824198);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 824205);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 900133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908021);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908028);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908035);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908042);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908049);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908056);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908063);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908070);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908077);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908084);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908091);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908098);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908105);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908112);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908119);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908126);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908133);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908140);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908147);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908154);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908161);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908168);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908175);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908182);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908189);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908196);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908203);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908210);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908217);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908224);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908231);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908238);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908245);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908252);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908259);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908266);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908273);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908280);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908287);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908294);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908301);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908308);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908315);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908322);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908329);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908336);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908343);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908350);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908357);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908364);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908371);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908378);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908385);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908392);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908399);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908406);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908413);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908420);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908427);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908434);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908441);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908448);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908455);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908462);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908469);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908476);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908483);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908490);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908497);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908504);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908511);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908518);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908525);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908532);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908539);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908546);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908553);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908560);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908567);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908574);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908581);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908588);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908595);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908602);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908609);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908616);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908623);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908630);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908637);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908644);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 908651);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 940007);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 940014);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 940021);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1);
        }
    }
}
