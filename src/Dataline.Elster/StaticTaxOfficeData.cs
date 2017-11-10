// <copyright file="StaticTaxOfficeData.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace Dataline.Elster
{
    /// <summary>
    /// Eine statische Liste von Finanzämtern
    /// </summary>
    internal static class StaticTaxOfficeData
    {
#region Liste der Finanzämter, Stand Januar 2007

        /// <summary>
        /// Liste der Finanzämter, Stand Januar 2007
        /// </summary>
        internal static readonly List<TaxOfficeInfo> Live200701 = new List<TaxOfficeInfo>
            {
                new TaxOfficeInfo(1010, "Saarlouis", true, Province.Saarland),
                new TaxOfficeInfo(1020, "Merzig", true, Province.Saarland),
                new TaxOfficeInfo(1030, "Neunkirchen", true, Province.Saarland),
                new TaxOfficeInfo(1040, "Saarbrücken Am Stadtgraben", true, Province.Saarland),
                new TaxOfficeInfo(1055, "Saarbrücken MainzerStr", true, Province.Saarland),
                new TaxOfficeInfo(1060, "St. Wendel", true, Province.Saarland),
                new TaxOfficeInfo(1070, "Saarbrücken Am Stadtgraben - Außenst. Sulzbach", true, Province.Saarland),
                new TaxOfficeInfo(1075, "Homburg", true, Province.Saarland),
                new TaxOfficeInfo(1085, "Homburg - Außenst. St. Ingbert", true, Province.Saarland),
                new TaxOfficeInfo(1090, "Saarbrücken Am Stadtgraben - Außenst. Völklingen", true, Province.Saarland),

                new TaxOfficeInfo(1113, "Berlin Charlottenburg", true, Province.Berlin),
                new TaxOfficeInfo(1114, "Berlin Kreuzberg", true, Province.Berlin),
                new TaxOfficeInfo(1116, "Berlin Neukölln", true, Province.Berlin),
                new TaxOfficeInfo(1117, "Berlin Reinickendorf", true, Province.Berlin),
                new TaxOfficeInfo(1118, "Berlin Schöneberg", true, Province.Berlin),
                new TaxOfficeInfo(1119, "Berlin Spandau", true, Province.Berlin),
                new TaxOfficeInfo(1120, "Berlin Steglitz", true, Province.Berlin),
                new TaxOfficeInfo(1121, "Berlin Tempelhof", true, Province.Berlin),
                new TaxOfficeInfo(1123, "Berlin Wedding", true, Province.Berlin),
                new TaxOfficeInfo(1124, "Berlin Wilmersdorf", true, Province.Berlin),
                new TaxOfficeInfo(1125, "Berlin Zehlendorf", true, Province.Berlin),
                new TaxOfficeInfo(1127, "Berlin für Körperschaften I", true, Province.Berlin),
                new TaxOfficeInfo(1128, "Berlin Pankow/Weißensee - nur KFZ-Steuer -", true, Province.Berlin),
                new TaxOfficeInfo(1129, "Berlin für Körperschaften III", true, Province.Berlin),
                new TaxOfficeInfo(1130, "Berlin für Körperschaften IV", true, Province.Berlin),
                new TaxOfficeInfo(1131, "Berlin Friedrichsh./Prenzb.", true, Province.Berlin),
                new TaxOfficeInfo(1132, "Berlin Lichtenb./Hohenschh.", true, Province.Berlin),
                new TaxOfficeInfo(1133, "Berlin Hellersdorf/Marzahn", true, Province.Berlin),
                new TaxOfficeInfo(1134, "Berlin Mitte/Tiergarten", true, Province.Berlin),
                new TaxOfficeInfo(1135, "Berlin Pankow/Weißensee", true, Province.Berlin),
                new TaxOfficeInfo(1136, "Berlin Treptow/Köpenick", true, Province.Berlin),
                new TaxOfficeInfo(1137, "Berlin für Körperschaften II", true, Province.Berlin),
                new TaxOfficeInfo(1138, "Berlin für Fahndung und Strafsachen", true, Province.Berlin),

                new TaxOfficeInfo(2111, "Bad Segeberg", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2112, "Eckernförde-Schleswig", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2113, "Elmshorn", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2114, "Eutin", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2115, "Flensburg", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2116, "Dithmarschen, Außenstelle Heide", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2117, "Nordfriesland, Außenstelle Husum", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2118, "Itzehoe", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2119, "Kiel-Nord", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2120, "Kiel-Süd", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2121, "Nordfriesland", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2122, "Lübeck", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2123, "Dithmarschen", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2124, "Neumünster", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2125, "Oldenburg", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2126, "Plön", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2127, "Ratzeburg", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2128, "Rendsburg", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2129, "Eckernförde-Schleswig, Außenstelle Schleswig", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2130, "Stormarn", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2131, "Pinneberg", true, Province.SchleswigHolstein),
                new TaxOfficeInfo(2132, "Bad Segeberg Außenst. Norderstedt", true, Province.SchleswigHolstein),

                new TaxOfficeInfo(2201, "Hamburg Steuerkasse", false, Province.Hamburg),
                new TaxOfficeInfo(2202, "Hamburg-Altona", true, Province.Hamburg),
                new TaxOfficeInfo(2203, "Hamburg-Bergedorf", true, Province.Hamburg),
                new TaxOfficeInfo(2206, "Hamburg-Harburg", true, Province.Hamburg),
                new TaxOfficeInfo(2208, "Hamburg-Wandsbek", true, Province.Hamburg),
                new TaxOfficeInfo(2209, "Hamburg-Oberalster", true, Province.Hamburg),
                new TaxOfficeInfo(2210, "Hamburg f.VerkSt.u.Grundbes-10", false, Province.Hamburg),
                new TaxOfficeInfo(2215, "Hamburg-Barmbek-Uhlenhorst 15 ", true, Province.Hamburg),
                new TaxOfficeInfo(2216, "Hamburg f.VerkSt.u.Grundbes-16", false, Province.Hamburg),
                new TaxOfficeInfo(2217, "Hamburg-Nord", true, Province.Hamburg),
                new TaxOfficeInfo(2220, "Hamburg f.VerkSt.u.Grundbes-20", false, Province.Hamburg),
                new TaxOfficeInfo(2222, "Hamburg-Hansa", true, Province.Hamburg),
                new TaxOfficeInfo(2226, "Hamburg-Nord", true, Province.Hamburg),
                new TaxOfficeInfo(2227, "Hamburg für Großunternehmen", true, Province.Hamburg),
                new TaxOfficeInfo(2228, "Hamburg für Prüfungsdienste und Strafsachen", false, Province.Hamburg),
                new TaxOfficeInfo(2230, "Hamburg f.Verkehrst.u.Grundbes", false, Province.Hamburg),
                new TaxOfficeInfo(2235, "Hamburg f.VerkSt.u.Grundbes-35", false, Province.Hamburg),
                new TaxOfficeInfo(2254, "Hamburg-Eimsbüttel", true, Province.Hamburg),
                new TaxOfficeInfo(2257, "Hamburg-Am Tierpark", true, Province.Hamburg),
                new TaxOfficeInfo(2271, "Hamburg-Barmbek-Uhlenhorst", true, Province.Hamburg),
                new TaxOfficeInfo(2274, "Hamburg-Mitte", true, Province.Hamburg),

                new TaxOfficeInfo(2311, "Alfeld (Leine)", true, Province.Niedersachsen),
                new TaxOfficeInfo(2312, "Bad Gandersheim", true, Province.Niedersachsen),
                new TaxOfficeInfo(2313, "Braunschweig-Altewiekring", true, Province.Niedersachsen),
                new TaxOfficeInfo(2314, "Braunschweig-Wilhelmstr.", true, Province.Niedersachsen),
                new TaxOfficeInfo(2315, "Buchholz in der Nordheide", true, Province.Niedersachsen),
                new TaxOfficeInfo(2316, "Burgdorf", true, Province.Niedersachsen),
                new TaxOfficeInfo(2317, "Celle", true, Province.Niedersachsen),
                new TaxOfficeInfo(2318, "Cuxhaven", true, Province.Niedersachsen),
                new TaxOfficeInfo(2319, "Gifhorn", true, Province.Niedersachsen),
                new TaxOfficeInfo(2320, "Göttingen", true, Province.Niedersachsen),
                new TaxOfficeInfo(2321, "Goslar", true, Province.Niedersachsen),
                new TaxOfficeInfo(2322, "Hameln", true, Province.Niedersachsen),
                new TaxOfficeInfo(2323, "Hannover-Land I", true, Province.Niedersachsen),
                new TaxOfficeInfo(2324, "Hannover-Mitte", true, Province.Niedersachsen),
                new TaxOfficeInfo(2325, "Hannover-Nord", true, Province.Niedersachsen),
                new TaxOfficeInfo(2326, "Hannover-Süd", true, Province.Niedersachsen),
                new TaxOfficeInfo(2327, "Hannover-Land II", true, Province.Niedersachsen),
                new TaxOfficeInfo(2328, "Helmstedt", true, Province.Niedersachsen),
                new TaxOfficeInfo(2329, "Herzberg am Harz", true, Province.Niedersachsen),
                new TaxOfficeInfo(2330, "Hildesheim", true, Province.Niedersachsen),
                new TaxOfficeInfo(2331, "Holzminden", true, Province.Niedersachsen),
                new TaxOfficeInfo(2332, "Lüchow", true, Province.Niedersachsen),
                new TaxOfficeInfo(2333, "Lüneburg", true, Province.Niedersachsen),
                new TaxOfficeInfo(2334, "Nienburg/Weser", true, Province.Niedersachsen),
                new TaxOfficeInfo(2335, "Northeim", true, Province.Niedersachsen),
                new TaxOfficeInfo(2336, "Osterholz-Scharmbeck", true, Province.Niedersachsen),
                new TaxOfficeInfo(2338, "Peine", true, Province.Niedersachsen),
                new TaxOfficeInfo(2340, "Rotenburg (Wümme)", true, Province.Niedersachsen),
                new TaxOfficeInfo(2341, "Soltau", true, Province.Niedersachsen),
                new TaxOfficeInfo(2342, "Hannover-Land I Außenstelle Springe", true, Province.Niedersachsen),
                new TaxOfficeInfo(2343, "Stade", true, Province.Niedersachsen),
                new TaxOfficeInfo(2344, "Stadthagen", true, Province.Niedersachsen),
                new TaxOfficeInfo(2345, "Sulingen", true, Province.Niedersachsen),
                new TaxOfficeInfo(2346, "Syke", true, Province.Niedersachsen),
                new TaxOfficeInfo(2347, "Uelzen", true, Province.Niedersachsen),
                new TaxOfficeInfo(2348, "Verden (Aller)", true, Province.Niedersachsen),
                new TaxOfficeInfo(2349, "Wesermünde", true, Province.Niedersachsen),
                new TaxOfficeInfo(2350, "Winsen (Luhe)", true, Province.Niedersachsen),
                new TaxOfficeInfo(2351, "Wolfenbüttel", true, Province.Niedersachsen),
                new TaxOfficeInfo(2352, "Zeven", true, Province.Niedersachsen),
                new TaxOfficeInfo(2353, "Papenburg", true, Province.Niedersachsen),
                new TaxOfficeInfo(2354, "Aurich", true, Province.Niedersachsen),
                new TaxOfficeInfo(2355, "Bad Bentheim", true, Province.Niedersachsen),
                new TaxOfficeInfo(2356, "Cloppenburg", true, Province.Niedersachsen),
                new TaxOfficeInfo(2357, "Delmenhorst", true, Province.Niedersachsen),
                new TaxOfficeInfo(2358, "Emden", true, Province.Niedersachsen),
                new TaxOfficeInfo(2360, "Leer (Ostfriesland)", true, Province.Niedersachsen),
                new TaxOfficeInfo(2361, "Lingen (Ems)", true, Province.Niedersachsen),
                new TaxOfficeInfo(2362, "Norden", true, Province.Niedersachsen),
                new TaxOfficeInfo(2363, "Nordenham", true, Province.Niedersachsen),
                new TaxOfficeInfo(2364, "Oldenburg (Oldenburg)", true, Province.Niedersachsen),
                new TaxOfficeInfo(2365, "Osnabrück-Land", true, Province.Niedersachsen),
                new TaxOfficeInfo(2366, "Osnabrück-Stadt", true, Province.Niedersachsen),
                new TaxOfficeInfo(2367, "Quakenbrück", true, Province.Niedersachsen),
                new TaxOfficeInfo(2368, "Vechta", true, Province.Niedersachsen),
                new TaxOfficeInfo(2369, "Westerstede", true, Province.Niedersachsen),
                new TaxOfficeInfo(2370, "Wilhelmshaven", true, Province.Niedersachsen),
                new TaxOfficeInfo(2371, "Wittmund", true, Province.Niedersachsen),
                new TaxOfficeInfo(2380, "Braunschweig für Großbetriebsprüfung", true, Province.Niedersachsen),
                new TaxOfficeInfo(2381, "Göttingen für Großbetriebsprüfung", true, Province.Niedersachsen),
                new TaxOfficeInfo(2382, "Hannover für Großbetriebsprüfung", true, Province.Niedersachsen),
                new TaxOfficeInfo(2384, "Stade für Großbetriebsprüfung", true, Province.Niedersachsen),
                new TaxOfficeInfo(2385, "Oldenburg für Großbetriebsprüfung", true, Province.Niedersachsen),
                new TaxOfficeInfo(2386, "Osnabrück für Großbetriebsprüfung", true, Province.Niedersachsen),
                new TaxOfficeInfo(2390, "Braunschweig für Fahndung und Strafsachen", true, Province.Niedersachsen),
                new TaxOfficeInfo(2391, "Hannover für Fahndung und Strafsachen", true, Province.Niedersachsen),
                new TaxOfficeInfo(2392, "Lüneburg für Fahndung und Strafsachen", true, Province.Niedersachsen),
                new TaxOfficeInfo(2393, "Oldenburg für Fahndung und Strafsachen", true, Province.Niedersachsen),

                new TaxOfficeInfo(2457, "Bremen-Mitte Bewertung", true, Province.Bremen),
                new TaxOfficeInfo(2471, "Bremen-Mitte", true, Province.Bremen),
                new TaxOfficeInfo(2472, "Bremen-Ost", true, Province.Bremen),
                new TaxOfficeInfo(2473, "Bremen-West", true, Province.Bremen),
                new TaxOfficeInfo(2474, "Bremen-Nord", true, Province.Bremen),
                new TaxOfficeInfo(2475, "Bremerhaven", true, Province.Bremen),
                new TaxOfficeInfo(2476, "Bremen-Mitte Kraftfahrzeugsteuer", true, Province.Bremen),
                new TaxOfficeInfo(2477, "Bremerhaven Bewertung", true, Province.Bremen),
                new TaxOfficeInfo(2478, "Bremen für Großbetriebsprüfung", true, Province.Bremen),
                new TaxOfficeInfo(2482, "Bremen-Ost Arbeitnehmerbereich", true, Province.Bremen),
                new TaxOfficeInfo(2483, "Bremen-West Arbeitnehmerbereich", true, Province.Bremen),
                new TaxOfficeInfo(2484, "Bremen-Nord Arbeitnehmerbereich", true, Province.Bremen),
                new TaxOfficeInfo(2485, "Bremerhaven Arbeitnehmerbereich", true, Province.Bremen),

                new TaxOfficeInfo(2601, "Alsfeld-Lauterbach Verwaltungsstelle Alsfeld", true, Province.Hessen),
                new TaxOfficeInfo(2602, "Hersfeld-Rotenburg Verwaltungsstelle Bad Hersfeld", true, Province.Hessen),
                new TaxOfficeInfo(2603, "Bad Homburg v.d. Höhe", true, Province.Hessen),
                new TaxOfficeInfo(2604, "Rheingau-Taunus Verwaltungsst. Bad Schwalbach", true, Province.Hessen),
                new TaxOfficeInfo(2605, "Bensheim", true, Province.Hessen),
                new TaxOfficeInfo(2606, "Marburg-Biedenkopf Verwaltungsstelle Biedenkopf", true, Province.Hessen),
                new TaxOfficeInfo(2607, "Darmstadt", true, Province.Hessen),
                new TaxOfficeInfo(2608, "Dieburg", true, Province.Hessen),
                new TaxOfficeInfo(2609, "Dillenburg", true, Province.Hessen),
                new TaxOfficeInfo(2610, "Eschwege-Witzenhausen Verwaltungsstelle Eschwege", true, Province.Hessen),
                new TaxOfficeInfo(2611, "Korbach-Frankenberg Verwaltungsstelle Frankenberg", true, Province.Hessen),
                new TaxOfficeInfo(2612, "Frankfurt am Main II", true, Province.Hessen),
                new TaxOfficeInfo(2613, "Frankfurt am Main I", true, Province.Hessen),
                new TaxOfficeInfo(2614, "Frankfurt am Main IV", true, Province.Hessen),
                new TaxOfficeInfo(2615, "Frankfurt/M. V-Höchst Verwaltungsstelle Höchst", true, Province.Hessen),
                new TaxOfficeInfo(2616, "Friedberg (Hessen)", true, Province.Hessen),
                new TaxOfficeInfo(2617, "Bensheim Außenstelle Fürth", true, Province.Hessen),
                new TaxOfficeInfo(2618, "Fulda", true, Province.Hessen),
                new TaxOfficeInfo(2619, "Gelnhausen", true, Province.Hessen),
                new TaxOfficeInfo(2620, "Gießen", true, Province.Hessen),
                new TaxOfficeInfo(2621, "Groß-Gerau", true, Province.Hessen),
                new TaxOfficeInfo(2622, "Hanau", true, Province.Hessen),
                new TaxOfficeInfo(2623, "Kassel-Hofgeismar Verwaltungsstelle Hofgeismar", true, Province.Hessen),
                new TaxOfficeInfo(2624, "Schwalm-Eder Verwaltungsstelle Fritzlar", true, Province.Hessen),
                new TaxOfficeInfo(2625, "Kassel-Spohrstraße", true, Province.Hessen),
                new TaxOfficeInfo(2626, "Kassel-Hofgeismar Verwaltungsstelle Kassel", true, Province.Hessen),
                new TaxOfficeInfo(2627, "Korbach-Frankenberg Verwaltungsstelle Korbach", true, Province.Hessen),
                new TaxOfficeInfo(2628, "Langen", true, Province.Hessen),
                new TaxOfficeInfo(2629, "Alsfeld-Lauterbach Verwaltungsstelle Lauterbach", true, Province.Hessen),
                new TaxOfficeInfo(2630, "Limburg-Weilburg Verwaltungsstelle Limburg", true, Province.Hessen),
                new TaxOfficeInfo(2631, "Marburg-Biedenkopf Verwaltungsstelle Marburg", true, Province.Hessen),
                new TaxOfficeInfo(2632, "Schwalm-Eder Verwaltungsstelle Melsungen", true, Province.Hessen),
                new TaxOfficeInfo(2633, "Michelstadt", true, Province.Hessen),
                new TaxOfficeInfo(2634, "Nidda", true, Province.Hessen),
                new TaxOfficeInfo(2635, "Offenbach am Main-Stadt", true, Province.Hessen),
                new TaxOfficeInfo(2636, "Hersfeld-Rotenburg Verwaltungsstelle Rotenburg", true, Province.Hessen),
                new TaxOfficeInfo(2637, "Rheingau-Taunus Verwaltungsstelle Rüdesheim", true, Province.Hessen),
                new TaxOfficeInfo(2638, "Limburg-Weilburg Verwaltungsstelle Weilburg", true, Province.Hessen),
                new TaxOfficeInfo(2639, "Wetzlar", true, Province.Hessen),
                new TaxOfficeInfo(2640, "Wiesbaden I", true, Province.Hessen),
                new TaxOfficeInfo(2641, "Eschwege-Witzenhausen Verwaltungsstelle Witzenhausen", true, Province.Hessen),
                new TaxOfficeInfo(2642, "Schwalm-Eder Verwaltungsstelle Schwalmstadt", true, Province.Hessen),
                new TaxOfficeInfo(2643, "Wiesbaden II", true, Province.Hessen),
                new TaxOfficeInfo(2644, "Offenbach am Main-Land", true, Province.Hessen),
                new TaxOfficeInfo(2645, "Frankfurt am Main III", true, Province.Hessen),
                new TaxOfficeInfo(2646, "Hofheim am Taunus", true, Province.Hessen),
                new TaxOfficeInfo(2647, "Frankfurt/M. V-Höchst Verwaltungsstelle Frankfurt", true, Province.Hessen),

                new TaxOfficeInfo(2701, "Bad Neuenahr-Ahrweiler", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2702, "Altenkirchen-Hachenburg", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2703, "Bingen-Alzey Aussenstelle Alzey", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2706, "Bad Kreuznach", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2707, "Bernkastel-Wittlich Aussenstelle Bernkastel-Kues", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2708, "Bingen-Alzey", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2709, "Idar-Oberstein", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2710, "Bitburg-Prüm", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2713, "Daun", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2714, "Montabaur-Diez Aussenstelle Diez", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2715, "Frankenthal", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2716, "Speyer-Germersheim Aussenstelle Germersheim", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2718, "Altenkirchen-Hachenburg Aussenstelle Hachenburg", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2719, "Kaiserslautern", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2721, "Worms-Kirchheimbolanden Aussenstelle Kirchheimbolanden", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2722, "Koblenz", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2723, "Kusel-Landstuhl", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2724, "Landau", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2725, "Kusel-Landstuhl Aussenstelle Landstuhl", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2726, "Mainz-Mitte", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2727, "Ludwigshafen", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2728, "Mainz-Süd", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2729, "Mayen", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2730, "Montabaur-Diez", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2731, "Neustadt", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2732, "Neuwied", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2735, "Pirmasens-Zweibrücken", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2736, "Bitburg-Prüm Aussenstelle Prüm", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2738, "Sankt Goarshausen-Sankt Goar Aussenstelle Sankt Goar", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2739, "Sankt Goarshausen-Sankt Goar", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2740, "Simmern-Zell", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2741, "Speyer-Germersheim", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2742, "Trier", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2743, "Bernkastel-Wittlich", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2744, "Worms-Kirchheimbolanden", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2745, "Simmern-Zell Aussenstelle Zell", true, Province.RheinlandPfalz),
                new TaxOfficeInfo(2746, "Pirmasens-Zweibrücken Aussenstelle Zweibrücken", true, Province.RheinlandPfalz),

                new TaxOfficeInfo(2801, "Offenburg Außenstelle Achern", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2804, "Villingen-Schwenningen Außenstelle Donaueschingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2805, "Emmendingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2806, "Freiburg-Stadt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2807, "Freiburg-Land", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2808, "Offenburg Außenstelle Kehl", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2809, "Konstanz", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2810, "Lahr", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2811, "Lörrach", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2812, "Müllheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2813, "Freiburg-Land Außenstelle Titisee-Neustadt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2814, "Offenburg", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2815, "Rottweil Außenstelle Oberndorf", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2816, "Waldshut-Tiengen Außenstelle Bad Säckingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2818, "Singen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2819, "Rottweil", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2820, "Waldshut-Tiengen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2821, "Tuttlingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2822, "Villingen-Schwenningen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2823, "Offenburg Außenstelle Wolfach", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2830, "Bruchsal", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2831, "Ettlingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2832, "Heidelberg", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2833, "Baden-Baden", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2834, "Karlsruhe-Durlach", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2835, "Karlsruhe-Stadt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2836, "Baden-Baden Außenstelle Bühl", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2837, "Mannheim-Neckarstadt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2838, "Mannheim-Stadt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2839, "Rastatt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2840, "Mosbach", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2841, "Pforzheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2842, "Freudenstadt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2843, "Schwetzingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2844, "Sinsheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2845, "Calw", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2846, "Mosbach Außenstelle Walldürn", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2847, "Weinheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2848, "Mühlacker", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2849, "Pforzheim Außenstelle Neuenbürg", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2850, "Aalen / Württemberg", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2851, "Backnang", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2852, "Tauberbischofsheim Außenstelle Bad Mergentheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2853, "Balingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2854, "Biberach", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2855, "Bietigheim-Bissingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2856, "Böblingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2857, "Schwäbisch Hall Außenstelle Crailsheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2858, "Ehingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2859, "Esslingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2861, "Friedrichshafen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2862, "Göppingen Außenstelle Geislingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2863, "Göppingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2864, "Heidenheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2865, "Heilbronn", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2869, "Nürtingen Außenstelle Kirchheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2870, "Leonberg", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2871, "Ludwigsburg", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2874, "Nürtingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2876, "Öhringen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2877, "Ravensburg", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2878, "Reutlingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2879, "Biberach Außenstelle Riedlingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2880, "Tauberbischofsheim", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2881, "Sigmaringen Außenstelle Bad Saulgau", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2882, "Schorndorf", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2883, "Schwäbisch Gmünd", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2884, "Schwäbisch Hall", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2885, "Sigmaringen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2886, "Tübingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2887, "Überlingen (Bodensee)", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2888, "Ulm", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2889, "Bad Urach", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2890, "Waiblingen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2891, "Wangen", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2892, "Stuttgart IV", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2893, "Stuttgart I", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2895, "Stuttgart II", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2896, "Stuttgart Zentrales Konzernprüfungsamt", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2897, "Stuttgart III", true, Province.BadenWuerttemberg),
                new TaxOfficeInfo(2899, "Stuttgart-Körpersch.", true, Province.BadenWuerttemberg),

                new TaxOfficeInfo(3046, "Potsdam-Stadt", true, Province.Brandenburg),
                new TaxOfficeInfo(3047, "Potsdam-Land", true, Province.Brandenburg),
                new TaxOfficeInfo(3048, "Brandenburg", true, Province.Brandenburg),
                new TaxOfficeInfo(3049, "Königs Wusterhausen", true, Province.Brandenburg),
                new TaxOfficeInfo(3050, "Luckenwalde", true, Province.Brandenburg),
                new TaxOfficeInfo(3051, "Nauen", true, Province.Brandenburg),
                new TaxOfficeInfo(3052, "Kyritz", true, Province.Brandenburg),
                new TaxOfficeInfo(3053, "Oranienburg", true, Province.Brandenburg),
                new TaxOfficeInfo(3054, "Pritzwalk", true, Province.Brandenburg),
                new TaxOfficeInfo(3056, "Cottbus", true, Province.Brandenburg),
                new TaxOfficeInfo(3057, "Calau", true, Province.Brandenburg),
                new TaxOfficeInfo(3058, "Finsterwalde", true, Province.Brandenburg),
                new TaxOfficeInfo(3061, "Frankfurt (Oder)", true, Province.Brandenburg),
                new TaxOfficeInfo(3062, "Angermünde", true, Province.Brandenburg),
                new TaxOfficeInfo(3063, "Fürstenwalde", true, Province.Brandenburg),
                new TaxOfficeInfo(3064, "Strausberg", true, Province.Brandenburg),
                new TaxOfficeInfo(3065, "Eberswalde", true, Province.Brandenburg),

                new TaxOfficeInfo(3101, "Magdeburg I", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3102, "Magdeburg II", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3103, "Genthin", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3104, "Halberstadt", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3105, "Haldensleben", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3106, "Salzwedel", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3107, "Staßfurt", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3108, "Stendal", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3109, "Wernigerode", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3110, "Halle-Süd", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3111, "Halle-Nord", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3112, "Merseburg", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3113, "Bitterfeld", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3114, "Dessau", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3115, "Wittenberg", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3116, "Köthen", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3117, "Quedlinburg", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3118, "Eisleben", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3119, "Naumburg", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3120, "Zeitz", true, Province.SachsenAnhalt),
                new TaxOfficeInfo(3121, "Sangerhausen", true, Province.SachsenAnhalt),

                new TaxOfficeInfo(3201, "Dresden I", true, Province.Sachsen),
                new TaxOfficeInfo(3202, "Dresden II", true, Province.Sachsen),
                new TaxOfficeInfo(3203, "Dresden III", true, Province.Sachsen),
                new TaxOfficeInfo(3204, "Bautzen", true, Province.Sachsen),
                new TaxOfficeInfo(3205, "Bischofswerda", true, Province.Sachsen),
                new TaxOfficeInfo(3206, "Freital", true, Province.Sachsen),
                new TaxOfficeInfo(3207, "Görlitz", true, Province.Sachsen),
                new TaxOfficeInfo(3208, "Löbau", true, Province.Sachsen),
                new TaxOfficeInfo(3209, "Meißen", true, Province.Sachsen),
                new TaxOfficeInfo(3210, "Pirna", true, Province.Sachsen),
                new TaxOfficeInfo(3213, "Hoyerswerda", true, Province.Sachsen),
                new TaxOfficeInfo(3214, "Chemnitz-Süd", true, Province.Sachsen),
                new TaxOfficeInfo(3215, "Chemnitz-Mitte", true, Province.Sachsen),
                new TaxOfficeInfo(3217, "Annaberg", true, Province.Sachsen),
                new TaxOfficeInfo(3218, "Schwarzenberg", true, Province.Sachsen),
                new TaxOfficeInfo(3220, "Freiberg", true, Province.Sachsen),
                new TaxOfficeInfo(3221, "Hohenstein-Ernstthal", true, Province.Sachsen),
                new TaxOfficeInfo(3222, "Mittweida", true, Province.Sachsen),
                new TaxOfficeInfo(3223, "Plauen", true, Province.Sachsen),
                new TaxOfficeInfo(3224, "Stollberg", true, Province.Sachsen),
                new TaxOfficeInfo(3226, "Zwickau-Stadt", true, Province.Sachsen),
                new TaxOfficeInfo(3227, "Zwickau-Land", true, Province.Sachsen),
                new TaxOfficeInfo(3228, "Zschopau", true, Province.Sachsen),
                new TaxOfficeInfo(3230, "Leipzig I", true, Province.Sachsen),
                new TaxOfficeInfo(3231, "Leipzig II", true, Province.Sachsen),
                new TaxOfficeInfo(3232, "Leipzig III", true, Province.Sachsen),
                new TaxOfficeInfo(3235, "Borna", true, Province.Sachsen),
                new TaxOfficeInfo(3236, "Döbeln", true, Province.Sachsen),
                new TaxOfficeInfo(3237, "Eilenburg", true, Province.Sachsen),
                new TaxOfficeInfo(3238, "Grimma", true, Province.Sachsen),
                new TaxOfficeInfo(3239, "Oschatz", true, Province.Sachsen),
                new TaxOfficeInfo(3247, "Finanzamt LSF Sachsen", true, Province.Sachsen),

                new TaxOfficeInfo(4071, "Malchin", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4072, "Neubrandenburg", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4074, "Pasewalk", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4075, "Waren", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4079, "Rostock", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4080, "Wismar", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4081, "Ribnitz-Damgarten", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4082, "Stralsund", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4083, "Bergen", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4084, "Greifswald", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4085, "Wolgast", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4086, "Güstrow", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4087, "Hagenow", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4089, "Schwerin", true, Province.MecklenburgVorpommern),
                new TaxOfficeInfo(4090, "Schwerin", true, Province.MecklenburgVorpommern),

                new TaxOfficeInfo(4151, "Erfurt", true, Province.Thueringen),
                new TaxOfficeInfo(4152, "Sömmerda", true, Province.Thueringen),
                new TaxOfficeInfo(4153, "Weimar", true, Province.Thueringen),
                new TaxOfficeInfo(4154, "Ilmenau", true, Province.Thueringen),
                new TaxOfficeInfo(4155, "Eisenach", true, Province.Thueringen),
                new TaxOfficeInfo(4156, "Gotha", true, Province.Thueringen),
                new TaxOfficeInfo(4157, "Mühlhausen", true, Province.Thueringen),
                new TaxOfficeInfo(4158, "Nordhausen", true, Province.Thueringen),
                new TaxOfficeInfo(4159, "Sondershausen", true, Province.Thueringen),
                new TaxOfficeInfo(4160, "Worbis", true, Province.Thueringen),
                new TaxOfficeInfo(4161, "Gera", true, Province.Thueringen),
                new TaxOfficeInfo(4162, "Jena", true, Province.Thueringen),
                new TaxOfficeInfo(4163, "Rudolstadt", true, Province.Thueringen),
                new TaxOfficeInfo(4164, "Greiz", true, Province.Thueringen),
                new TaxOfficeInfo(4165, "Pößneck", true, Province.Thueringen),
                new TaxOfficeInfo(4166, "Altenburg", true, Province.Thueringen),
                new TaxOfficeInfo(4168, "Bad Salzungen", true, Province.Thueringen),
                new TaxOfficeInfo(4169, "Meiningen", true, Province.Thueringen),
                new TaxOfficeInfo(4170, "Sonneberg", true, Province.Thueringen),
                new TaxOfficeInfo(4171, "Suhl", true, Province.Thueringen),

                new TaxOfficeInfo(5101, "Dinslaken", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5102, "Viersen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5103, "Düsseldorf-Altstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5105, "Düsseldorf-Nord", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5106, "Düsseldorf-Süd", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5107, "Duisburg-Hamborn", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5109, "Duisburg-Süd", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5110, "Essen-Nord", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5111, "Essen-Ost", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5112, "Essen-Süd", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5113, "Geldern", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5114, "Grevenbroich", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5115, "Kempen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5116, "Kleve", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5117, "Krefeld", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5119, "Moers", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5120, "Mülheim an der Ruhr", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5121, "Mönchengladbach-Mitte", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5122, "Neuss II", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5123, "Oberhausen-Nord", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5124, "Oberhausen-Süd", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5125, "Neuss I", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5126, "Remscheid", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5127, "Mönchengladbach-Rheydt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5128, "Solingen-Ost", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5129, "Solingen-West", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5130, "Wesel", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5131, "Wuppertal-Barmen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5132, "Wuppertal-Elberfeld", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5133, "Düsseldorf-Mitte", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5134, "Duisburg-West", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5135, "Hilden", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5139, "Velbert", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5147, "Düsseldorf-Mettmann", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5149, "Rechenzentrum d. FinVew NRW", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5170, "KBP Düsseldorf I für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5171, "KBP Düsseldorf II für Groß- un Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5172, "KBP Essen für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5173, "KBP Krefeld für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5174, "KBP Bergisches Land für Groß-  Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5176, "KBP Mönchengladbach für Groß-  Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5181, "Düsseldorf f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5182, "Essen f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5183, "Wuppertal f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5201, "Aachen-Innenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5202, "Aachen-Kreis", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5203, "Bergheim", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5204, "Bergisch Gladbach", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5205, "Bonn-Innenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5206, "Bonn-Außenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5207, "Düren", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5208, "Erkelenz", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5209, "Euskirchen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5210, "Geilenkirchen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5211, "Schleiden", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5212, "Gummersbach", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5213, "Jülich", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5214, "Köln-Altstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5215, "Köln-Mitte", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5216, "Köln-Porz", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5217, "Köln-Nord", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5218, "Köln-Ost", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5219, "Köln-Süd", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5220, "Siegburg", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5221, "Wipperfürth", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5222, "Sankt Augustin", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5223, "Köln-West", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5224, "Brühl", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5225, "Aachen-Außenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5230, "Leverkusen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5270, "KBP Köln für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5271, "KBP Aachen für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5272, "KBP Bonn für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5281, "Aachen f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5282, "Bonn f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5283, "Köln f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5301, "Ahaus", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5302, "Altena", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5303, "Arnsberg", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5304, "Beckum", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5305, "Bielefeld-Innenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5306, "Bochum-Mitte", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5307, "Borken", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5308, "Bottrop", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5309, "Brilon", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5310, "Bünde", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5311, "Steinfurt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5312, "Coesfeld", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5313, "Detmold", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5314, "Dortmund-West", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5315, "Dortmund-Hörde", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5316, "Dortmund-Unna", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5317, "Dortmund-Ost", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5318, "Gelsenkirchen-Nord", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5319, "Gelsenkirchen-Süd", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5320, "Gladbeck", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5321, "Hagen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5322, "Hamm", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5323, "Hattingen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5324, "Herford", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5325, "Herne-Ost", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5326, "Höxter", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5327, "Ibbenbüren", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5328, "Iserlohn", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5329, "Lemgo", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5330, "Lippstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5331, "Lübbecke", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5332, "Lüdenscheid", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5333, "Lüdinghausen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5334, "Meschede", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5335, "Minden", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5336, "Münster-Außenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5337, "Münster-Innenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5338, "Olpe", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5339, "Paderborn", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5340, "Recklinghausen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5341, "Schwelm", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5342, "Siegen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5343, "Soest", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5344, "Herne-West", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5345, "Warburg", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5346, "Warendorf", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5347, "Wiedenbrück", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5348, "Witten", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5349, "Bielefeld-Außenstadt", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5350, "Bochum-Süd", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5351, "Gütersloh", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5359, "Marl", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5371, "KBP Bielefeld für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5372, "KBP Herne für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5373, "KBP Detmold für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5374, "KBP Dortmund für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5375, "KBP Hagen für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5376, "KBP Münster für Groß- und Konzernbetriebsprüfung", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5381, "Bielefeld f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5382, "Bochum f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5383, "Hagen f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),
                new TaxOfficeInfo(5384, "Münster f. Steuerfahndung und Steuerstrafsachen", true, Province.NordrheinWestfalen),

                new TaxOfficeInfo(9101, "Augsburg-Stadt Arbeitnehmerbereich", true, Province.Bayern),
                new TaxOfficeInfo(9102, "Augsburg-Land", true, Province.Bayern),
                new TaxOfficeInfo(9103, "Augsburg-Stadt", true, Province.Bayern),
                new TaxOfficeInfo(9104, "Bad Tölz -Außenstelle des Finanzamts Wolfratshausen-", true, Province.Bayern),
                new TaxOfficeInfo(9105, "Berchtesgaden-Laufen", true, Province.Bayern),
                new TaxOfficeInfo(9106, "Burghausen", true, Province.Bayern),
                new TaxOfficeInfo(9107, "Dachau", true, Province.Bayern),
                new TaxOfficeInfo(9108, "Deggendorf", true, Province.Bayern),
                new TaxOfficeInfo(9109, "Dillingen", true, Province.Bayern),
                new TaxOfficeInfo(9110, "Dingolfing", true, Province.Bayern),
                new TaxOfficeInfo(9111, "Donauwörth -Außenstelle des Finanzamts Nördlingen-", true, Province.Bayern),
                new TaxOfficeInfo(9112, "Ebersberg", true, Province.Bayern),
                new TaxOfficeInfo(9113, "Eggenfelden", true, Province.Bayern),
                new TaxOfficeInfo(9114, "Erding", true, Province.Bayern),
                new TaxOfficeInfo(9115, "Freising", true, Province.Bayern),
                new TaxOfficeInfo(9117, "Fürstenfeldbruck", true, Province.Bayern),
                new TaxOfficeInfo(9118, "Füssen -Außenstelle des Finanzamts Kaufbeuren-", true, Province.Bayern),
                new TaxOfficeInfo(9119, "Garmisch-Partenkirchen", true, Province.Bayern),
                new TaxOfficeInfo(9120, "Bad Griesbach -Außenstelle des Finanzamts Passau-", true, Province.Bayern),
                new TaxOfficeInfo(9121, "Günzburg", true, Province.Bayern),
                new TaxOfficeInfo(9123, "Immenstadt -Außenstelle des Finanzamts Kempten-", true, Province.Bayern),
                new TaxOfficeInfo(9124, "Ingolstadt", true, Province.Bayern),
                new TaxOfficeInfo(9125, "Kaufbeuren m. ASt Füssen", true, Province.Bayern),
                new TaxOfficeInfo(9126, "Kelheim", true, Province.Bayern),
                new TaxOfficeInfo(9127, "Kempten (Allgäu)", true, Province.Bayern),
                new TaxOfficeInfo(9131, "Landsberg", true, Province.Bayern),
                new TaxOfficeInfo(9132, "Landshut", true, Province.Bayern),
                new TaxOfficeInfo(9133, "Laufen - Außenstelle des FA Berchtesgaden-Laufen-", true, Province.Bayern),
                new TaxOfficeInfo(9134, "Lindau", true, Province.Bayern),
                new TaxOfficeInfo(9138, "Memmingen", true, Province.Bayern),
                new TaxOfficeInfo(9139, "Miesbach", true, Province.Bayern),
                new TaxOfficeInfo(9140, "Mindelheim -Außenstelle des Finanzamts Memmingen-", true, Province.Bayern),
                new TaxOfficeInfo(9141, "Mühldorf", true, Province.Bayern),
                new TaxOfficeInfo(9142, "München f. Körpersch. Bewertung des Grundbesitzes", true, Province.Bayern),
                new TaxOfficeInfo(9143, "München f. Körpersch. Körperschaftsteuer", true, Province.Bayern),
                new TaxOfficeInfo(9144, "München I", true, Province.Bayern),
                new TaxOfficeInfo(9145, "München III", true, Province.Bayern),
                new TaxOfficeInfo(9146, "München IV", true, Province.Bayern),
                new TaxOfficeInfo(9147, "München II", true, Province.Bayern),
                new TaxOfficeInfo(9148, "München V", true, Province.Bayern),
                new TaxOfficeInfo(9149, "München-Zentral Erhebung, Vollstreckung", true, Province.Bayern),
                new TaxOfficeInfo(9150, "Neuburg -Außenstelle des Finanzamts Schrobenhausen-", true, Province.Bayern),
                new TaxOfficeInfo(9151, "Neu-Ulm", true, Province.Bayern),
                new TaxOfficeInfo(9152, "Nördlingen", true, Province.Bayern),
                new TaxOfficeInfo(9153, "Passau mit Außenstellen", true, Province.Bayern),
                new TaxOfficeInfo(9154, "Pfaffenhofen", true, Province.Bayern),
                new TaxOfficeInfo(9156, "Rosenheim m. ASt Wasserburg", true, Province.Bayern),
                new TaxOfficeInfo(9157, "Grafenau", true, Province.Bayern),
                new TaxOfficeInfo(9158, "Schongau - Außenstelle des Finanzamts Weilheim-Schongau -", true, Province.Bayern),
                new TaxOfficeInfo(9159, "Schrobenhausen m. ASt Neuburg ", true, Province.Bayern),
                new TaxOfficeInfo(9161, "Starnberg", true, Province.Bayern),
                new TaxOfficeInfo(9162, "Straubing", true, Province.Bayern),
                new TaxOfficeInfo(9163, "Traunstein", true, Province.Bayern),
                new TaxOfficeInfo(9164, "Viechtach -Außenstelle des Finanzamts Zwiesel-", true, Province.Bayern),
                new TaxOfficeInfo(9166, "Vilshofen -Außenstelle des Finanzamts Passau-", true, Province.Bayern),
                new TaxOfficeInfo(9167, "Wasserburg -Außenstelle des Finanzamts Rosenheim-", true, Province.Bayern),
                new TaxOfficeInfo(9168, "Weilheim-Schongau", true, Province.Bayern),
                new TaxOfficeInfo(9169, "Wolfratshausen", true, Province.Bayern),
                new TaxOfficeInfo(9170, "Zwiesel m. ASt Viechtach", true, Province.Bayern),
                new TaxOfficeInfo(9171, "Eichstätt", true, Province.Bayern),
                new TaxOfficeInfo(9181, "München I Arbeitnehmerbereich", true, Province.Bayern),
                new TaxOfficeInfo(9182, "München II Arbeitnehmerbereich", true, Province.Bayern),
                new TaxOfficeInfo(9183, "München III Arbeitnehmerbereich", true, Province.Bayern),
                new TaxOfficeInfo(9184, "München IV Arbeitnehmerbereich", true, Province.Bayern),
                new TaxOfficeInfo(9185, "München V Arbeitnehmerbereich", true, Province.Bayern),
                new TaxOfficeInfo(9187, "München f. Körpersch.", true, Province.Bayern),
                new TaxOfficeInfo(9189, "München-Zentral Kraftfahrzeugsteuer", false, Province.Bayern),
                new TaxOfficeInfo(9201, "Amberg", true, Province.Bayern),
                new TaxOfficeInfo(9202, "Obernburg a. Main mit Außenstelle Amorbach", true, Province.Bayern),
                new TaxOfficeInfo(9203, "Ansbach mit Außenstellen", true, Province.Bayern),
                new TaxOfficeInfo(9204, "Aschaffenburg", true, Province.Bayern),
                new TaxOfficeInfo(9205, "Bad Kissingen", true, Province.Bayern),
                new TaxOfficeInfo(9206, "Bad Neustadt a.d.S.", true, Province.Bayern),
                new TaxOfficeInfo(9207, "Bamberg", true, Province.Bayern),
                new TaxOfficeInfo(9208, "Bayreuth", true, Province.Bayern),
                new TaxOfficeInfo(9211, "Cham mit Außenstellen", true, Province.Bayern),
                new TaxOfficeInfo(9212, "Coburg", true, Province.Bayern),
                new TaxOfficeInfo(9213, "Dinkelsbühl - Außenstelle des  Finanzamts Ansbach -", true, Province.Bayern),
                new TaxOfficeInfo(9214, "Ebern - Außenstelle des Finanzamts Zeil -", true, Province.Bayern),
                new TaxOfficeInfo(9216, "Erlangen", true, Province.Bayern),
                new TaxOfficeInfo(9217, "Forchheim", true, Province.Bayern),
                new TaxOfficeInfo(9218, "Fürth", true, Province.Bayern),
                new TaxOfficeInfo(9220, "Gunzenhausen", true, Province.Bayern),
                new TaxOfficeInfo(9221, "Hersbruck", true, Province.Bayern),
                new TaxOfficeInfo(9222, "Hilpoltstein", true, Province.Bayern),
                new TaxOfficeInfo(9223, "Hof mit Außenstellen", true, Province.Bayern),
                new TaxOfficeInfo(9224, "Hofheim - Außenstelle des Finanzamts Zeil -", true, Province.Bayern),
                new TaxOfficeInfo(9225, "Karlstadt - Außenstelle des Finanzamts Lohr -", true, Province.Bayern),
                new TaxOfficeInfo(9227, "Kitzingen", true, Province.Bayern),
                new TaxOfficeInfo(9228, "Kronach", true, Province.Bayern),
                new TaxOfficeInfo(9229, "Kulmbach", true, Province.Bayern),
                new TaxOfficeInfo(9230, "Lichtenfels", true, Province.Bayern),
                new TaxOfficeInfo(9231, "Lohr a. Main mit Außenstellen ", true, Province.Bayern),
                new TaxOfficeInfo(9232, "Marktheidenfeld - Außenstelle  des Finanzamts Lohr -", true, Province.Bayern),
                new TaxOfficeInfo(9233, "Münchberg - Außenstelle des Finanzamts Hof -", true, Province.Bayern),
                new TaxOfficeInfo(9234, "Naila - Außenstelle des Finanzamts Hof -", true, Province.Bayern),
                new TaxOfficeInfo(9235, "Neumarkt i.d.Opf.", true, Province.Bayern),
                new TaxOfficeInfo(9236, "Neunburg v. W. - Außenstelle des Finanzamts Schwandorf -", true, Province.Bayern),
                new TaxOfficeInfo(9238, "Nürnberg-Nord", true, Province.Bayern),
                new TaxOfficeInfo(9240, "Nürnberg-Süd", true, Province.Bayern),
                new TaxOfficeInfo(9241, "Nürnberg-Zentral", true, Province.Bayern),
                new TaxOfficeInfo(9242, "Ochsenfurt - Außenstelle des Finanzamts Würzburg -", true, Province.Bayern),
                new TaxOfficeInfo(9244, "Regensburg", true, Province.Bayern),
                new TaxOfficeInfo(9246, "Rothenburg - Außenstelle des Finanzamts Ansbach -", true, Province.Bayern),
                new TaxOfficeInfo(9247, "Schwabach", true, Province.Bayern),
                new TaxOfficeInfo(9248, "Schwandorf mit Außenstelle Neunburg v. W.", true, Province.Bayern),
                new TaxOfficeInfo(9249, "Schweinfurt", true, Province.Bayern),
                new TaxOfficeInfo(9250, "Selb - Außenstelle des Finanzamts Wunsiedel -", true, Province.Bayern),
                new TaxOfficeInfo(9252, "Uffenheim", true, Province.Bayern),
                new TaxOfficeInfo(9253, "Waldmünchen - Außenstelle des  Finanzamts Cham -", true, Province.Bayern),
                new TaxOfficeInfo(9254, "Waldsassen", true, Province.Bayern),
                new TaxOfficeInfo(9255, "Weiden i.d.Opf.", true, Province.Bayern),
                new TaxOfficeInfo(9257, "Würzburg mit Außenstelle Ochsenfurt", true, Province.Bayern),
                new TaxOfficeInfo(9258, "Wunsiedel mit Außenstelle Selb", true, Province.Bayern),
                new TaxOfficeInfo(9259, "Zeil am Main mit Außenstelle Ebern", true, Province.Bayern),
                new TaxOfficeInfo(9260, "Bad Kötzting - Außenstelle des Finanzamts Cham -", true, Province.Bayern),
            };
#endregion

#region Liste der Test-Finanzämter, Stand Januar 2007

        /// <summary>
        /// Liste der Test-Finanzämter, Stand Januar 2007
        /// </summary>
        internal static readonly List<TaxOfficeInfo> Test200701 = new List<TaxOfficeInfo>
            {
                // Saarland
                new TaxOfficeInfo(1096, "Testfinanzamt Saarland", true, Province.Saarland, true),
                new TaxOfficeInfo(1097, "Finanzschule (Edenkoben)", true, Province.Saarland, true),
                new TaxOfficeInfo(1098, "Testfinanzamt/Schulungsfinanzamt Saarland", true, Province.Saarland, true),
                new TaxOfficeInfo(1099, "Test-Landeshauptkasse Saarland", true, Province.Saarland, true),

                // Berlin
                new TaxOfficeInfo(1140, "Berlin - Testsystem MVS", true, Province.Berlin, true),

                // Schleswig-Holstein
                new TaxOfficeInfo(2138, "LFS-I (Schleswig-Holstein)", true, Province.SchleswigHolstein, true),
                new TaxOfficeInfo(2139, "LFS-II (Schleswig-Holstein)", true, Province.SchleswigHolstein, true),

                // Niedersachsen
                new TaxOfficeInfo(2375, "Testfinanzamt Niedersachsen StH -2375-", true, Province.Niedersachsen, true),
                new TaxOfficeInfo(2376, "Testfinanzamt Niedersachsen StO -2376-", true, Province.Niedersachsen, true),
                new TaxOfficeInfo(2377, "Testfinanzamt Niedersachsen -2377-", true, Province.Niedersachsen, true),
                new TaxOfficeInfo(2378, "FH Rinteln Nds. -2378-", true, Province.Niedersachsen, true),
                new TaxOfficeInfo(2379, "LFS Bad Eilsen Nds. -2379-", true, Province.Niedersachsen, true),
                new TaxOfficeInfo(2388, "Testfinanzamt Niedersachsen -2388-", true, Province.Niedersachsen, true),

                // Bremen

                // Hessen
                new TaxOfficeInfo(2653, "Testfinanzamt Hessen -2653-", true, Province.Hessen, true),
                new TaxOfficeInfo(2655, "Testfinanzamt Hessen -2655-", true, Province.Hessen, true),
                new TaxOfficeInfo(2657, "Testfinanzamt Hessen -2657-", true, Province.Hessen, true),
                new TaxOfficeInfo(2658, "Testfinanzamt Hessen -2658-", true, Province.Hessen, true),
                new TaxOfficeInfo(2670, "Testfinanzamt Hessen -2670-", true, Province.Hessen, true),
                new TaxOfficeInfo(2680, "HE_Dam_R_L_306 -2680-", true, Province.Hessen, true),
                new TaxOfficeInfo(2683, "HE_BZF_Ff_II -2683-", true, Province.Hessen, true),
                new TaxOfficeInfo(2684, "HE_BZF_Ff_III -2684-", true, Province.Hessen, true),
                new TaxOfficeInfo(2689, "HE_GI_R_323 -2689-", true, Province.Hessen, true),
                new TaxOfficeInfo(2690, "HE_OFD -2690-", true, Province.Hessen, true),
                new TaxOfficeInfo(2693, "HE_KsS -2693-", true, Province.Hessen, true),
                new TaxOfficeInfo(2694, "HE_KsG_R_200 -2694-", true, Province.Hessen, true),
                new TaxOfficeInfo(2695, "HE_Fd_R_304 -2695-", true, Province.Hessen, true),
                new TaxOfficeInfo(2697, "HE_WI_II_R_752 -2697-", true, Province.Hessen, true),
                new TaxOfficeInfo(2698, "HE_OfS_R_E_104 -2698-", true, Province.Hessen, true),

                // Rheinland-Pfalz
                new TaxOfficeInfo(2749, "Rheinland-Pfalz Testfinanzamt MVS", true, Province.RheinlandPfalz, true),

                // Baden-Württemberg
                new TaxOfficeInfo(2866, "Schulungsfinanzamt Bildungszentrum Ludwigsburg -2866-", true, Province.BadenWuerttemberg, true),
                new TaxOfficeInfo(2867, "Schulungsfinanzamt Bildungszentrum Ludwigsburg -2867-", true, Province.BadenWuerttemberg, true),
                new TaxOfficeInfo(2868, "Schulungsfinanzamt Bildungszentrum Ludwigsburg -2868-", true, Province.BadenWuerttemberg, true),
                new TaxOfficeInfo(2872, "Schulungsfinanzamt Bildungszentrum Schwäbisch Gmünd -2872-", true, Province.BadenWuerttemberg, true),
                new TaxOfficeInfo(2873, "Schulungsfinanzamt Bildungszentrum Schwäbisch Gmünd -2873-", true, Province.BadenWuerttemberg, true),
                new TaxOfficeInfo(2875, "Schulungsfinanzamt Bildungszentrum Schwäbisch Gmünd -2875-", true, Province.BadenWuerttemberg, true),

                // Brandenburg
                new TaxOfficeInfo(3093, "UNIFA-Schul-FA TFA Cottbus", true, Province.Brandenburg, true),
                new TaxOfficeInfo(3094, "UNIFA-Test-FA TFA Cottbus", true, Province.Brandenburg, true),
                new TaxOfficeInfo(3096, "Finanzamt Fachhochschule (Brandenburg)", true, Province.Brandenburg, true),
                new TaxOfficeInfo(3097, "Schul-FA ld. Brandenburg", true, Province.Brandenburg, true),
                new TaxOfficeInfo(3098, "Test-FA TFA Cottbus", true, Province.Brandenburg, true),

                // Sachsen-Anhalt
                new TaxOfficeInfo(3196, "Testfinanzamt Sachsen-Anhalt -3196-", true, Province.SachsenAnhalt, true),
                new TaxOfficeInfo(3198, "Testfinanzamt Sachsen-Anhalt -3198-", true, Province.SachsenAnhalt, true),

                // Sachsen
                new TaxOfficeInfo(3248, "Testfinanzamt LRZS Sachsen (3248)", true, Province.Sachsen, true),

                // Mecklenburg-Vorpommern
                new TaxOfficeInfo(4097, "Testfinanzamt Mecklenburg-Vorpommern (Landesfinanzschule)", true, Province.MecklenburgVorpommern, true),
                new TaxOfficeInfo(4098, "Testfinanzamt Mecklenburg-Vorpommern (Automation)", true, Province.MecklenburgVorpommern, true),

                // Thüringen
                new TaxOfficeInfo(4198, "Testfinanzamt Thüringen", true, Province.Thueringen, true),

                // NRW
                new TaxOfficeInfo(5192, "Testfinanzamt Nordrhein-Westfalen -5192-", true, Province.NordrheinWestfalen, true),

                new TaxOfficeInfo(5400, "Testfinanzamt Nordrhein-Westfalen -5400-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5401, "Testfinanzamt Nordrhein-Westfalen -5401-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5402, "Testfinanzamt Nordrhein-Westfalen -5402-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5403, "Testfinanzamt Nordrhein-Westfalen -5403-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5404, "Testfinanzamt Nordrhein-Westfalen -5404-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5405, "Testfinanzamt Nordrhein-Westfalen -5405-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5406, "Testfinanzamt Nordrhein-Westfalen -5406-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5407, "Testfinanzamt Nordrhein-Westfalen -5407-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5408, "Testfinanzamt Nordrhein-Westfalen -5408-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5409, "Testfinanzamt Nordrhein-Westfalen -5409-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5410, "Testfinanzamt Nordrhein-Westfalen -5410-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5411, "Testfinanzamt Nordrhein-Westfalen -5411-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5412, "Testfinanzamt Nordrhein-Westfalen -5412-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5413, "Testfinanzamt Nordrhein-Westfalen -5413-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5414, "Testfinanzamt Nordrhein-Westfalen -5414-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5415, "Testfinanzamt Nordrhein-Westfalen -5415-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5416, "Testfinanzamt Nordrhein-Westfalen -5416-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5417, "Testfinanzamt Nordrhein-Westfalen -5417-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5418, "Testfinanzamt Nordrhein-Westfalen -5418-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5419, "Testfinanzamt Nordrhein-Westfalen -5419-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5420, "Testfinanzamt Nordrhein-Westfalen -5420-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5421, "Testfinanzamt Nordrhein-Westfalen -5421-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5422, "Testfinanzamt Nordrhein-Westfalen -5422-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5423, "Testfinanzamt Nordrhein-Westfalen -5423-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5424, "Testfinanzamt Nordrhein-Westfalen -5424-", true, Province.NordrheinWestfalen, true),

                new TaxOfficeInfo(5500, "Testfinanzamt Nordrhein-Westfalen -5500-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5501, "Testfinanzamt Nordrhein-Westfalen -5501-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5502, "Testfinanzamt Nordrhein-Westfalen -5502-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5503, "Testfinanzamt Nordrhein-Westfalen -5503-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5504, "Testfinanzamt Nordrhein-Westfalen -5504-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5505, "Testfinanzamt Nordrhein-Westfalen -5505-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5506, "Testfinanzamt Nordrhein-Westfalen -5506-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5507, "Testfinanzamt Nordrhein-Westfalen -5507-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5508, "Testfinanzamt Nordrhein-Westfalen -5508-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5509, "Testfinanzamt Nordrhein-Westfalen -5509-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5510, "Testfinanzamt Nordrhein-Westfalen -5510-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5511, "Testfinanzamt Nordrhein-Westfalen -5511-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5512, "Testfinanzamt Nordrhein-Westfalen -5512-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5513, "Testfinanzamt Nordrhein-Westfalen -5513-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5514, "Testfinanzamt Nordrhein-Westfalen -5514-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5515, "Testfinanzamt Nordrhein-Westfalen -5515-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5516, "Testfinanzamt Nordrhein-Westfalen -5516-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5517, "Testfinanzamt Nordrhein-Westfalen -5517-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5518, "Testfinanzamt Nordrhein-Westfalen -5518-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5519, "Testfinanzamt Nordrhein-Westfalen -5519-", true, Province.NordrheinWestfalen, true),

                new TaxOfficeInfo(5600, "Testfinanzamt Nordrhein-Westfalen -5600-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5601, "Testfinanzamt Nordrhein-Westfalen -5601-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5602, "Testfinanzamt Nordrhein-Westfalen -5602-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5603, "Testfinanzamt Nordrhein-Westfalen -5603-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5604, "Testfinanzamt Nordrhein-Westfalen -5604-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5605, "Testfinanzamt Nordrhein-Westfalen -5605-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5606, "Testfinanzamt Nordrhein-Westfalen -5606-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5607, "Testfinanzamt Nordrhein-Westfalen -5607-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5608, "Testfinanzamt Nordrhein-Westfalen -5608-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5609, "Testfinanzamt Nordrhein-Westfalen -5609-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5610, "Testfinanzamt Nordrhein-Westfalen -5610-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5611, "Testfinanzamt Nordrhein-Westfalen -5611-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5612, "Testfinanzamt Nordrhein-Westfalen -5612-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5613, "Testfinanzamt Nordrhein-Westfalen -5613-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5614, "Testfinanzamt Nordrhein-Westfalen -5614-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5615, "Testfinanzamt Nordrhein-Westfalen -5615-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5616, "Testfinanzamt Nordrhein-Westfalen -5616-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5617, "Testfinanzamt Nordrhein-Westfalen -5617-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5618, "Testfinanzamt Nordrhein-Westfalen -5618-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5619, "Testfinanzamt Nordrhein-Westfalen -5619-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5620, "Testfinanzamt Nordrhein-Westfalen -5620-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5621, "Testfinanzamt Nordrhein-Westfalen -5621-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5622, "Testfinanzamt Nordrhein-Westfalen -5622-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5623, "Testfinanzamt Nordrhein-Westfalen -5623-", true, Province.NordrheinWestfalen, true),
                new TaxOfficeInfo(5624, "Testfinanzamt Nordrhein-Westfalen -5624-", true, Province.NordrheinWestfalen, true),

                // Bayern (Nummernkreis 91xx)
                new TaxOfficeInfo(9172, "Schulungsfinanzamt Deggendorf", true, Province.Bayern, true),
                new TaxOfficeInfo(9173, "Schulungsfinanzamt Ingolstadt", true, Province.Bayern, true),
                new TaxOfficeInfo(9179, "Schulungsfinanzamt Kempten", true, Province.Bayern, true),
                new TaxOfficeInfo(9180, "Schulungsfinanzamt München (München II und ZFA)", true, Province.Bayern, true),
                new TaxOfficeInfo(9186, "Schulungsfinanzamt Rosenheim", true, Province.Bayern, true),
                new TaxOfficeInfo(9197, "Testfinanzamt BAY-BFH Herrsching", true, Province.Bayern, true),
                new TaxOfficeInfo(9198, "Testfinanzamt OF-Bereich München", true, Province.Bayern, true),
                new TaxOfficeInfo(9199, "Schulungsfinanzamt BAY-BFH Herrsching", true, Province.Bayern, true),

                // Bayern (Nummernkreis 92xx)
                new TaxOfficeInfo(9282, "Finanzamt LFS Bayern in Ansbach", true, Province.Bayern, true),
                new TaxOfficeInfo(9283, "Testfinanzamt OFD Nbg. -9283-", true, Province.Bayern, true),
                new TaxOfficeInfo(9296, "Testfinanzamt OFD Nbg. -9296-", true, Province.Bayern, true),
                new TaxOfficeInfo(9299, "Finanzamt Test-FA OFD Nbg.", true, Province.Bayern, true),
            };
#endregion

#region Liste der Änderungen, Stand 2016-03-02

        /// <summary>
        /// Änderungen an den Finanzämtern
        /// </summary>
        internal static readonly Dictionary<DateTime, List<TaxOfficeChange>> Changes = new Dictionary<DateTime, List<TaxOfficeChange>>
            {
                {
                    new DateTime(2007, 3, 12),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(2692, "HE_Wez", true, true),
                            TaxOfficeChange.New(2681, "HE_VFHS", true, true),
                            TaxOfficeChange.New(2678, "HE_LFS", true, true),

                            TaxOfficeChange.SetValid(3230, false),
                            TaxOfficeChange.Change(3232, "Finanzamt Leipzig I"),
                        }
                },
                {
                    new DateTime(2007, 9, 20),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(1140, "Berliner Testfinanzamt 1140"),

                            TaxOfficeChange.New(1194, "Berlin - Betreuungssystem", true, true),
                            TaxOfficeChange.New(1195, "Berlin - Referenzsystem", true, true),
                            TaxOfficeChange.New(1196, "Berlin - Schulungssystem", true, true),
                            TaxOfficeChange.New(1197, "Berlin - Testsystem", true, true),
                            TaxOfficeChange.New(1198, "Berlin - Abnahmesystem", true, true),

                            TaxOfficeChange.SetValid(2114, false),
                            TaxOfficeChange.Change(2125, "Ostholstein"),
                        }
                },
                {
                    new DateTime(2007, 11, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(5225, false),
                        }
                },
                {
                    new DateTime(2007, 11, 15),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(3205, false),
                            TaxOfficeChange.Change(5111, "Essen NordOst"),
                            TaxOfficeChange.Change(5201, "Aachen-Stadt"),
                            TaxOfficeChange.SetValid(4152, false),
                            TaxOfficeChange.SetValid(4153, false),
                            TaxOfficeChange.SetValid(4158, false),
                            TaxOfficeChange.SetValid(4160, false),
                            TaxOfficeChange.SetValid(4163, false),
                            TaxOfficeChange.SetValid(4164, false),
                            TaxOfficeChange.SetValid(4168, false),
                            TaxOfficeChange.SetValid(4169, false),
                            TaxOfficeChange.SetValid(3047, false),
                            TaxOfficeChange.Change(3110, "Halle (Saale)-Süd"),
                            TaxOfficeChange.Change(3111, "Halle (Saale)-Nord"),
                            TaxOfficeChange.Change(3113, "Bitterfeld-Wolfen"),
                            TaxOfficeChange.Change(3114, "Dessau-Roßlau"),
                        }
                },
                {
                    new DateTime(2007, 12, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(5320, false),
                            TaxOfficeChange.SetValid(5110, false),
                        }
                },
                {
                    new DateTime(2008, 2, 25),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(5110, true),
                            TaxOfficeChange.SetValid(5225, true),
                            TaxOfficeChange.SetValid(5320, true),
                            TaxOfficeChange.Change(5110, "Essen-Nord (neu: NordOst)"),
                            TaxOfficeChange.Change(5225, "Aachen-Außenstadt (neu: Stadt)"),
                            TaxOfficeChange.Change(5320, "Gladbeck (neu: Marl)"),
                        }
                },
                {
                    new DateTime(2008, 3, 5),
                    new List<TaxOfficeChange>()
                },
                {
                    new DateTime(2008, 9, 12),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(3247, false),
                            TaxOfficeChange.New(3247, "Testfinanzamt LFS Sachsen", true, true),
                        }
                },
                {
                    new DateTime(2008, 9, 23),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(2497, "Bremen - Schulungssystem", true, true),
                        }
                },
                {
                    new DateTime(2008, 10, 8),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(2241, "Finanzamt Hamburg-Altona 41", true),
                            TaxOfficeChange.New(2242, "Finanzamt Hamburg-Am Tierpark 42", true),
                            TaxOfficeChange.New(2243, "Finanzamt Hamburg-Barmbek-Uhlenhorst 43", true),
                            TaxOfficeChange.New(2244, "Finanzamt Hamburg-Bergedorf 44", true),
                            TaxOfficeChange.New(2245, "Finanzamt Hamburg-Eimsbüttel 45", true),
                            TaxOfficeChange.New(2246, "Finanzamt Hamburg-Hansa 46", true),
                            TaxOfficeChange.New(2247, "Finanzamt Hamburg-Harburg 47", true),
                            TaxOfficeChange.New(2248, "Finanzamt Hamburg-Mitte 48", true),
                            TaxOfficeChange.New(2249, "Finanzamt Hamburg-Nord 49", true),
                            TaxOfficeChange.New(2250, "Finanzamt Hamburg-Oberalster 50", true),
                            TaxOfficeChange.New(2251, "Finanzamt Hamburg-Wandsbek 51", true),
                        }
                },
                {
                    new DateTime(2008, 11, 14),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(1114, "Finanzamt Friedrichshain-Kreuzberg"),
                            TaxOfficeChange.Change(1128, "Prenzlauer Berg - nur Kraftfahrzeugsteuer -"),
                            TaxOfficeChange.Change(1131, "Finanzamt Prenzlauer Berg"),
                            TaxOfficeChange.Change(1132, "Finanzamt Lichtenberg"),
                            TaxOfficeChange.Change(1133, "Finanzamt Marzahn-Hellersdorf"),
                            TaxOfficeChange.Change(1136, "Finanzamt Treptow-Köpenick"),
                        }
                },
                {
                    new DateTime(2008, 12, 11),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(3054, false),
                        }
                },
                {
                    new DateTime(2008, 12, 12),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(5110, "Finanzamt Essen-Nord (neu: NordOst)"),
                            TaxOfficeChange.Change(5225, "Finanzamt Aachen-Außenstadt (neu: Stadt)"),
                            TaxOfficeChange.Change(5320, "Finanzamt Gladbeck (neu: Marl)"),
                        }
                },
                {
                    new DateTime(2009, 1, 14),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2623, "Finanzamt Kassel II-Hofgeismar Verwaltungsstelle Hofgeismar"),
                            TaxOfficeChange.Change(2625, "Finanzamt Kassel I"),
                            TaxOfficeChange.Change(2626, "Finanzamt Kassel II-Hofgeismar Verwaltungsstelle Kassel"),
                            TaxOfficeChange.Change(2635, "Finanzamt Offenbach am Main I"),
                            TaxOfficeChange.Change(2635, "Finanzamt Offenbach am Main II"),
                            TaxOfficeChange.Change(4083, "Finanzamt Stralsund Nebenstelle Bergen"),
                            TaxOfficeChange.Change(4089, "Finanzamt Schwerin Nebenstelle Parchim"),
                        }
                },
                {
                    new DateTime(2009, 4, 9),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2247, "Finanzamt Hamburg-Harburg"),
                            TaxOfficeChange.SetValid(2206, false),
                            TaxOfficeChange.SetValid(2242, false),
                            TaxOfficeChange.SetValid(2243, false),
                            TaxOfficeChange.SetValid(2244, false),
                            TaxOfficeChange.SetValid(2245, false),
                            TaxOfficeChange.SetValid(2246, false),
                            TaxOfficeChange.SetValid(2249, false),
                            TaxOfficeChange.Change(3102, "Finanzamt Magdeburg"),
                            TaxOfficeChange.SetValid(3101, false),
                            TaxOfficeChange.Change(5121, "Finanzamt Mönchengladbach"),
                            TaxOfficeChange.Change(5127, "Finanzamt MG-Rheydt (neu:Möchengladbach)"),
                        }
                },
                {
                    new DateTime(2009, 7, 21),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2208, "Finanzamt Hamburg-Wandsbek 08"),
                            TaxOfficeChange.Change(2251, "Finanzamt Hamburg-Wandsbek"),
                            TaxOfficeChange.SetValid(4085, false),
                        }
                },
                {
                    new DateTime(2009, 8, 11),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(4070, "Finanzamt Neubrandenburg - beschr. Stpfl. Rentenempfänger", true),
                            TaxOfficeChange.Change(9143, "Finanzamt München-Abt. Körperschaften Körperschaftsteuer"),
                            TaxOfficeChange.Change(9144, "Finanzamt München-Abteilung I"),
                            TaxOfficeChange.Change(9145, "Finanzamt München-Abteilung III"),
                            TaxOfficeChange.Change(9146, "Finanzamt München-Abteilung IV"),
                            TaxOfficeChange.Change(9147, "Finanzamt München-Abteilung II"),
                            TaxOfficeChange.Change(9148, "Finanzamt München-Abteilung V"),
                            TaxOfficeChange.Change(9181, "Finanzamt München-Abteilung I Arbeitnehmerbereich"),
                            TaxOfficeChange.Change(9182, "Finanzamt München-Abteilung II Arbeitnehmerbereich"),
                            TaxOfficeChange.Change(9183, "Finanzamt München-Abteilung III Arbeitnehmerbereich"),
                            TaxOfficeChange.Change(9184, "Finanzamt München-Abteilung IV Arbeitnehmerbereich"),
                            TaxOfficeChange.Change(9185, "Finanzamt München-Abteilung V Arbeitnehmerbereich"),
                        }
                },
                {
                    new DateTime(2009, 10, 12),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(2242, "Finanzamt Hamburg-Am Tierpark 42", true),
                            TaxOfficeChange.New(2243, "Finanzamt Hamburg-Barmbek-Uhlenhorst 43", true),
                            TaxOfficeChange.New(2244, "Finanzamt Hamburg-Bergedorf 44", true),
                            TaxOfficeChange.New(2245, "Finanzamt Hamburg-Eimsbüttel 45", true),
                            TaxOfficeChange.New(2246, "Finanzamt Hamburg-Hansa 46", true),
                            TaxOfficeChange.New(2249, "Finanzamt Hamburg-Nord 49", true),

                            TaxOfficeChange.Change(2248, "Finanzamt Hamburg-Mitte"),
                            TaxOfficeChange.Change(2274, "Finanzamt Hamburg-Mitte 74"),
                        }
                },
                {
                    new DateTime(2009, 12, 17),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(2202, false),
                            TaxOfficeChange.SetValid(2208, false),
                            TaxOfficeChange.SetValid(2209, false),
                            TaxOfficeChange.SetValid(2274, false),

                            TaxOfficeChange.Change(2241, "Finanzamt Hamburg-Altona"),
                            TaxOfficeChange.Change(2250, "Finanzamt Hamburg-Oberalster"),
                            TaxOfficeChange.Change(4070, "Finanzamt Neubrandenburg - RIA (Rentenempfänger im Ausland)"),

                            TaxOfficeChange.SetValid(3104, false),
                            TaxOfficeChange.SetValid(3109, false),

                            TaxOfficeChange.New(2795, "Rheinland-Pfalz Testfinanzamt RP - 795", true, true),
                            TaxOfficeChange.New(2796, "Rheinland-Pfalz Testfinanzamt RP - 796", true, true),
                            TaxOfficeChange.New(2797, "Rheinland-Pfalz Testfinanzamt RP - 797", true, true),
                            TaxOfficeChange.New(2798, "Rheinland-Pfalz Testfinanzamt RP - 798", true, true),
                            TaxOfficeChange.New(2799, "Rheinland-Pfalz Testfinanzamt RP - 799", true, true),

                            TaxOfficeChange.Change(2749, "Rheinland-Pfalz Testfinanzamt MVS"),
                        }
                },
                {
                    new DateTime(2010, 3, 30),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2226, "Finanzamt Hamburg-Nord 26"),
                            TaxOfficeChange.Change(2242, "Finanzamt Hamburg-Am Tierpark"),
                            TaxOfficeChange.Change(2249, "Finanzamt Hamburg-Nord"),
                            TaxOfficeChange.Change(2257, "Finanzamt Hamburg-Am Tierpark 57"),
                        }
                },
                {
                    new DateTime(2010, 4, 26),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2222, "Finanzamt Hamburg-Hansa 22"),
                            TaxOfficeChange.Change(2246, "Finanzamt Hamburg-Hansa"),
                        }
                },
                {
                    new DateTime(2010, 5, 11),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2203, "Finanzamt Hamburg-Bergedorf 03"),
                            TaxOfficeChange.Change(2244, "Finanzamt Hamburg-Bergedorf"),
                        }
                },
                {
                    new DateTime(2010, 9, 28),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2243, "Finanzamt Hamburg-Barmbek-Uhlenhorst"),
                            TaxOfficeChange.Change(2271, "Finanzamt Hamburg-Barmbek-Uhlenhorst 71"),

                            TaxOfficeChange.SetValid(4089, false),

                            TaxOfficeChange.New(2660, "Testfinanzamt Hessen -2660-", true, true),
                        }
                },
                {
                    new DateTime(2010, 11, 4),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2245, "Finanzamt Hamburg-Eimsbüttel"),
                            TaxOfficeChange.Change(2254, "Finanzamt Hamburg-Eimsbüttel 54"),

                            TaxOfficeChange.SetValid(3113, false),
                            TaxOfficeChange.SetValid(3121, false),

                            TaxOfficeChange.Change(3116, "Finanzamt Bitterfeld-Wolfen"),
                        }
                },
                {
                    new DateTime(2011, 1, 7),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(3226, false),
                            TaxOfficeChange.Change(3227, "Finanzamt Zwickau"),
                        }
                },
                {
                    new DateTime(2011, 7, 9),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(2203, false),
                            TaxOfficeChange.SetValid(2215, false),
                            TaxOfficeChange.SetValid(2222, false),
                            TaxOfficeChange.SetValid(2226, false),
                            TaxOfficeChange.SetValid(2254, false),
                            TaxOfficeChange.SetValid(2257, false),
                            TaxOfficeChange.SetValid(2271, false),

                            TaxOfficeChange.Change(5325, "Finanzamt Herne"),
                            TaxOfficeChange.Change(5344, "Finanzamt Herne - West (neu: Herne)"),
                        }
                },
                {
                    new DateTime(2011, 9, 19),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(3202, "Finanzamt Dresden-Nord"),
                            TaxOfficeChange.Change(3203, "Finanzamt Dresden-Süd"),
                        }
                },
                {
                    new DateTime(2011, 10, 14),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(3201, false),
                            TaxOfficeChange.SetValid(3120, false),
                        }
                },
                {
                    new DateTime(2012, 1, 10),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(4083, false),
                        }
                },
                {
                    new DateTime(2012, 4, 4),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(9101, "Finanzamt Augsburg-Stadt Arbeitnehmerbereich (101)"),
                            TaxOfficeChange.Change(9103, "Finanzamt Augsburg-Stadt (103)"),
                            TaxOfficeChange.Change(9143, "Finanzamt München-Abt. Körperschaften Körperschaftsteuer (143)"),
                            TaxOfficeChange.Change(9144, "Finanzamt München-Abteilung I (144)"),
                            TaxOfficeChange.Change(9145, "Finanzamt München-Abteilung III (145)"),
                            TaxOfficeChange.Change(9146, "Finanzamt München-Abteilung IV (146)"),
                            TaxOfficeChange.Change(9147, "Finanzamt München-Abteilung II (147)"),
                            TaxOfficeChange.Change(9148, "Finanzamt München-Abteilung V (148)"),
                            TaxOfficeChange.Change(9181, "Finanzamt München-Abteilung I Arbeitnehmerbereich (181)"),
                            TaxOfficeChange.Change(9182, "Finanzamt München-Abteilung II Arbeitnehmerbereich (182)"),
                            TaxOfficeChange.Change(9183, "Finanzamt München-Abteilung III Arbeitnehmerbereich (183)"),
                            TaxOfficeChange.Change(9184, "Finanzamt München-Abteilung IV Arbeitnehmerbereich (184)"),
                            TaxOfficeChange.Change(9185, "Finanzamt München-Abteilung V Arbeitnehmerbereich (185)"),
                        }
                },
                {
                    new DateTime(2012, 6, 21),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(3246, "Schulungsfinanzamt ABZ/FHSV Sachsen (3246)", true, true),
                            TaxOfficeChange.Change(3247, "Testfinanzamt LSF Sachsen (3247)"),
                            TaxOfficeChange.Change(3248, "Testfinanzamt LRZS Sachsen (3248)"),
                        }
                },
                {
                    new DateTime(2012, 10, 16),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(2460, "Finanzamt Bremen", true),
                            TaxOfficeChange.SetValid(5110, false),
                            TaxOfficeChange.SetValid(5125, false),
                            TaxOfficeChange.SetValid(5127, false),
                            TaxOfficeChange.SetValid(5225, false),
                            TaxOfficeChange.SetValid(5320, false),
                            TaxOfficeChange.SetValid(5344, false),
                            TaxOfficeChange.Change(9143, "Finanzamt München-Abt. Körperschaften (143)"),
                        }
                },
                {
                    new DateTime(2013, 1, 15),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(4074, false),
                            TaxOfficeChange.Change(9145, "Finanzamt München-Abteilung II / III (145)"),
                            TaxOfficeChange.Change(9147, "Finanzamt München-Abteilung II / III (147)"),
                            TaxOfficeChange.Change(9182, "Finanzamt München-Abteilung II / III Arbeitnehmerbereich (182)"),
                            TaxOfficeChange.Change(9183, "Finanzamt München-Abteilung II / III Arbeitnehmerbereich (183)"),
                        }
                },
                {
                    new DateTime(2013, 4, 5),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(9146, "Finanzamt München-Abteilung IV / V (146)", true),
                            TaxOfficeChange.Change(9148, "Finanzamt München-Abteilung IV / V (148)", true),
                            TaxOfficeChange.Change(9184, "Finanzamt München-Abteilung IV / V Arbeitnehmerbereich (184)", true),
                            TaxOfficeChange.Change(9185, "Finanzamt München-Abteilung IV / V Arbeitnehmerbereich (185)", true),

                            TaxOfficeChange.Change(2116, "Finanzamt Dithmarschen", true),
                            TaxOfficeChange.Change(2123, "Finanzamt Dithmarschen Außenstelle Meldorf", true),

                            TaxOfficeChange.Change(5128, "Finanzamt Solingen", true),
                            TaxOfficeChange.Change(5129, "Finanzamt Solingen-West (neu:Solingen)", true),
                        }
                },
                {
                    new DateTime(2013, 4, 12),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(4196, "Schulungsfinanzamt Bildungszentrum Gotha -4196-", true, true),
                            TaxOfficeChange.New(4197, "Testfinanzamt 2 Thüringen -4197-", true, true),
                            TaxOfficeChange.Change(4198, "Testfinanzamt Thüringen -4198-", true),
                        }
                },
                {
                    new DateTime(2013, 7, 8),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(5129, "Finanzamt Solingen-West (neu: Solingen)"),
                            TaxOfficeChange.Change(3110, "Finanzamt Halle (Saale)"),
                            TaxOfficeChange.SetValid(3111, false),
                            TaxOfficeChange.New(4069, "Finanzamt Neubrandenburg - RAB", true),

                            TaxOfficeChange.Change(2653, "HE_Testfinanzamt -2653-", true),
                            TaxOfficeChange.Change(2655, "HE_Testfinanzamt -2655-", true),
                            TaxOfficeChange.Change(2657, "HE_Testfinanzamt -2657-", true),
                            TaxOfficeChange.Change(2658, "HE_Testfinanzamt -2658-", true),
                            TaxOfficeChange.Change(2660, "HE_Testfinanzamt -2660-", true),
                            TaxOfficeChange.Change(2670, "HE_Testfinanzamt -2670-", true),
                            TaxOfficeChange.Change(2678, "HE_Schulung_LFS Rotenburg -2678-", true),
                            TaxOfficeChange.Change(2680, "HE_Schulung_Darmstadt -2680-", true),
                            TaxOfficeChange.Change(2681, "HE_Schulung_VFHS_Rotenburg -2681-", true),
                            TaxOfficeChange.Change(2683, "HE_Schulung_Frankfurt_III -2683-", true),
                            TaxOfficeChange.Change(2684, "HE_Schulung_Frankfurt_II -2684-", true),
                            TaxOfficeChange.Change(2689, "HE_Schulung_Gießen -2689-", true),
                            TaxOfficeChange.Change(2690, "HE_Schulung_OFD -2690-", true),
                            TaxOfficeChange.Change(2692, "HE_Schulung_Wetzlar -2692-", true),
                            TaxOfficeChange.Change(2693, "HE_Schulung_Kassel_I -2693-", true),
                            TaxOfficeChange.Change(2694, "HE_Schulung_Kassel_II_Hofgeismar -2694-", true),
                            TaxOfficeChange.Change(2695, "HE_Schulung_Fulda -2695-", true),
                            TaxOfficeChange.Change(2697, "HE_Schulung_Wiesbaden_II -2697-", true),
                            TaxOfficeChange.Change(2698, "HE_Schulung_Offenbach_I -2698-", true),

                            TaxOfficeChange.New(2662, "HE_Testfinanzamt -2662-", true, true),
                            TaxOfficeChange.New(2663, "HE_Testfinanzamt -2663-", true, true),
                            TaxOfficeChange.New(2679, "HE_Schulung_Bad Homburg -2679-", true, true),
                            TaxOfficeChange.New(2682, "HE_Schulung_Bensheim -2682-", true, true),
                            TaxOfficeChange.New(2685, "HE_Schulung_Groß-Gerau - 2685-", true, true),
                            TaxOfficeChange.New(2686, "HE_Schulung_Hanau -2686-", true, true),
                            TaxOfficeChange.New(2687, "HE_Schulung_Hofheim_am_Taunus -2687-", true, true),
                            TaxOfficeChange.New(2688, "HE_Schulung_Langen -2688-", true, true),
                        }
                },
                {
                    new DateTime(2013, 8, 19),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(3058, false),
                            TaxOfficeChange.New(3249, "Referenzfinanzamt LRZS Sachsen (3249)", true, true),
                        }
                },
                {
                    new DateTime(2013, 8, 29),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(4069, false),
                        }
                },
                {
                    new DateTime(2014, 1, 2),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(2661, "HE_Testfinanzamt -2661-", true, true),
                        }
                },
                {
                    new DateTime(2014, 2, 14),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(2472, false),
                            TaxOfficeChange.SetValid(2473, false),
                            TaxOfficeChange.SetValid(2482, false),
                            TaxOfficeChange.SetValid(2483, false),

                            TaxOfficeChange.Change(2735, "Finanzamt Pirmasens"),

                            TaxOfficeChange.SetValid(2746, false),
                        }
                },
                {
                    new DateTime(2014, 3, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2457, "Bremen-Nord Bewertung", false),
                            TaxOfficeChange.Change(2471, "Bremen-Nord -71-"),
                            TaxOfficeChange.Change(2474, "Bremen-Nord -74-"),
                            TaxOfficeChange.Change(2476, "Bremen-Nord Kraftfahrzeugsteuer", false),
                        }
                },
                {
                    new DateTime(2014, 10, 16),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Redirect(5129, false, 5128),
                        }
                },
                {
                    new DateTime(2014, 12, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Redirect(2713, true, 2743),
                        }
                },
                {
                    new DateTime(2015, 1, 6),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2123, "Dithmarschen (23)"),
                            TaxOfficeChange.Change(2116, "Dithmarschen (16)"),
                            TaxOfficeChange.Change(2129, "Eckernförde-Schleswig"),
                            TaxOfficeChange.Change(2713, "Landesfinanzkasse Daun", false),
                            TaxOfficeChange.Change(2743, "Wittlich"),
                            TaxOfficeChange.Change(9111, "Nördlingen mit ASt Donauwörth (111)"),
                            TaxOfficeChange.Change(9152, "Nördlingen mit ASt Donauwörth (152)"),
                            TaxOfficeChange.Change(9189, "München-Abteilung Erhebung"),
                            TaxOfficeChange.Redirect(2112, false, 2129, 2128),
                            TaxOfficeChange.Redirect(2707, false, 2743),
                        }
                },
                {
                    new DateTime(2015, 2, 25),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2201, "für Steuererhebung in Hamburg"),
                            TaxOfficeChange.Change(2210, "für Verkehrsteuern und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2216, "für Verkehrsteuern und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2220, "für Verkehrsteuern und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2230, "für Verkehrsteuern und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2235, "für Verkehrsteuern und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2217, "Hamburg-Nord (17)"),
                            TaxOfficeChange.Change(2249, "Hamburg-Nord (49)"),
                            TaxOfficeChange.Change(2227, "für Großunternehmen in Hamburg"),
                            TaxOfficeChange.Change(2228, "für Prüfungsdienste und Strafsachen in Hamburg"),
                            TaxOfficeChange.Change(4071, "Malchin siehe FA Waren", false),
                        }
                },
                {
                    new DateTime(2015, 3, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Redirect(4071, false, 4075),
                        }
                },
                {
                    new DateTime(2015, 4, 28),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(1128, false),
                            TaxOfficeChange.New(2734, "Kusel-Landstuhl für Erb/Schenk.St. Saarland", false),
                            TaxOfficeChange.Change(2227, "Hamburg für Großunternehmen in Hamburg"),
                            TaxOfficeChange.Change(2201, "Hamburg für Steuererhebung in Hamburg"),
                            TaxOfficeChange.Change(2210, "Hamburg für Verkehrst. und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2216, "Hamburg für Verkehrst. und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2220, "Hamburg für Verkehrst. und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2228, "Hamburg für Prüfungsd. und Strafsachen in Hamburg"),
                            TaxOfficeChange.Change(2230, "Hamburg für Verkehrst. und Grundbesitz in Hamburg"),
                            TaxOfficeChange.Change(2235, "Hamburg für Verkehrst. und Grundbesitz in Hamburg"),
                        }
                },
                {
                    new DateTime(2015, 5, 27),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(2716, false),
                            TaxOfficeChange.Change(5319, "Gelsenkirchen-Süd"),
                            TaxOfficeChange.Redirect(5318, false, 5319),
                        }
                },
                {
                    new DateTime(2015, 7, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.SetValid(2715, false),
                        }
                },
                {
                    new DateTime(2015, 11, 22),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Redirect(3063, false, 3061),
                        }
                },
                {
                    new DateTime(2016, 1, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(9187, "München-Abt. Körperschaften", false),
                            TaxOfficeChange.New(9188, "München-Abt. Betriebsprüfung", false),
                            TaxOfficeChange.Change(9189, "München-Abt. Erhebung", false),
                        }
                },
                {
                    new DateTime(2016, 6, 27),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Redirect(3235, true, 3238),
                            TaxOfficeChange.Change(3235, "Borna", false),
                        }
                },
                {
                    new DateTime(2016, 9, 22),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(2119, "Kiel (19)"),
                            TaxOfficeChange.Change(2120, "Kiel (20)"),
                            TaxOfficeChange.New(2137, "Zentrale Prüfungsstelle", false),
                            TaxOfficeChange.Change(2471, "Landeshauptkasse Bremen", false),
                            TaxOfficeChange.SetValid(2476, false),
                        }
                },
                {
                    new DateTime(2016, 12, 1),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Redirect(3206, true, 3210),
                            TaxOfficeChange.Change(3206, "Freital", false),
                        }
                },
                {
                    new DateTime(2017, 1, 31),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.New(9272, "Finanzamt SU LFS Bayern Ansbach", false, true),
                            TaxOfficeChange.New(9273, "Finanzamt SU Ausbildung AbAg", false, true),
                            TaxOfficeChange.New(9274, "Finanzamt SU Laufende Fortbildung", false, true),
                            TaxOfficeChange.New(9275, "Finanzamt SU Fortbildung neue EDV-Verf.", false, true),
                            TaxOfficeChange.New(9276, "Finanzamt SU LFS Ansbach Prüfung", false, true),
                        }
                },
                {
                    new DateTime(2017, 6, 2),
                    new List<TaxOfficeChange>()
                        {
                            TaxOfficeChange.Change(9232, "Lohr a. Main mit Außenstellen", false),
                            TaxOfficeChange.Change(9138, "Memmingen-Mindelheim (138)"),
                            TaxOfficeChange.Change(9140, "Memmingen-Mindelheim (140)"),
                            TaxOfficeChange.New(1191, "Technisches Finanzamt Berlin", true),
                            TaxOfficeChange.Change(1127, "für Körperschaften I"),
                            TaxOfficeChange.Change(1129, "für Körperschaften III"),
                            TaxOfficeChange.Change(1130, "für Körperschaften IV"),
                            TaxOfficeChange.Change(1137, "für Körperschaften II"),
                            TaxOfficeChange.Change(2244, "Hamburg-Ost (44)"),
                            TaxOfficeChange.Change(2251, "Hamburg-Ost (51)"),
                            TaxOfficeChange.Redirect(2738, false, 2722),
                            TaxOfficeChange.Redirect(2739, false, 2722),
                            TaxOfficeChange.SetValid(3235, false),
                        }
                },
                {
                    new DateTime(2017, 6, 28),
                    new List<TaxOfficeChange>()
                    {
                        TaxOfficeChange.Change(9142, "München Bewertung des Grundbesitzes"),
                        TaxOfficeChange.Change(9143, "München (143) Körpersch./PersonenGes"),
                        TaxOfficeChange.Change(9144, "München (144) Selbständige/Gewerbe/VuV"),
                        TaxOfficeChange.Change(9145, "München (145) Selbständige/Gewerbe/VuV"),
                        TaxOfficeChange.Change(9146, "München (146) Selbständige/Gewerbe/VuV"),
                        TaxOfficeChange.Change(9147, "München (147) Selbständige/Gewerbe/VuV"),
                        TaxOfficeChange.Change(9148, "München (148) Selbständige/Gewerbe/VuV"),
                        TaxOfficeChange.Change(9149, "München Erhebung"),
                        TaxOfficeChange.Change(9181, "München (181) Arbeitn./Renten/Hausgem"),
                        TaxOfficeChange.Change(9182, "München (182) Arbeitn./Renten/Hausgem"),
                        TaxOfficeChange.Change(9183, "München (183) Arbeitn./Renten/Hausgem"),
                        TaxOfficeChange.Change(9184, "München (184) Arbeitn./Renten/Hausgem"),
                        TaxOfficeChange.Change(9185, "München (185) Arbeitn./Renten/Hausgem"),
                        TaxOfficeChange.Change(9187, "München Körperschaften"),
                        TaxOfficeChange.Change(9188, "München Betriebsprüfung"),
                        TaxOfficeChange.Change(9189, "München Erhebung"),
                        TaxOfficeChange.SetValid(3206, false),
                    }
                },
                {
                    new DateTime(2017, 8, 10),
                    new List<TaxOfficeChange>()
                    {
                        TaxOfficeChange.Redirect(2119, false, 2120),
                        TaxOfficeChange.Change(2120, "Kiel"),
                    }
                },
                {
                    new DateTime(2017, 10, 9),
                    new List<TaxOfficeChange>()
                    {
                        TaxOfficeChange.Change(9123, "Kempten-Immenstadt (123)"),
                        TaxOfficeChange.Change(9127, "Kempten-Immenstadt (127)"),
                        TaxOfficeChange.Change(2457, "Bremerhaven Bewertung Bremen"),
                        TaxOfficeChange.Redirect(2484, false, 2460),
                        TaxOfficeChange.Change(2390, "für Fahndung und Strafsachen Braunschweig"),
                    }
                },
            };
#endregion
    }
}
