﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class addedlocationdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "county",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "MOMBASA" },
                    { 2, "KWALE" },
                    { 3, "KILIFI" },
                    { 4, "TANA RIVER" },
                    { 5, "LAMU" },
                    { 6, "TAITA TAVETA" },
                    { 7, "GARISSA" },
                    { 8, "WAJIR" },
                    { 9, "MANDERA" },
                    { 10, "MARSABIT" },
                    { 11, "ISIOLO" },
                    { 12, "MERU" },
                    { 13, "THARAKA-NITHI" },
                    { 14, "EMBU" },
                    { 15, "KITUI" },
                    { 16, "MACHAKOS" },
                    { 17, "MAKUENI" },
                    { 18, "NYANDARUA" },
                    { 19, "NYERI" },
                    { 20, "KIRINYAGA" },
                    { 21, "MURANG'A" },
                    { 22, "KIAMBU" },
                    { 23, "TURKANA" },
                    { 24, "WEST POKOT" },
                    { 25, "SAMBURU" },
                    { 26, "TRANS NZOIA" },
                    { 27, "UASIN GISHU" },
                    { 28, "ELGEYO/MARAKWET" },
                    { 29, "NANDI" },
                    { 30, "BARINGO" },
                    { 31, "LAIKIPIA" },
                    { 32, "NAKURU" },
                    { 33, "NAROK" },
                    { 34, "KAJIADO" },
                    { 35, "KERICHO" },
                    { 36, "BOMET" },
                    { 37, "KAKAMEGA" },
                    { 38, "VIHIGA" },
                    { 39, "BUNGOMA" },
                    { 40, "BUSIA" },
                    { 41, "SIAYA" },
                    { 42, "KISUMU" },
                    { 43, "HOMA BAY" },
                    { 44, "MIGORI" },
                    { 45, "KISII" },
                    { 46, "NYAMIRA" },
                    { 47, "NAIROBI" }
                });

            migrationBuilder.InsertData(
                table: "subcounty",
                columns: new[] { "id", "fk_county_id", "name" },
                values: new object[,]
                {
                    { 1, 1, "CHANGAMWE" },
                    { 2, 1, "JOMVU" },
                    { 3, 1, "KISAUNI" },
                    { 4, 1, "NYALI" },
                    { 5, 1, "LIKONI" },
                    { 6, 1, "MVITA" },
                    { 7, 2, "MSAMBWENI" },
                    { 8, 2, "LUNGALUNGA" },
                    { 9, 2, "MATUGA" },
                    { 10, 2, "KINANGO" },
                    { 11, 3, "KILIFI NORTH" },
                    { 12, 3, "KILIFI SOUTH" },
                    { 13, 3, "KALOLENI" },
                    { 14, 3, "RABAI" },
                    { 15, 3, "GANZE" },
                    { 16, 3, "MALINDI" },
                    { 17, 3, "MAGARINI" },
                    { 18, 4, "GARSEN" },
                    { 19, 4, "GALOLE" },
                    { 20, 4, "BURA" },
                    { 21, 5, "LAMU EAST" },
                    { 22, 5, "LAMU WEST" },
                    { 23, 6, "TAVETA" },
                    { 24, 6, "WUNDANYI" },
                    { 25, 6, "MWATATE" },
                    { 26, 6, "VOI" },
                    { 27, 7, "GARISSA TOWNSHIP" },
                    { 28, 7, "BALAMBALA" },
                    { 29, 7, "LAGDERA" },
                    { 30, 7, "DADAAB" },
                    { 31, 7, "FAFI" },
                    { 32, 7, "IJARA" },
                    { 33, 8, "WAJIR NORTH" },
                    { 34, 8, "WAJIR EAST" },
                    { 35, 8, "TARBAJ" },
                    { 36, 8, "WAJIR WEST" },
                    { 37, 8, "ELDAS" },
                    { 38, 8, "WAJIR SOUTH" },
                    { 39, 9, "MANDERA WEST" },
                    { 40, 9, "BANISSA" },
                    { 41, 9, "MANDERA NORTH" },
                    { 42, 9, "MANDERA SOUTH" },
                    { 43, 9, "MANDERA EAST" },
                    { 44, 9, "LAFEY" },
                    { 45, 10, "MOYALE" },
                    { 46, 10, "NORTH HORR" },
                    { 47, 10, "SAKU" },
                    { 48, 10, "LAISAMIS" },
                    { 49, 11, "ISIOLO NORTH" },
                    { 50, 11, "ISIOLO SOUTH" },
                    { 51, 12, "IGEMBE SOUTH" },
                    { 52, 12, "IGEMBE CENTRAL" },
                    { 53, 12, "IGEMBE NORTH" },
                    { 54, 12, "TIGANIA WEST" },
                    { 55, 12, "TIGANIA EAST" },
                    { 56, 12, "NORTH IMENTI" },
                    { 57, 12, "BUURI" },
                    { 58, 12, "CENTRAL IMENTI" },
                    { 59, 12, "SOUTH IMENTI" },
                    { 60, 13, "MAARA" },
                    { 61, 13, "CHUKA/IGAMBANG'OM" },
                    { 62, 13, "THARAKA" },
                    { 63, 14, "MANYATTA" },
                    { 64, 14, "RUNYENJES" },
                    { 65, 14, "MBEERE SOUTH" },
                    { 66, 14, "MBEERE NORTH" },
                    { 67, 15, "MWINGI NORTH" },
                    { 68, 15, "MWINGI WEST" },
                    { 69, 15, "MWINGI CENTRAL" },
                    { 70, 15, "KITUI WEST" },
                    { 71, 15, "KITUI RURAL" },
                    { 72, 15, "KITUI CENTRAL" },
                    { 73, 15, "KITUI EAST" },
                    { 74, 15, "KITUI SOUTH" },
                    { 75, 16, "MASINGA" },
                    { 76, 16, "YATTA" },
                    { 77, 16, "KANGUNDO" },
                    { 78, 16, "MATUNGULU" },
                    { 79, 16, "KATHIANI" },
                    { 80, 16, "MAVOKO" },
                    { 81, 16, "MACHAKOS TOWN" },
                    { 82, 16, "MWALA" },
                    { 83, 17, "MBOONI" },
                    { 84, 17, "KILOME" },
                    { 85, 17, "KAITI" },
                    { 86, 17, "MAKUENI" },
                    { 87, 17, "KIBWEZI WEST" },
                    { 88, 17, "KIBWEZI EAST" },
                    { 89, 18, "KINANGOP" },
                    { 90, 18, "KIPIPIRI" },
                    { 91, 18, "OL KALOU" },
                    { 92, 18, "OL JOROK" },
                    { 93, 18, "NDARAGWA" },
                    { 94, 19, "TETU" },
                    { 95, 19, "KIENI" },
                    { 96, 19, "MATHIRA" },
                    { 97, 19, "OTHAYA" },
                    { 98, 19, "MUKURWEINI" },
                    { 99, 19, "NYERI TOWN" },
                    { 100, 20, "MWEA" },
                    { 101, 20, "GICHUGU" },
                    { 102, 20, "NDIA" },
                    { 103, 20, "KIRINYAGA CENTRAL" },
                    { 104, 21, "KANGEMA" },
                    { 105, 21, "MATHIOYA" },
                    { 106, 21, "KIHARU" },
                    { 107, 21, "KIGUMO" },
                    { 108, 21, "MARAGWA" },
                    { 109, 21, "KANDARA" },
                    { 110, 21, "GATANGA" },
                    { 111, 22, "GATUNDU SOUTH" },
                    { 112, 22, "GATUNDU NORTH" },
                    { 113, 22, "JUJA" },
                    { 114, 22, "THIKA TOWN" },
                    { 115, 22, "RUIRU" },
                    { 116, 22, "GITHUNGURI" },
                    { 117, 22, "KIAMBU" },
                    { 118, 22, "KIAMBAA" },
                    { 119, 22, "KABETE" },
                    { 120, 22, "KIKUYU" },
                    { 121, 22, "LIMURU" },
                    { 122, 22, "LARI" },
                    { 123, 23, "TURKANA NORTH" },
                    { 124, 23, "TURKANA WEST" },
                    { 125, 23, "TURKANA CENTRAL" },
                    { 126, 23, "LOIMA" },
                    { 127, 23, "TURKANA SOUTH" },
                    { 128, 23, "TURKANA EAST" },
                    { 129, 24, "KAPENGURIA" },
                    { 130, 24, "SIGOR" },
                    { 131, 24, "KACHELIBA" },
                    { 132, 24, "POKOT SOUTH" },
                    { 133, 25, "SAMBURU WEST" },
                    { 134, 25, "SAMBURU NORTH" },
                    { 135, 25, "SAMBURU EAST" },
                    { 136, 26, "KWANZA" },
                    { 137, 26, "ENDEBESS" },
                    { 138, 26, "SABOTI" },
                    { 139, 26, "KIMININI" },
                    { 140, 26, "CHERANGANY" },
                    { 141, 27, "SOY" },
                    { 142, 27, "TURBO" },
                    { 143, 27, "MOIBEN" },
                    { 144, 27, "AINABKOI" },
                    { 145, 27, "KAPSERET" },
                    { 146, 27, "KESSES" },
                    { 147, 28, "MARAKWET EAST" },
                    { 148, 28, "MARAKWET WEST" },
                    { 149, 28, "KEIYO NORTH" },
                    { 150, 28, "KEIYO SOUTH" },
                    { 151, 29, "TINDERET" },
                    { 152, 29, "ALDAI" },
                    { 153, 29, "NANDI HILLS" },
                    { 154, 29, "CHESUMEI" },
                    { 155, 29, "EMGWEN" },
                    { 156, 29, "MOSOP" },
                    { 157, 30, "TIATY" },
                    { 158, 30, "BARINGO  NORTH" },
                    { 159, 30, "BARINGO CENTRAL" },
                    { 160, 30, "BARINGO SOUTH" },
                    { 161, 30, "MOGOTIO" },
                    { 162, 30, "ELDAMA RAVINE" },
                    { 163, 31, "LAIKIPIA WEST" },
                    { 164, 31, "LAIKIPIA EAST" },
                    { 165, 31, "LAIKIPIA NORTH" },
                    { 166, 32, "MOLO" },
                    { 167, 32, "NJORO" },
                    { 168, 32, "NAIVASHA" },
                    { 169, 32, "GILGIL" },
                    { 170, 32, "KURESOI SOUTH" },
                    { 171, 32, "KURESOI NORTH" },
                    { 172, 32, "SUBUKIA" },
                    { 173, 32, "RONGAI" },
                    { 174, 32, "BAHATI" },
                    { 175, 32, "NAKURU TOWN WEST" },
                    { 176, 32, "NAKURU TOWN EAST" },
                    { 177, 33, "KILGORIS" },
                    { 178, 33, "EMURUA DIKIRR" },
                    { 179, 33, "NAROK NORTH" },
                    { 180, 33, "NAROK EAST" },
                    { 181, 33, "NAROK SOUTH" },
                    { 182, 33, "NAROK WEST" },
                    { 183, 34, "KAJIADO NORTH" },
                    { 184, 34, "KAJIADO CENTRAL" },
                    { 185, 34, "KAJIADO EAST" },
                    { 186, 34, "KAJIADO WEST" },
                    { 187, 34, "KAJIADO SOUTH" },
                    { 188, 35, "KIPKELION EAST" },
                    { 189, 35, "KIPKELION WEST" },
                    { 190, 35, "AINAMOI" },
                    { 191, 35, "BURETI" },
                    { 192, 35, "BELGUT" },
                    { 193, 35, "SIGOWET/SOIN" },
                    { 194, 36, "SOTIK" },
                    { 195, 36, "CHEPALUNGU" },
                    { 196, 36, "BOMET EAST" },
                    { 197, 36, "BOMET CENTRAL" },
                    { 198, 36, "KONOIN" },
                    { 199, 37, "LUGARI" },
                    { 200, 37, "LIKUYANI" },
                    { 201, 37, "MALAVA" },
                    { 202, 37, "LURAMBI" },
                    { 203, 37, "NAVAKHOLO" },
                    { 204, 37, "MUMIAS WEST" },
                    { 205, 37, "MUMIAS EAST" },
                    { 206, 37, "MATUNGU" },
                    { 207, 37, "BUTERE" },
                    { 208, 37, "KHWISERO" },
                    { 209, 37, "SHINYALU" },
                    { 210, 37, "IKOLOMANI" },
                    { 211, 38, "VIHIGA" },
                    { 212, 38, "SABATIA" },
                    { 213, 38, "HAMISI" },
                    { 214, 38, "LUANDA" },
                    { 215, 38, "EMUHAYA" },
                    { 216, 39, "MT.ELGON" },
                    { 217, 39, "SIRISIA" },
                    { 218, 39, "KABUCHAI" },
                    { 219, 39, "BUMULA" },
                    { 220, 39, "KANDUYI" },
                    { 221, 39, "WEBUYE EAST" },
                    { 222, 39, "WEBUYE WEST" },
                    { 223, 39, "KIMILILI" },
                    { 224, 39, "TONGAREN" },
                    { 225, 40, "TESO NORTH" },
                    { 226, 40, "TESO SOUTH" },
                    { 227, 40, "NAMBALE" },
                    { 228, 40, "MATAYOS" },
                    { 229, 40, "BUTULA" },
                    { 230, 40, "FUNYULA" },
                    { 231, 40, "BUDALANGI" },
                    { 232, 41, "UGENYA" },
                    { 233, 41, "UGUNJA" },
                    { 234, 41, "ALEGO USONGA" },
                    { 235, 41, "GEM" },
                    { 236, 41, "BONDO" },
                    { 237, 41, "RARIEDA" },
                    { 238, 42, "KISUMU EAST" },
                    { 239, 42, "KISUMU WEST" },
                    { 240, 42, "KISUMU CENTRAL" },
                    { 241, 42, "SEME" },
                    { 242, 42, "NYANDO" },
                    { 243, 42, "MUHORONI" },
                    { 244, 42, "NYAKACH" },
                    { 245, 43, "KASIPUL" },
                    { 246, 43, "KABONDO KASIPUL" },
                    { 247, 43, "KARACHUONYO" },
                    { 248, 43, "RANGWE" },
                    { 249, 43, "HOMA BAY TOWN" },
                    { 250, 43, "NDHIWA" },
                    { 251, 43, "MBITA" },
                    { 252, 43, "SUBA" },
                    { 253, 44, "RONGO" },
                    { 254, 44, "AWENDO" },
                    { 255, 44, "SUNA EAST" },
                    { 256, 44, "SUNA WEST" },
                    { 257, 44, "URIRI" },
                    { 258, 44, "NYATIKE" },
                    { 259, 44, "KURIA WEST" },
                    { 260, 44, "KURIA EAST" },
                    { 261, 45, "BONCHARI" },
                    { 262, 45, "SOUTH MUGIRANGO" },
                    { 263, 45, "BOMACHOGE BORABU" },
                    { 264, 45, "BOBASI" },
                    { 265, 45, "BOMACHOGE CHACHE" },
                    { 266, 45, "NYARIBARI MASABA" },
                    { 267, 45, "NYARIBARI CHACHE" },
                    { 268, 45, "KITUTU CHACHE NORTH" },
                    { 269, 45, "KITUTU CHACHE SOUTH" },
                    { 270, 46, "KITUTU MASABA" },
                    { 271, 46, "WEST MUGIRANGO" },
                    { 272, 46, "NORTH MUGIRANGO" },
                    { 273, 46, "BORABU" },
                    { 274, 47, "WESTLANDS" },
                    { 275, 47, "DAGORETTI NORTH" },
                    { 276, 47, "DAGORETTI SOUTH" },
                    { 277, 47, "LANGATA" },
                    { 278, 47, "KIBRA" },
                    { 279, 47, "ROYSAMBU" },
                    { 280, 47, "KASARANI" },
                    { 281, 47, "RUARAKA" },
                    { 282, 47, "EMBAKASI SOUTH" },
                    { 283, 47, "EMBAKASI NORTH" },
                    { 284, 47, "EMBAKASI CENTRAL" },
                    { 285, 47, "EMBAKASI EAST" },
                    { 286, 47, "EMBAKASI WEST" },
                    { 287, 47, "MAKADARA" },
                    { 288, 47, "KAMUKUNJI" },
                    { 289, 47, "STAREHE" },
                    { 290, 47, "MATHARE" }
                });

            migrationBuilder.InsertData(
                table: "ward",
                columns: new[] { "id", "fk_subcounty_id", "name" },
                values: new object[,]
                {
                    { 1, 1, "PORT REITZ" },
                    { 2, 1, "KIPEVU" },
                    { 3, 1, "AIRPORT" },
                    { 4, 1, "CHANGAMWE" },
                    { 5, 1, "CHAANI" },
                    { 6, 2, "JOMVU KUU" },
                    { 7, 2, "MIRITINI" },
                    { 8, 2, "MIKINDANI" },
                    { 9, 3, "MJAMBERE" },
                    { 10, 3, "JUNDA" },
                    { 11, 3, "BAMBURI" },
                    { 12, 3, "MWAKIRUNGE" },
                    { 13, 3, "MTOPANGA" },
                    { 14, 3, "MAGOGONI" },
                    { 15, 3, "SHANZU" },
                    { 16, 4, "FRERE TOWN" },
                    { 17, 4, "ZIWA LA NG'OMBE" },
                    { 18, 4, "MKOMANI" },
                    { 19, 4, "KONGOWEA" },
                    { 20, 4, "KADZANDANI" },
                    { 21, 5, "MTONGWE" },
                    { 22, 5, "SHIKA ADABU" },
                    { 23, 5, "BOFU" },
                    { 24, 5, "LIKONI" },
                    { 25, 5, "TIMBWANI" },
                    { 26, 6, "MJI WA KALE/MAKADARA" },
                    { 27, 6, "TUDOR" },
                    { 28, 6, "TONONOKA" },
                    { 29, 6, "SHIMANZI/GANJONI" },
                    { 30, 6, "MAJENGO" },
                    { 31, 7, "GOMBATOBONGWE" },
                    { 32, 7, "UKUNDA" },
                    { 33, 7, "KINONDO" },
                    { 34, 7, "RAMISI" },
                    { 35, 8, "PONGWEKIKONENI" },
                    { 36, 8, "DZOMBO" },
                    { 37, 8, "MWERENI" },
                    { 38, 8, "VANGA" },
                    { 39, 9, "TSIMBA GOLINI" },
                    { 40, 9, "WAA" },
                    { 41, 9, "TIWI" },
                    { 42, 9, "KUBO SOUTH" },
                    { 43, 9, "MKONGANI" },
                    { 44, 10, "NADAVAYA" },
                    { 45, 10, "PUMA" },
                    { 46, 10, "KINANGO" },
                    { 47, 10, "MACKINNON-ROAD" },
                    { 48, 10, "CHENGONI/SAMBURU" },
                    { 49, 10, "MWAVUMBO" },
                    { 50, 10, "KASEMENI" },
                    { 51, 11, "TEZO" },
                    { 52, 11, "SOKONI" },
                    { 53, 11, "KIBARANI" },
                    { 54, 11, "DABASO" },
                    { 55, 11, "MATSANGONI" },
                    { 56, 11, "WATAMU" },
                    { 57, 11, "MNARANI" },
                    { 58, 12, "JUNJU" },
                    { 59, 12, "MWARAKAYA" },
                    { 60, 12, "SHIMO LA TEWA" },
                    { 61, 12, "CHASIMBA" },
                    { 62, 12, "MTEPENI" },
                    { 63, 13, "MARIAKANI" },
                    { 64, 13, "KAYAFUNGO" },
                    { 65, 13, "KALOLENI" },
                    { 66, 13, "MWANAMWINGA" },
                    { 67, 14, "MWAWESA" },
                    { 68, 14, "RURUMA" },
                    { 69, 14, "KAMBE/RIBE" },
                    { 70, 14, "RABAI/KISURUTINI" },
                    { 71, 15, "GANZE" },
                    { 72, 15, "BAMBA" },
                    { 73, 15, "JARIBUNI" },
                    { 74, 15, "SOKOKE" },
                    { 75, 16, "JILORE" },
                    { 76, 16, "KAKUYUNI" },
                    { 77, 16, "GANDA" },
                    { 78, 16, "MALINDI TOWN" },
                    { 79, 16, "SHELLA" },
                    { 80, 17, "MARAFA" },
                    { 81, 17, "MAGARINI" },
                    { 82, 17, "GONGONI" },
                    { 83, 17, "ADU" },
                    { 84, 17, "GARASHI" },
                    { 85, 17, "SABAKI" },
                    { 86, 18, "KIPINI EAST" },
                    { 87, 18, "GARSEN SOUTH" },
                    { 88, 18, "KIPINI WEST" },
                    { 89, 18, "GARSEN CENTRAL" },
                    { 90, 18, "GARSEN WEST" },
                    { 91, 18, "GARSEN NORTH" },
                    { 92, 19, "KINAKOMBA" },
                    { 93, 19, "MIKINDUNI" },
                    { 94, 19, "CHEWANI" },
                    { 95, 19, "WAYU" },
                    { 96, 20, "CHEWELE" },
                    { 97, 20, "BURA" },
                    { 98, 20, "BANGALE" },
                    { 99, 20, "SALA" },
                    { 100, 20, "MADOGO" },
                    { 101, 21, "FAZA" },
                    { 102, 21, "KIUNGA" },
                    { 103, 21, "BASUBA" },
                    { 104, 22, "SHELLA" },
                    { 105, 22, "MKOMANI" },
                    { 106, 22, "HINDI" },
                    { 107, 22, "MKUNUMBI" },
                    { 108, 22, "HONGWE" },
                    { 109, 22, "WITU" },
                    { 110, 22, "BAHARI" },
                    { 111, 23, "CHALA" },
                    { 112, 23, "MAHOO" },
                    { 113, 23, "BOMENI" },
                    { 114, 23, "MBOGHONI" },
                    { 115, 23, "MATA" },
                    { 116, 24, "WUNDANYI/MBALE" },
                    { 117, 24, "WERUGHA" },
                    { 118, 24, "WUMINGU/KISHUSHE" },
                    { 119, 24, "MWANDA/MGANGE" },
                    { 120, 25, "RONG'E" },
                    { 121, 25, "MWATATE" },
                    { 122, 25, "BURA" },
                    { 123, 25, "CHAWIA" },
                    { 124, 25, "WUSI/KISHAMBA" },
                    { 125, 26, "MBOLOLO" },
                    { 126, 26, "SAGALLA" },
                    { 127, 26, "KALOLENI" },
                    { 128, 26, "MARUNGU" },
                    { 129, 26, "KASIGAU" },
                    { 130, 26, "NGOLIA" },
                    { 131, 27, "WABERI" },
                    { 132, 27, "GALBET" },
                    { 133, 27, "TOWNSHIP" },
                    { 134, 27, "IFTIN" },
                    { 135, 28, "BALAMBALA" },
                    { 136, 28, "DANYERE" },
                    { 137, 28, "JARA JARA" },
                    { 138, 28, "SAKA" },
                    { 139, 28, "SANKURI" },
                    { 140, 29, "MODOGASHE" },
                    { 141, 29, "BENANE" },
                    { 142, 29, "GOREALE" },
                    { 143, 29, "MAALIMIN" },
                    { 144, 29, "SABENA" },
                    { 145, 29, "BARAKI" },
                    { 146, 30, "DERTU" },
                    { 147, 30, "DADAAB" },
                    { 148, 30, "LABASIGALE" },
                    { 149, 30, "DAMAJALE" },
                    { 150, 30, "LIBOI" },
                    { 151, 30, "ABAKAILE" },
                    { 152, 31, "BURA" },
                    { 153, 31, "DEKAHARIA" },
                    { 154, 31, "JARAJILA" },
                    { 155, 31, "FAFI" },
                    { 156, 31, "NANIGHI" },
                    { 157, 32, "HULUGHO" },
                    { 158, 32, "SANGAILU" },
                    { 159, 32, "IJARA" },
                    { 160, 32, "MASALANI" },
                    { 161, 33, "GURAR" },
                    { 162, 33, "BUTE" },
                    { 163, 33, "KORONDILE" },
                    { 164, 33, "MALKAGUFU" },
                    { 165, 33, "BATALU" },
                    { 166, 33, "DANABA" },
                    { 167, 33, "GODOMA" },
                    { 168, 34, "WAGBERI" },
                    { 169, 34, "TOWNSHIP" },
                    { 170, 34, "BARWAGO" },
                    { 171, 34, "KHOROF/HARAR" },
                    { 172, 35, "ELBEN" },
                    { 173, 35, "SARMAN" },
                    { 174, 35, "TARBAJ" },
                    { 175, 35, "WARGADUD" },
                    { 176, 36, "ARBAJAHAN" },
                    { 177, 36, "HADADO/ATHIBOHOL" },
                    { 178, 36, "ADEMASAJIDE" },
                    { 179, 36, "WAGALLA/GANYURE" },
                    { 180, 37, "ELDAS" },
                    { 181, 37, "DELLA" },
                    { 182, 37, "LAKOLEY SOUTH/BASIR" },
                    { 183, 37, "ELNUR/TULA TULA" },
                    { 184, 38, "BENANE" },
                    { 185, 38, "BURDER" },
                    { 186, 38, "DADAJA BULLA" },
                    { 187, 38, "HABASSWEIN" },
                    { 188, 38, "LAGBOGHOL SOUTH" },
                    { 189, 38, "IBRAHIM URE" },
                    { 190, 38, "DIIF" },
                    { 191, 39, "TAKABA SOUTH" },
                    { 192, 39, "TAKABA" },
                    { 193, 39, "LAG SURE" },
                    { 194, 39, "DANDU" },
                    { 195, 39, "GITHER" },
                    { 196, 40, "BANISSA" },
                    { 197, 40, "DERKHALE" },
                    { 198, 40, "GUBA" },
                    { 199, 40, "MALKAMARI" },
                    { 200, 40, "KILIWEHIRI" },
                    { 201, 41, "ASHABITO" },
                    { 202, 41, "GUTICHA" },
                    { 203, 41, "MOROTHILE" },
                    { 204, 41, "RHAMU" },
                    { 205, 41, "RHAMU-DIMTU" },
                    { 206, 42, "WARGUDUD" },
                    { 207, 42, "KUTULO" },
                    { 208, 42, "ELWAK SOUTH" },
                    { 209, 42, "ELWAK NORTH" },
                    { 210, 42, "SHIMBIR FATUMA" },
                    { 211, 43, "ARABIA" },
                    { 212, 43, "BULLA MPYA" },
                    { 213, 43, "KHALALIO" },
                    { 214, 43, "NEBOI" },
                    { 215, 43, "TOWNSHIP" },
                    { 216, 44, "LIBEHIA" },
                    { 217, 44, "FINO" },
                    { 218, 44, "LAFEY" },
                    { 219, 44, "WARANKARA" },
                    { 220, 44, "ALUNGO GOF" },
                    { 221, 45, "BUTIYE" },
                    { 222, 45, "SOLOLO" },
                    { 223, 45, "HEILU-MANYATTA" },
                    { 224, 45, "GOLBO" },
                    { 225, 45, "MOYALE TOWNSHIP" },
                    { 226, 45, "URAN" },
                    { 227, 45, "OBBU" },
                    { 228, 46, "ILLERET" },
                    { 229, 46, "NORTH HORR" },
                    { 230, 46, "DUKANA" },
                    { 231, 46, "MAIKONA" },
                    { 232, 46, "TURBI" },
                    { 233, 47, "SAGANTE/JALDESA" },
                    { 234, 47, "KARARE" },
                    { 235, 47, "MARSABIT CENTRAL" },
                    { 236, 48, "LOIYANGALANI" },
                    { 237, 48, "KARGI/SOUTH HORR" },
                    { 238, 48, "KORR/NGURUNIT" },
                    { 239, 48, "LOG LOGO" },
                    { 240, 48, "LAISAMIS" },
                    { 241, 49, "WABERA" },
                    { 242, 49, "BULLA PESA" },
                    { 243, 49, "CHARI" },
                    { 244, 49, "CHERAB" },
                    { 245, 49, "NGARE MARA" },
                    { 246, 49, "BURAT" },
                    { 247, 49, "OLDONYIRO" },
                    { 248, 50, "GARBATULLA" },
                    { 249, 50, "KINNA" },
                    { 250, 50, "SERICHO" },
                    { 251, 51, "MAUA" },
                    { 252, 51, "KIEGOI/ANTUBOCHIU" },
                    { 253, 51, "ATHIRU GAITI" },
                    { 254, 51, "AKACHIU" },
                    { 255, 51, "KANUNI" },
                    { 256, 52, "AKIRANG'ONDU" },
                    { 257, 52, "ATHIRU RUUJINE" },
                    { 258, 52, "IGEMBE EAST" },
                    { 259, 52, "NJIA" },
                    { 260, 52, "KANGETA" },
                    { 261, 53, "ANTUAMBUI" },
                    { 262, 53, "NTUNENE" },
                    { 263, 53, "ANTUBETWE KIONGO" },
                    { 264, 53, "NAATHU" },
                    { 265, 53, "AMWATHI" },
                    { 266, 54, "ATHWANA" },
                    { 267, 54, "AKITHII" },
                    { 268, 54, "KIANJAI" },
                    { 269, 54, "NKOMO" },
                    { 270, 54, "MBEU" },
                    { 271, 55, "THANGATHA" },
                    { 272, 55, "MIKINDURI" },
                    { 273, 55, "KIGUCHWA" },
                    { 274, 55, "MUTHARA" },
                    { 275, 55, "KARAMA" },
                    { 276, 56, "MUNICIPALITY" },
                    { 277, 56, "NTIMA EAST" },
                    { 278, 56, "NTIMA WEST" },
                    { 279, 56, "NYAKI WEST" },
                    { 280, 56, "NYAKI EAST" },
                    { 281, 57, "TIMAU" },
                    { 282, 57, "KISIMA" },
                    { 283, 57, "KIIRUA/NAARI" },
                    { 284, 57, "RUIRI/RWARERA" },
                    { 285, 57, "KIBIRICHIA" },
                    { 286, 58, "MWANGANTHIA" },
                    { 287, 58, "ABOTHUGUCHI CENTRAL" },
                    { 288, 58, "ABOTHUGUCHI WEST" },
                    { 289, 58, "KIAGU" },
                    { 290, 59, "MITUNGUU" },
                    { 291, 59, "IGOJI EAST" },
                    { 292, 59, "IGOJI WEST" },
                    { 293, 59, "ABOGETA EAST" },
                    { 294, 59, "ABOGETA WEST" },
                    { 295, 59, "NKUENE" },
                    { 296, 60, "MITHERU" },
                    { 297, 60, "MUTHAMBI" },
                    { 298, 60, "MWIMBI" },
                    { 299, 60, "GANGA" },
                    { 300, 60, "CHOGORIA" },
                    { 301, 61, "MARIANI" },
                    { 302, 61, "KARINGANI" },
                    { 303, 61, "MAGUMONI" },
                    { 304, 61, "MUGWE" },
                    { 305, 61, "IGAMBANG'OMBE" },
                    { 306, 62, "GATUNGA" },
                    { 307, 62, "MUKOTHIMA" },
                    { 308, 62, "NKONDI" },
                    { 309, 62, "CHIAKARIGA" },
                    { 310, 62, "MARIMANTI" },
                    { 311, 63, "RUGURU/NGANDORI" },
                    { 312, 63, "KITHIMU" },
                    { 313, 63, "NGINDA" },
                    { 314, 63, "MBETI NORTH" },
                    { 315, 63, "KIRIMARI" },
                    { 316, 63, "GATURI SOUTH" },
                    { 317, 64, "GATURI NORTH" },
                    { 318, 64, "KAGAARI SOUTH" },
                    { 319, 64, "CENTRAL  WARD" },
                    { 320, 64, "KAGAARI NORTH" },
                    { 321, 64, "KYENI NORTH" },
                    { 322, 64, "KYENI SOUTH" },
                    { 323, 65, "MWEA" },
                    { 324, 65, "MAKIMA" },
                    { 325, 65, "MBETI SOUTH" },
                    { 326, 65, "MAVURIA" },
                    { 327, 65, "KIAMBERE" },
                    { 328, 66, "NTHAWA" },
                    { 329, 66, "MUMINJI" },
                    { 330, 66, "EVURORE" },
                    { 331, 67, "NGOMENI" },
                    { 332, 67, "KYUSO" },
                    { 333, 67, "MUMONI" },
                    { 334, 67, "TSEIKURU" },
                    { 335, 67, "THARAKA" },
                    { 336, 68, "KYOME/THAANA" },
                    { 337, 68, "NGUUTANI" },
                    { 338, 68, "MIGWANI" },
                    { 339, 68, "KIOMO/KYETHANI" },
                    { 340, 69, "CENTRAL" },
                    { 341, 69, "KIVOU" },
                    { 342, 69, "NGUNI" },
                    { 343, 69, "NUU" },
                    { 344, 69, "MUI" },
                    { 345, 69, "WAITA" },
                    { 346, 70, "MUTONGUNI" },
                    { 347, 70, "KAUWI" },
                    { 348, 70, "MATINYANI" },
                    { 349, 70, "KWA MUTONGA/KITHUMULA" },
                    { 350, 71, "KISASI" },
                    { 351, 71, "MBITINI" },
                    { 352, 71, "KWAVONZA/YATTA" },
                    { 353, 71, "KANYANGI" },
                    { 354, 72, "MIAMBANI" },
                    { 355, 72, "TOWNSHIP" },
                    { 356, 72, "KYANGWITHYA WEST" },
                    { 357, 72, "MULANGO" },
                    { 358, 72, "KYANGWITHYA EAST" },
                    { 359, 73, "ZOMBE/MWITIKA" },
                    { 360, 73, "CHULUNI" },
                    { 361, 73, "NZAMBANI" },
                    { 362, 73, "VOO/KYAMATU" },
                    { 363, 73, "ENDAU/MALALANI" },
                    { 364, 73, "MUTITO/KALIKU" },
                    { 365, 74, "IKANGA/KYATUNE" },
                    { 366, 74, "MUTOMO" },
                    { 367, 74, "MUTHA" },
                    { 368, 74, "IKUTHA" },
                    { 369, 74, "KANZIKO" },
                    { 370, 74, "ATHI" },
                    { 371, 75, "KIVAA" },
                    { 372, 75, "MASINGA CENTRAL" },
                    { 373, 75, "EKALAKALA" },
                    { 374, 75, "MUTHESYA" },
                    { 375, 75, "NDITHINI" },
                    { 376, 76, "NDALANI" },
                    { 377, 76, "MATUU" },
                    { 378, 76, "KITHIMANI" },
                    { 379, 76, "IKOMBE" },
                    { 380, 76, "KATANGI" },
                    { 381, 77, "KANGUNDO NORTH" },
                    { 382, 77, "KANGUNDO CENTRAL" },
                    { 383, 77, "KANGUNDO EAST" },
                    { 384, 77, "KANGUNDO WEST" },
                    { 385, 78, "TALA" },
                    { 386, 78, "MATUNGULU NORTH" },
                    { 387, 78, "MATUNGULU EAST" },
                    { 388, 78, "MATUNGULU WEST" },
                    { 389, 78, "KYELENI" },
                    { 390, 79, "MITABONI" },
                    { 391, 79, "KATHIANI CENTRAL" },
                    { 392, 79, "UPPER KAEWA/IVETI" },
                    { 393, 79, "LOWER KAEWA/KAANI" },
                    { 394, 80, "ATHI RIVER" },
                    { 395, 80, "KINANIE" },
                    { 396, 80, "MUTHWANI" },
                    { 397, 80, "SYOKIMAU/MULOLONGO" },
                    { 398, 81, "KALAMA" },
                    { 399, 81, "MUA" },
                    { 400, 81, "MUTITUNI" },
                    { 401, 81, "MACHAKOS CENTRAL" },
                    { 402, 81, "MUMBUNI NORTH" },
                    { 403, 81, "MUVUTI/KIIMA-KIMWE" },
                    { 404, 81, "KOLA" },
                    { 405, 82, "MBIUNI" },
                    { 406, 82, "MAKUTANO/ MWALA" },
                    { 407, 82, "MASII" },
                    { 408, 82, "MUTHETHENI" },
                    { 409, 82, "WAMUNYU" },
                    { 410, 82, "KIBAUNI" },
                    { 411, 83, "TULIMANI" },
                    { 412, 83, "MBOONI" },
                    { 413, 83, "KITHUNGO/KITUNDU" },
                    { 414, 83, "KISAU/KITETA" },
                    { 415, 83, "WAIA/KAKO" },
                    { 416, 83, "KALAWA" },
                    { 417, 84, "KASIKEU" },
                    { 418, 84, "MUKAA" },
                    { 419, 84, "KIIMA KIU/KALANZONI" },
                    { 420, 85, "UKIA" },
                    { 421, 85, "KEE" },
                    { 422, 85, "KILUNGU" },
                    { 423, 85, "ILIMA" },
                    { 424, 86, "WOTE" },
                    { 425, 86, "MUVAU/KIKUUMINI" },
                    { 426, 86, "MAVINDINI" },
                    { 427, 86, "KITISE/KITHUKI" },
                    { 428, 86, "KATHONZWENI" },
                    { 429, 86, "NZAUI/KILILI/KALAMBA" },
                    { 430, 86, "MBITINI" },
                    { 431, 87, "MAKINDU" },
                    { 432, 87, "NGUUMO" },
                    { 433, 87, "KIKUMBULYU NORTH" },
                    { 434, 87, "KIKUMBULYU SOUTH" },
                    { 435, 87, "NGUU/MASUMBA" },
                    { 436, 87, "EMALI/MULALA" },
                    { 437, 88, "MASONGALENI" },
                    { 438, 88, "MTITO ANDEI" },
                    { 439, 88, "THANGE" },
                    { 440, 88, "IVINGONI/NZAMBANI" },
                    { 441, 89, "ENGINEER" },
                    { 442, 89, "GATHARA" },
                    { 443, 89, "NORTH KINANGOP" },
                    { 444, 89, "MURUNGARU" },
                    { 445, 89, "NJABINI\\KIBURU" },
                    { 446, 89, "NYAKIO" },
                    { 447, 89, "GITHABAI" },
                    { 448, 89, "MAGUMU" },
                    { 449, 90, "WANJOHI" },
                    { 450, 90, "KIPIPIRI" },
                    { 451, 90, "GETA" },
                    { 452, 90, "GITHIORO" },
                    { 453, 91, "KARAU" },
                    { 454, 91, "KANJUIRI RIDGE" },
                    { 455, 91, "MIRANGINE" },
                    { 456, 91, "KAIMBAGA" },
                    { 457, 91, "RURII" },
                    { 458, 92, "GATHANJI" },
                    { 459, 92, "GATIMU" },
                    { 460, 92, "WERU" },
                    { 461, 92, "CHARAGITA" },
                    { 462, 93, "LESHAU PONDO" },
                    { 463, 93, "KIRIITA" },
                    { 464, 93, "CENTRAL" },
                    { 465, 93, "SHAMATA" },
                    { 466, 94, "DEDAN KIMANTHI" },
                    { 467, 94, "WAMAGANA" },
                    { 468, 94, "AGUTHI/GAAKI" },
                    { 469, 95, "MWEIGA" },
                    { 470, 95, "NAROMORU KIAMATHAGA" },
                    { 471, 95, "MWIYOGO/ENDARASHA" },
                    { 472, 95, "MUGUNDA" },
                    { 473, 95, "GATARAKWA" },
                    { 474, 95, "THEGU RIVER" },
                    { 475, 95, "KABARU" },
                    { 476, 95, "GAKAWA" },
                    { 477, 96, "RUGURU" },
                    { 478, 96, "MAGUTU" },
                    { 479, 96, "IRIAINI" },
                    { 480, 96, "KONYU" },
                    { 481, 96, "KIRIMUKUYU" },
                    { 482, 96, "KARATINA TOWN" },
                    { 483, 97, "MAHIGA" },
                    { 484, 97, "IRIA-INI" },
                    { 485, 97, "CHINGA" },
                    { 486, 97, "KARIMA" },
                    { 487, 98, "GIKONDI" },
                    { 488, 98, "RUGI" },
                    { 489, 98, "MUKURWE-INI WEST" },
                    { 490, 98, "MUKURWE-INI CENTRAL" },
                    { 491, 99, "KIGANJO/MATHARI" },
                    { 492, 99, "RWARE" },
                    { 493, 99, "GATITU/MURUGURU" },
                    { 494, 99, "RURING'U" },
                    { 495, 99, "KAMAKWA/MUKARO" },
                    { 496, 100, "MUTITHI" },
                    { 497, 100, "KANGAI" },
                    { 498, 100, "THIBA" },
                    { 499, 100, "WAMUMU" },
                    { 500, 100, "NYANGATI" },
                    { 501, 100, "MURINDUKO" },
                    { 502, 100, "GATHIGIRIRI" },
                    { 503, 100, "TEBERE" },
                    { 504, 101, "KABARE" },
                    { 505, 101, "BARAGWI" },
                    { 506, 101, "NJUKIINI" },
                    { 507, 101, "NGARIAMA" },
                    { 508, 101, "KARUMANDI" },
                    { 509, 102, "MUKURE" },
                    { 510, 102, "KIINE" },
                    { 511, 102, "KARITI" },
                    { 512, 103, "MUTIRA" },
                    { 513, 103, "KANYEKI-INI" },
                    { 514, 103, "KERUGOYA" },
                    { 515, 103, "INOI" },
                    { 516, 104, "KANYENYAINI" },
                    { 517, 104, "MUGURU" },
                    { 518, 104, "RWATHIA" },
                    { 519, 105, "GITUGI" },
                    { 520, 105, "KIRU" },
                    { 521, 105, "KAMACHARIA" },
                    { 522, 106, "WANGU" },
                    { 523, 106, "MUGOIRI" },
                    { 524, 106, "MBIRI" },
                    { 525, 106, "TOWNSHIP" },
                    { 526, 106, "MURARANDIA" },
                    { 527, 106, "GATURI" },
                    { 528, 107, "KAHUMBU" },
                    { 529, 107, "MUTHITHI" },
                    { 530, 107, "KIGUMO" },
                    { 531, 107, "KANGARI" },
                    { 532, 107, "KINYONA" },
                    { 533, 108, "KIMORORI/WEMPA" },
                    { 534, 108, "MAKUYU" },
                    { 535, 108, "KAMBITI" },
                    { 536, 108, "KAMAHUHA" },
                    { 537, 108, "ICHAGAKI" },
                    { 538, 108, "NGINDA" },
                    { 539, 109, "NG'ARARIA" },
                    { 540, 109, "MURUKA" },
                    { 541, 109, "KAGUNDU-INI" },
                    { 542, 109, "GAICHANJIRU" },
                    { 543, 109, "ITHIRU" },
                    { 544, 109, "RUCHU" },
                    { 545, 110, "ITHANGA" },
                    { 546, 110, "KAKUZI/MITUBIRI" },
                    { 547, 110, "MUGUMO-INI" },
                    { 548, 110, "KIHUMBU-INI" },
                    { 549, 110, "GATANGA" },
                    { 550, 110, "KARIARA" },
                    { 551, 111, "KIAMWANGI" },
                    { 552, 111, "KIGANJO" },
                    { 553, 111, "NDARUGU" },
                    { 554, 111, "NGENDA" },
                    { 555, 112, "GITUAMBA" },
                    { 556, 112, "GITHOBOKONI" },
                    { 557, 112, "CHANIA" },
                    { 558, 112, "MANG'U" },
                    { 559, 113, "MURERA" },
                    { 560, 113, "THETA" },
                    { 561, 113, "JUJA" },
                    { 562, 113, "WITEITHIE" },
                    { 563, 113, "KALIMONI" },
                    { 564, 114, "TOWNSHIP" },
                    { 565, 114, "KAMENU" },
                    { 566, 114, "HOSPITAL" },
                    { 567, 114, "GATUANYAGA" },
                    { 568, 114, "NGOLIBA" },
                    { 569, 115, "GITOTHUA" },
                    { 570, 115, "BIASHARA" },
                    { 571, 115, "GATONGORA" },
                    { 572, 115, "KAHAWA SUKARI" },
                    { 573, 115, "KAHAWA WENDANI" },
                    { 574, 115, "KIUU" },
                    { 575, 115, "MWIKI" },
                    { 576, 115, "MWIHOKO" },
                    { 577, 116, "GITHUNGURI" },
                    { 578, 116, "GITHIGA" },
                    { 579, 116, "IKINU" },
                    { 580, 116, "NGEWA" },
                    { 581, 116, "KOMOTHAI" },
                    { 582, 117, "TING'ANG'A" },
                    { 583, 117, "NDUMBERI" },
                    { 584, 117, "RIABAI" },
                    { 585, 117, "TOWNSHIP" },
                    { 586, 118, "CIANDA" },
                    { 587, 118, "KARURI" },
                    { 588, 118, "NDENDERU" },
                    { 589, 118, "MUCHATHA" },
                    { 590, 118, "KIHARA" },
                    { 591, 119, "GITARU" },
                    { 592, 119, "MUGUGA" },
                    { 593, 119, "NYADHUNA" },
                    { 594, 119, "KABETE" },
                    { 595, 119, "UTHIRU" },
                    { 596, 120, "KARAI" },
                    { 597, 120, "NACHU" },
                    { 598, 120, "SIGONA" },
                    { 599, 120, "KIKUYU" },
                    { 600, 120, "KINOO" },
                    { 601, 121, "BIBIRIONI" },
                    { 602, 121, "LIMURU CENTRAL" },
                    { 603, 121, "NDEIYA" },
                    { 604, 121, "LIMURU EAST" },
                    { 605, 121, "NGECHA TIGONI" },
                    { 606, 122, "KINALE" },
                    { 607, 122, "KIJABE" },
                    { 608, 122, "NYANDUMA" },
                    { 609, 122, "KAMBURU" },
                    { 610, 122, "LARI/KIRENGA" },
                    { 611, 123, "KAERIS" },
                    { 612, 123, "LAKE ZONE" },
                    { 613, 123, "LAPUR" },
                    { 614, 123, "KAALENG/KAIKOR" },
                    { 615, 123, "KIBISH" },
                    { 616, 123, "NAKALALE" },
                    { 617, 124, "KAKUMA" },
                    { 618, 124, "LOPUR" },
                    { 619, 124, "LETEA" },
                    { 620, 124, "SONGOT" },
                    { 621, 124, "KALOBEYEI" },
                    { 622, 124, "LOKICHOGGIO" },
                    { 623, 124, "NANAAM" },
                    { 624, 125, "KERIO DELTA" },
                    { 625, 125, "KANG'ATOTHA" },
                    { 626, 125, "KALOKOL" },
                    { 627, 125, "LODWAR TOWNSHIP" },
                    { 628, 125, "KANAMKEMER" },
                    { 629, 126, "KOTARUK/LOBEI" },
                    { 630, 126, "TURKWEL" },
                    { 631, 126, "LOIMA" },
                    { 632, 126, "LOKIRIAMA/LORENGIPPI" },
                    { 633, 127, "KAPUTIR" },
                    { 634, 127, "KATILU" },
                    { 635, 127, "LOBOKAT" },
                    { 636, 127, "KALAPATA" },
                    { 637, 127, "LOKICHAR" },
                    { 638, 128, "KAPEDO/NAPEITOM" },
                    { 639, 128, "KATILIA" },
                    { 640, 128, "LOKORI/KOCHODIN" },
                    { 641, 129, "RIWO" },
                    { 642, 129, "KAPENGURIA" },
                    { 643, 129, "MNAGEI" },
                    { 644, 129, "SIYOI" },
                    { 645, 129, "ENDUGH" },
                    { 646, 129, "SOOK" },
                    { 647, 130, "SEKERR" },
                    { 648, 130, "MASOOL" },
                    { 649, 130, "LOMUT" },
                    { 650, 130, "WEIWEI" },
                    { 651, 131, "SUAM" },
                    { 652, 131, "KODICH" },
                    { 653, 131, "KAPCKOK" },
                    { 654, 131, "KASEI" },
                    { 655, 131, "KIWAWA" },
                    { 656, 131, "ALALE" },
                    { 657, 132, "CHEPARERIA" },
                    { 658, 132, "BATEI" },
                    { 659, 132, "LELAN" },
                    { 660, 132, "TAPACH" },
                    { 661, 133, "LODOKEJEK" },
                    { 662, 133, "SUGUTA MARMAR" },
                    { 663, 133, "MARALAL" },
                    { 664, 133, "LOOSUK" },
                    { 665, 133, "PORO" },
                    { 666, 134, "EL-BARTA" },
                    { 667, 134, "NACHOLA" },
                    { 668, 134, "NDOTO" },
                    { 669, 134, "NYIRO" },
                    { 670, 134, "ANGATA NANYOKIE" },
                    { 671, 134, "BAAWA" },
                    { 672, 135, "WASO" },
                    { 673, 135, "WAMBA WEST" },
                    { 674, 135, "WAMBA EAST" },
                    { 675, 135, "WAMBA NORTH" },
                    { 676, 136, "KAPOMBOI" },
                    { 677, 136, "KWANZA" },
                    { 678, 136, "KEIYO" },
                    { 679, 136, "BIDII" },
                    { 680, 137, "CHEPCHOINA" },
                    { 681, 137, "ENDEBESS" },
                    { 682, 137, "MATUMBEI" },
                    { 683, 138, "KINYORO" },
                    { 684, 138, "MATISI" },
                    { 685, 138, "TUWANI" },
                    { 686, 138, "SABOTI" },
                    { 687, 138, "MACHEWA" },
                    { 688, 139, "KIMININI" },
                    { 689, 139, "WAITALUK" },
                    { 690, 139, "SIRENDE" },
                    { 691, 139, "HOSPITAL" },
                    { 692, 139, "SIKHENDU" },
                    { 693, 139, "NABISWA" },
                    { 694, 140, "SINYERERE" },
                    { 695, 140, "MAKUTANO" },
                    { 696, 140, "KAPLAMAI" },
                    { 697, 140, "MOTOSIET" },
                    { 698, 140, "CHERANGANY/SUWERWA" },
                    { 699, 140, "CHEPSIRO/KIPTOROR" },
                    { 700, 140, "SITATUNGA" },
                    { 701, 141, "MOI'S BRIDGE" },
                    { 702, 141, "KAPKURES" },
                    { 703, 141, "ZIWA" },
                    { 704, 141, "SEGERO/BARSOMBE" },
                    { 705, 141, "KIPSOMBA" },
                    { 706, 141, "SOY" },
                    { 707, 141, "KUINET/KAPSUSWA" },
                    { 708, 142, "NGENYILEL" },
                    { 709, 142, "TAPSAGOI" },
                    { 710, 142, "KAMAGUT" },
                    { 711, 142, "KIPLOMBE" },
                    { 712, 142, "KAPSAOS" },
                    { 713, 142, "HURUMA" },
                    { 714, 143, "TEMBELIO" },
                    { 715, 143, "SERGOIT" },
                    { 716, 143, "KARUNA/MEIBEKI" },
                    { 717, 143, "MOIBEN" },
                    { 718, 143, "KIMUMU" },
                    { 719, 144, "KAPSOYA" },
                    { 720, 144, "KAPTAGAT" },
                    { 721, 144, "AINABKOI/OLARE" },
                    { 722, 145, "SIMAT/KAPSERET" },
                    { 723, 145, "KIPKENYO" },
                    { 724, 145, "NGERIA" },
                    { 725, 145, "MEGUN" },
                    { 726, 145, "LANGAS" },
                    { 727, 146, "RACECOURSE" },
                    { 728, 146, "CHEPTIRET/KIPCHAMO" },
                    { 729, 146, "TULWET/CHUIYAT" },
                    { 730, 146, "TARAKWA" },
                    { 731, 147, "KAPYEGO" },
                    { 732, 147, "SAMBIRIR" },
                    { 733, 147, "ENDO" },
                    { 734, 147, "EMBOBUT / EMBULOT" },
                    { 735, 148, "LELAN" },
                    { 736, 148, "SENGWER" },
                    { 737, 148, "CHERANG'ANY/CHEBORORWA" },
                    { 738, 148, "MOIBEN/KUSERWO" },
                    { 739, 148, "KAPSOWAR" },
                    { 740, 148, "ARROR" },
                    { 741, 149, "EMSOO" },
                    { 742, 149, "KAMARINY" },
                    { 743, 149, "KAPCHEMUTWA" },
                    { 744, 149, "TAMBACH" },
                    { 745, 150, "KAPTARAKWA" },
                    { 746, 150, "CHEPKORIO" },
                    { 747, 150, "SOY NORTH" },
                    { 748, 150, "SOY SOUTH" },
                    { 749, 150, "KABIEMIT" },
                    { 750, 150, "METKEI" },
                    { 751, 151, "SONGHOR/SOBA" },
                    { 752, 151, "TINDIRET" },
                    { 753, 151, "CHEMELIL/CHEMASE" },
                    { 754, 151, "KAPSIMOTWO" },
                    { 755, 152, "KABWARENG" },
                    { 756, 152, "TERIK" },
                    { 757, 152, "KEMELOI-MARABA" },
                    { 758, 152, "KOBUJOI" },
                    { 759, 152, "KAPTUMO-KABOI" },
                    { 760, 152, "KOYO-NDURIO" },
                    { 761, 153, "NANDI HILLS" },
                    { 762, 153, "CHEPKUNYUK" },
                    { 763, 153, "OL'LESSOS" },
                    { 764, 153, "KAPCHORUA" },
                    { 765, 154, "CHEMUNDU/KAPNG'ETUNY" },
                    { 766, 154, "KOSIRAI" },
                    { 767, 154, "LELMOKWO/NGECHEK" },
                    { 768, 154, "KAPTEL/KAMOIYWO" },
                    { 769, 154, "KIPTUYA" },
                    { 770, 155, "CHEPKUMIA" },
                    { 771, 155, "KAPKANGANI" },
                    { 772, 155, "KAPSABET" },
                    { 773, 155, "KILIBWONI" },
                    { 774, 156, "CHEPTERWAI" },
                    { 775, 156, "KIPKAREN" },
                    { 776, 156, "KURGUNG/SURUNGAI" },
                    { 777, 156, "KABIYET" },
                    { 778, 156, "NDALAT" },
                    { 779, 156, "KABISAGA" },
                    { 780, 156, "SANGALO/KEBULONIK" },
                    { 781, 157, "TIRIOKO" },
                    { 782, 157, "KOLOWA" },
                    { 783, 157, "RIBKWO" },
                    { 784, 157, "SILALE" },
                    { 785, 157, "LOIYAMOROCK" },
                    { 786, 157, "TANGULBEI/KOROSSI" },
                    { 787, 157, "CHURO/AMAYA" },
                    { 788, 158, "BARWESSA" },
                    { 789, 158, "KABARTONJO" },
                    { 790, 158, "SAIMO/KIPSARAMAN" },
                    { 791, 158, "SAIMO/SOI" },
                    { 792, 158, "BARTABWA" },
                    { 793, 159, "KABARNET" },
                    { 794, 159, "SACHO" },
                    { 795, 159, "TENGES" },
                    { 796, 159, "EWALEL CHAPCHAP" },
                    { 797, 159, "KAPROPITA" },
                    { 798, 160, "MARIGAT" },
                    { 799, 160, "ILCHAMUS" },
                    { 800, 160, "MOCHONGOI" },
                    { 801, 160, "MUKUTANI" },
                    { 802, 161, "MOGOTIO" },
                    { 803, 161, "EMINING" },
                    { 804, 161, "KISANANA" },
                    { 805, 162, "LEMBUS" },
                    { 806, 162, "LEMBUS KWEN" },
                    { 807, 162, "RAVINE" },
                    { 808, 162, "MUMBERES/MAJI MAZURI" },
                    { 809, 162, "LEMBUS/PERKERRA" },
                    { 810, 162, "KOIBATEK" },
                    { 811, 163, "OLMORAN" },
                    { 812, 163, "RUMURUTI TOWNSHIP" },
                    { 813, 163, "KINAMBA" },
                    { 814, 163, "MARMANET" },
                    { 815, 163, "IGWAMITI" },
                    { 816, 163, "SALAMA" },
                    { 817, 164, "NGOBIT" },
                    { 818, 164, "TIGITHI" },
                    { 819, 164, "THINGITHU" },
                    { 820, 164, "NANYUKI" },
                    { 821, 164, "UMANDE" },
                    { 822, 165, "SOSIAN" },
                    { 823, 165, "SEGERA" },
                    { 824, 165, "MUKOGONDO WEST" },
                    { 825, 165, "MUKOGONDO EAST" },
                    { 826, 166, "MARIASHONI" },
                    { 827, 166, "ELBURGON" },
                    { 828, 166, "TURI" },
                    { 829, 166, "MOLO" },
                    { 830, 167, "MAUNAROK" },
                    { 831, 167, "MAUCHE" },
                    { 832, 167, "KIHINGO" },
                    { 833, 167, "NESSUIT" },
                    { 834, 167, "LARE" },
                    { 835, 167, "NJORO" },
                    { 836, 168, "BIASHARA" },
                    { 837, 168, "HELLS GATE" },
                    { 838, 168, "LAKEVIEW" },
                    { 839, 168, "MAAI-MAHIU" },
                    { 840, 168, "MAIELLA" },
                    { 841, 168, "OLKARIA" },
                    { 842, 168, "NAIVASHA EAST" },
                    { 843, 168, "VIWANDANI" },
                    { 844, 169, "GILGIL" },
                    { 845, 169, "ELEMENTAITA" },
                    { 846, 169, "MBARUK/EBURU" },
                    { 847, 169, "MALEWA WEST" },
                    { 848, 169, "MURINDATI" },
                    { 849, 170, "AMALO" },
                    { 850, 170, "KERINGET" },
                    { 851, 170, "KIPTAGICH" },
                    { 852, 170, "TINET" },
                    { 853, 171, "KIPTORORO" },
                    { 854, 171, "NYOTA" },
                    { 855, 171, "SIRIKWA" },
                    { 856, 171, "KAMARA" },
                    { 857, 172, "SUBUKIA" },
                    { 858, 172, "WASEGES" },
                    { 859, 172, "KABAZI" },
                    { 860, 173, "MENENGAI WEST" },
                    { 861, 173, "SOIN" },
                    { 862, 173, "VISOI" },
                    { 863, 173, "MOSOP" },
                    { 864, 173, "SOLAI" },
                    { 865, 174, "DUNDORI" },
                    { 866, 174, "KABATINI" },
                    { 867, 174, "KIAMAINA" },
                    { 868, 174, "LANET/UMOJA" },
                    { 869, 174, "BAHATI" },
                    { 870, 175, "BARUT" },
                    { 871, 175, "LONDON" },
                    { 872, 175, "KAPTEMBWO" },
                    { 873, 175, "KAPKURES" },
                    { 874, 175, "RHODA" },
                    { 875, 175, "SHAABAB" },
                    { 876, 176, "BIASHARA" },
                    { 877, 176, "KIVUMBINI" },
                    { 878, 176, "FLAMINGO" },
                    { 879, 176, "MENENGAI" },
                    { 880, 176, "NAKURU EAST" },
                    { 881, 177, "KILGORIS CENTRAL" },
                    { 882, 177, "KEYIAN" },
                    { 883, 177, "ANGATA BARIKOI" },
                    { 884, 177, "SHANKOE" },
                    { 885, 177, "KIMINTET" },
                    { 886, 177, "LOLGORIAN" },
                    { 887, 178, "ILKERIN" },
                    { 888, 178, "OLOLMASANI" },
                    { 889, 178, "MOGONDO" },
                    { 890, 178, "KAPSASIAN" },
                    { 891, 179, "OLPUSIMORU" },
                    { 892, 179, "OLOKURTO" },
                    { 893, 179, "NAROK TOWN" },
                    { 894, 179, "NKARETA" },
                    { 895, 179, "OLORROPIL" },
                    { 896, 179, "MELILI" },
                    { 897, 180, "MOSIRO" },
                    { 898, 180, "ILDAMAT" },
                    { 899, 180, "KEEKONYOKIE" },
                    { 900, 180, "SUSWA" },
                    { 901, 181, "MAJIMOTO/NAROOSURA" },
                    { 902, 181, "OLOLULUNG'A" },
                    { 903, 181, "MELELO" },
                    { 904, 181, "LOITA" },
                    { 905, 181, "SOGOO" },
                    { 906, 181, "SAGAMIAN" },
                    { 907, 182, "ILMOTIOK" },
                    { 908, 182, "MARA" },
                    { 909, 182, "SIANA" },
                    { 910, 182, "NAIKARRA" },
                    { 911, 183, "OLKERI" },
                    { 912, 183, "ONGATA RONGAI" },
                    { 913, 183, "NKAIMURUNYA" },
                    { 914, 183, "OLOOLUA" },
                    { 915, 183, "NGONG" },
                    { 916, 184, "PURKO" },
                    { 917, 184, "ILDAMAT" },
                    { 918, 184, "DALALEKUTUK" },
                    { 919, 184, "MATAPATO NORTH" },
                    { 920, 184, "MATAPATO SOUTH" },
                    { 921, 185, "KAPUTIEI NORTH" },
                    { 922, 185, "KITENGELA" },
                    { 923, 185, "OLOOSIRKON/SHOLINKE" },
                    { 924, 185, "KENYAWA-POKA" },
                    { 925, 185, "IMARORO" },
                    { 926, 186, "KEEKONYOKIE" },
                    { 927, 186, "ILOODOKILANI" },
                    { 928, 186, "MAGADI" },
                    { 929, 186, "EWUASO OONKIDONG'I" },
                    { 930, 186, "MOSIRO" },
                    { 931, 187, "ENTONET/LENKISIM" },
                    { 932, 187, "MBIRIKANI/ESELENKEI" },
                    { 933, 187, "KUKU" },
                    { 934, 187, "ROMBO" },
                    { 935, 187, "KIMANA" },
                    { 936, 188, "LONDIANI" },
                    { 937, 188, "KEDOWA/KIMUGUL" },
                    { 938, 188, "CHEPSEON" },
                    { 939, 188, "TENDENO/SORGET" },
                    { 940, 189, "KUNYAK" },
                    { 941, 189, "KAMASIAN" },
                    { 942, 189, "KIPKELION" },
                    { 943, 189, "CHILCHILA" },
                    { 944, 190, "KAPSOIT" },
                    { 945, 190, "AINAMOI" },
                    { 946, 190, "KAPKUGERWET" },
                    { 947, 190, "KIPCHEBOR" },
                    { 948, 190, "KIPCHIMCHIM" },
                    { 949, 190, "KAPSAOS" },
                    { 950, 191, "KISIARA" },
                    { 951, 191, "TEBESONIK" },
                    { 952, 191, "CHEBOIN" },
                    { 953, 191, "CHEMOSOT" },
                    { 954, 191, "LITEIN" },
                    { 955, 191, "CHEPLANGET" },
                    { 956, 191, "KAPKATET" },
                    { 957, 192, "WALDAI" },
                    { 958, 192, "KABIANGA" },
                    { 959, 192, "CHEPTORORIET/SERETUT" },
                    { 960, 192, "CHAIK" },
                    { 961, 192, "KAPSUSER" },
                    { 962, 193, "SIGOWET" },
                    { 963, 193, "KAPLELARTET" },
                    { 964, 193, "SOLIAT" },
                    { 965, 193, "SOIN" },
                    { 966, 194, "NDANAI/ABOSI" },
                    { 967, 194, "CHEMAGEL" },
                    { 968, 194, "KIPSONOI" },
                    { 969, 194, "KAPLETUNDO" },
                    { 970, 194, "RONGENA/MANARET" },
                    { 971, 195, "KONG'ASIS" },
                    { 972, 195, "NYANGORES" },
                    { 973, 195, "SIGOR" },
                    { 974, 195, "CHEBUNYO" },
                    { 975, 195, "SIONGIROI" },
                    { 976, 196, "MERIGI" },
                    { 977, 196, "KEMBU" },
                    { 978, 196, "LONGISA" },
                    { 979, 196, "KIPRERES" },
                    { 980, 196, "CHEMANER" },
                    { 981, 197, "SILIBWET TOWNSHIP" },
                    { 982, 197, "NDARAWETA" },
                    { 983, 197, "SINGORWET" },
                    { 984, 197, "CHESOEN" },
                    { 985, 197, "MUTARAKWA" },
                    { 986, 198, "CHEPCHABAS" },
                    { 987, 198, "KIMULOT" },
                    { 988, 198, "MOGOGOSIEK" },
                    { 989, 198, "BOITO" },
                    { 990, 198, "EMBOMOS" },
                    { 991, 199, "MAUTUMA" },
                    { 992, 199, "LUGARI" },
                    { 993, 199, "LUMAKANDA" },
                    { 994, 199, "CHEKALINI" },
                    { 995, 199, "CHEVAYWA" },
                    { 996, 199, "LWANDETI" },
                    { 997, 200, "LIKUYANI" },
                    { 998, 200, "SANGO" },
                    { 999, 200, "KONGONI" },
                    { 1000, 200, "NZOIA" },
                    { 1001, 200, "SINOKO" },
                    { 1002, 201, "WEST KABRAS" },
                    { 1003, 201, "CHEMUCHE" },
                    { 1004, 201, "EAST KABRAS" },
                    { 1005, 201, "BUTALI/CHEGULO" },
                    { 1006, 201, "MANDA-SHIVANGA" },
                    { 1007, 201, "SHIRUGU-MUGAI" },
                    { 1008, 201, "SOUTH KABRAS" },
                    { 1009, 202, "BUTSOTSO EAST" },
                    { 1010, 202, "BUTSOTSO SOUTH" },
                    { 1011, 202, "BUTSOTSO CENTRAL" },
                    { 1012, 202, "SHEYWE" },
                    { 1013, 202, "MAHIAKALO" },
                    { 1014, 202, "SHIRERE" },
                    { 1015, 203, "INGOSTSE-MATHIA" },
                    { 1016, 203, "SHINOYI-SHIKOMARI-" },
                    { 1017, 203, "BUNYALA WEST" },
                    { 1018, 203, "BUNYALA EAST" },
                    { 1019, 203, "BUNYALA CENTRAL" },
                    { 1020, 204, "MUMIAS CENTRAL" },
                    { 1021, 204, "MUMIAS NORTH" },
                    { 1022, 204, "ETENJE" },
                    { 1023, 204, "MUSANDA" },
                    { 1024, 205, "LUBINU/LUSHEYA" },
                    { 1025, 205, "ISONGO/MAKUNGA/MALAHA" },
                    { 1026, 205, "EAST WANGA" },
                    { 1027, 206, "KOYONZO" },
                    { 1028, 206, "KHOLERA" },
                    { 1029, 206, "KHALABA" },
                    { 1030, 206, "MAYONI" },
                    { 1031, 206, "NAMAMALI" },
                    { 1032, 207, "MARAMA WEST" },
                    { 1033, 207, "MARAMA CENTRAL" },
                    { 1034, 207, "MARENYO - SHIANDA" },
                    { 1035, 207, "MARAMA NORTH" },
                    { 1036, 207, "MARAMA SOUTH" },
                    { 1037, 208, "KISA NORTH" },
                    { 1038, 208, "KISA EAST" },
                    { 1039, 208, "KISA WEST" },
                    { 1040, 208, "KISA CENTRAL" },
                    { 1041, 209, "ISUKHA NORTH" },
                    { 1042, 209, "MURHANDA" },
                    { 1043, 209, "ISUKHA CENTRAL" },
                    { 1044, 209, "ISUKHA SOUTH" },
                    { 1045, 209, "ISUKHA EAST" },
                    { 1046, 209, "ISUKHA WEST" },
                    { 1047, 210, "IDAKHO SOUTH" },
                    { 1048, 210, "IDAKHO EAST" },
                    { 1049, 210, "IDAKHO NORTH" },
                    { 1050, 210, "IDAKHO CENTRAL" },
                    { 1051, 211, "LUGAGA-WAMULUMA" },
                    { 1052, 211, "SOUTH MARAGOLI" },
                    { 1053, 211, "CENTRAL MARAGOLI" },
                    { 1054, 211, "MUNGOMA" },
                    { 1055, 212, "LYADUYWA/IZAVA" },
                    { 1056, 212, "WEST SABATIA" },
                    { 1057, 212, "CHAVAKALI" },
                    { 1058, 212, "NORTH MARAGOLI" },
                    { 1059, 212, "WODANGA" },
                    { 1060, 212, "BUSALI" },
                    { 1061, 213, "SHIRU" },
                    { 1062, 213, "MUHUDU" },
                    { 1063, 213, "SHAMAKHOKHO" },
                    { 1064, 213, "GISAMBAI" },
                    { 1065, 213, "BANJA" },
                    { 1066, 213, "TAMBUA" },
                    { 1067, 213, "JEPKOYAI" },
                    { 1068, 214, "LUANDA TOWNSHIP" },
                    { 1069, 214, "WEMILABI" },
                    { 1070, 214, "MWIBONA" },
                    { 1071, 214, "LUANDA SOUTH" },
                    { 1072, 214, "EMABUNGO" },
                    { 1073, 215, "NORTH EAST BUNYORE" },
                    { 1074, 215, "CENTRAL BUNYORE" },
                    { 1075, 215, "WEST BUNYORE" },
                    { 1076, 216, "CHEPTAIS" },
                    { 1077, 216, "CHESIKAKI" },
                    { 1078, 216, "CHEPYUK" },
                    { 1079, 216, "KAPKATENY" },
                    { 1080, 216, "KAPTAMA" },
                    { 1081, 216, "ELGON" },
                    { 1082, 217, "NAMWELA" },
                    { 1083, 217, "MALAKISI/SOUTH KULISIRU" },
                    { 1084, 217, "LWANDANYI" },
                    { 1085, 218, "KABUCHAI/CHWELE" },
                    { 1086, 218, "WEST NALONDO" },
                    { 1087, 218, "BWAKE/LUUYA" },
                    { 1088, 218, "MUKUYUNI" },
                    { 1089, 219, "SOUTH BUKUSU" },
                    { 1090, 219, "BUMULA" },
                    { 1091, 219, "KHASOKO" },
                    { 1092, 219, "KABULA" },
                    { 1093, 219, "KIMAETI" },
                    { 1094, 219, "WEST BUKUSU" },
                    { 1095, 219, "SIBOTI" },
                    { 1096, 220, "BUKEMBE WEST" },
                    { 1097, 220, "BUKEMBE EAST" },
                    { 1098, 220, "TOWNSHIP" },
                    { 1099, 220, "KHALABA" },
                    { 1100, 220, "MUSIKOMA" },
                    { 1101, 220, "EAST SANG'ALO" },
                    { 1102, 220, "MARAKARU/TUUTI" },
                    { 1103, 220, "SANG'ALO WEST" },
                    { 1104, 221, "MIHUU" },
                    { 1105, 221, "NDIVISI" },
                    { 1106, 221, "MARAKA" },
                    { 1107, 222, "MISIKHU" },
                    { 1108, 222, "SITIKHO" },
                    { 1109, 222, "MATULO" },
                    { 1110, 222, "BOKOLI" },
                    { 1111, 223, "KIMILILI" },
                    { 1112, 223, "KIBINGEI" },
                    { 1113, 223, "MAENI" },
                    { 1114, 223, "KAMUKUYWA" },
                    { 1115, 224, "MBAKALO" },
                    { 1116, 224, "NAITIRI/KABUYEFWE" },
                    { 1117, 224, "MILIMA" },
                    { 1118, 224, "NDALU/ TABANI" },
                    { 1119, 224, "TONGAREN" },
                    { 1120, 224, "SOYSAMBU/ MITUA" },
                    { 1121, 225, "MALABA CENTRAL" },
                    { 1122, 225, "MALABA NORTH" },
                    { 1123, 225, "ANG'URAI SOUTH" },
                    { 1124, 225, "ANG'URAI NORTH" },
                    { 1125, 225, "ANG'URAI EAST" },
                    { 1126, 225, "MALABA SOUTH" },
                    { 1127, 226, "ANG'OROM" },
                    { 1128, 226, "CHAKOL SOUTH" },
                    { 1129, 226, "CHAKOL NORTH" },
                    { 1130, 226, "AMUKURA WEST" },
                    { 1131, 226, "AMUKURA EAST" },
                    { 1132, 226, "AMUKURA CENTRAL" },
                    { 1133, 227, "NAMBALE TOWNSHIP" },
                    { 1134, 227, "BUKHAYO NORTH/WALTSI" },
                    { 1135, 227, "BUKHAYO EAST" },
                    { 1136, 227, "BUKHAYO CENTRAL" },
                    { 1137, 228, "BUKHAYO WEST" },
                    { 1138, 228, "MAYENJE" },
                    { 1139, 228, "MATAYOS SOUTH" },
                    { 1140, 228, "BUSIBWABO" },
                    { 1141, 228, "BURUMBA" },
                    { 1142, 229, "MARACHI WEST" },
                    { 1143, 229, "KINGANDOLE" },
                    { 1144, 229, "MARACHI CENTRAL" },
                    { 1145, 229, "MARACHI EAST" },
                    { 1146, 229, "MARACHI NORTH" },
                    { 1147, 229, "ELUGULU" },
                    { 1148, 230, "NAMBOBOTO NAMBUKU" },
                    { 1149, 230, "NANGINA" },
                    { 1150, 230, "AGENG'A NANGUBA" },
                    { 1151, 230, "BWIRI" },
                    { 1152, 231, "BUNYALA CENTRAL" },
                    { 1153, 231, "BUNYALA NORTH" },
                    { 1154, 231, "BUNYALA WEST" },
                    { 1155, 231, "BUNYALA SOUTH" },
                    { 1156, 232, "WEST UGENYA" },
                    { 1157, 232, "UKWALA" },
                    { 1158, 232, "NORTH UGENYA" },
                    { 1159, 232, "EAST UGENYA" },
                    { 1160, 233, "SIDINDI" },
                    { 1161, 233, "SIGOMERE" },
                    { 1162, 233, "UGUNJA" },
                    { 1163, 234, "USONGA" },
                    { 1164, 234, "WEST ALEGO" },
                    { 1165, 234, "CENTRAL ALEGO" },
                    { 1166, 234, "SIAYA TOWNSHIP" },
                    { 1167, 234, "NORTH ALEGO" },
                    { 1168, 234, "SOUTH EAST ALEGO" },
                    { 1169, 235, "NORTH GEM" },
                    { 1170, 235, "WEST GEM" },
                    { 1171, 235, "CENTRAL GEM" },
                    { 1172, 235, "YALA TOWNSHIP" },
                    { 1173, 235, "EAST GEM" },
                    { 1174, 235, "SOUTH GEM" },
                    { 1175, 236, "WEST YIMBO" },
                    { 1176, 236, "CENTRAL SAKWA" },
                    { 1177, 236, "SOUTH SAKWA" },
                    { 1178, 236, "YIMBO EAST" },
                    { 1179, 236, "WEST SAKWA" },
                    { 1180, 236, "NORTH SAKWA" },
                    { 1181, 237, "EAST ASEMBO" },
                    { 1182, 237, "WEST ASEMBO" },
                    { 1183, 237, "NORTH UYOMA" },
                    { 1184, 237, "SOUTH UYOMA" },
                    { 1185, 237, "WEST UYOMA" },
                    { 1186, 238, "KAJULU" },
                    { 1187, 238, "KOLWA EAST" },
                    { 1188, 238, "MANYATTA 'B'" },
                    { 1189, 238, "NYALENDA 'A'" },
                    { 1190, 238, "KOLWA CENTRAL" },
                    { 1191, 239, "SOUTH WEST KISUMU" },
                    { 1192, 239, "CENTRAL KISUMU" },
                    { 1193, 239, "KISUMU NORTH" },
                    { 1194, 239, "WEST KISUMU" },
                    { 1195, 239, "NORTH WEST KISUMU" },
                    { 1196, 240, "RAILWAYS" },
                    { 1197, 240, "MIGOSI" },
                    { 1198, 240, "SHAURIMOYO KALOLENI" },
                    { 1199, 240, "MARKET MILIMANI" },
                    { 1200, 240, "KONDELE" },
                    { 1201, 240, "NYALENDA B" },
                    { 1202, 241, "WEST SEME" },
                    { 1203, 241, "CENTRAL SEME" },
                    { 1204, 241, "EAST SEME" },
                    { 1205, 241, "NORTH SEME" },
                    { 1206, 242, "EAST KANO/WAWIDHI" },
                    { 1207, 242, "AWASI/ONJIKO" },
                    { 1208, 242, "AHERO" },
                    { 1209, 242, "KABONYO/KANYAGWAL" },
                    { 1210, 242, "KOBURA" },
                    { 1211, 243, "MIWANI" },
                    { 1212, 243, "OMBEYI" },
                    { 1213, 243, "MASOGO/NYANG'OMA" },
                    { 1214, 243, "CHEMELIL" },
                    { 1215, 243, "MUHORONI/KORU" },
                    { 1216, 244, "SOUTH WEST NYAKACH" },
                    { 1217, 244, "NORTH NYAKACH" },
                    { 1218, 244, "CENTRAL NYAKACH" },
                    { 1219, 244, "WEST NYAKACH" },
                    { 1220, 244, "SOUTH EAST NYAKACH" },
                    { 1221, 245, "WEST KASIPUL" },
                    { 1222, 245, "SOUTH KASIPUL" },
                    { 1223, 245, "CENTRAL KASIPUL" },
                    { 1224, 245, "EAST KAMAGAK" },
                    { 1225, 245, "WEST KAMAGAK" },
                    { 1226, 246, "KABONDO EAST" },
                    { 1227, 246, "KABONDO WEST" },
                    { 1228, 246, "KOKWANYO/KAKELO" },
                    { 1229, 246, "KOJWACH" },
                    { 1230, 247, "WEST KARACHUONYO" },
                    { 1231, 247, "NORTH KARACHUONYO" },
                    { 1232, 247, "CENTRAL" },
                    { 1233, 247, "KANYALUO" },
                    { 1234, 247, "KIBIRI" },
                    { 1235, 247, "WANGCHIENG" },
                    { 1236, 247, "KENDU BAY TOWN" },
                    { 1237, 248, "WEST GEM" },
                    { 1238, 248, "EAST GEM" },
                    { 1239, 248, "KAGAN" },
                    { 1240, 248, "KOCHIA" },
                    { 1241, 249, "HOMA BAY CENTRAL" },
                    { 1242, 249, "HOMA BAY ARUJO" },
                    { 1243, 249, "HOMA BAY WEST" },
                    { 1244, 249, "HOMA BAY EAST" },
                    { 1245, 250, "KWABWAI" },
                    { 1246, 250, "KANYADOTO" },
                    { 1247, 250, "KANYIKELA" },
                    { 1248, 250, "NORTH KABUOCH" },
                    { 1249, 250, "KABUOCH SOUTH/PALA" },
                    { 1250, 250, "KANYAMWA KOLOGI" },
                    { 1251, 250, "KANYAMWA KOSEWE" },
                    { 1252, 251, "MFANGANO ISLAND" },
                    { 1253, 251, "RUSINGA ISLAND" },
                    { 1254, 251, "KASGUNGA" },
                    { 1255, 251, "GEMBE" },
                    { 1256, 251, "LAMBWE" },
                    { 1257, 252, "GWASSI SOUTH" },
                    { 1258, 252, "GWASSI NORTH" },
                    { 1259, 252, "KAKSINGRI WEST" },
                    { 1260, 252, "RUMA KAKSINGRI EAST" },
                    { 1261, 253, "NORTH KAMAGAMBO" },
                    { 1262, 253, "CENTRAL KAMAGAMBO" },
                    { 1263, 253, "EAST KAMAGAMBO" },
                    { 1264, 253, "SOUTH KAMAGAMBO" },
                    { 1265, 254, "NORTH SAKWA" },
                    { 1266, 254, "SOUTH SAKWA" },
                    { 1267, 254, "WEST SAKWA" },
                    { 1268, 254, "CENTRAL SAKWA" },
                    { 1269, 255, "GOD JOPE" },
                    { 1270, 255, "SUNA CENTRAL" },
                    { 1271, 255, "KAKRAO" },
                    { 1272, 255, "KWA" },
                    { 1273, 256, "WIGA" },
                    { 1274, 256, "WASWETA II" },
                    { 1275, 256, "RAGANA-ORUBA" },
                    { 1276, 256, "WASIMBETE" },
                    { 1277, 257, "WEST KANYAMKAGO" },
                    { 1278, 257, "NORTH KANYAMKAGO" },
                    { 1279, 257, "CENTRAL KANYAMKAGO" },
                    { 1280, 257, "SOUTH KANYAMKAGO" },
                    { 1281, 257, "EAST KANYAMKAGO" },
                    { 1282, 258, "KACHIEN'G" },
                    { 1283, 258, "KANYASA" },
                    { 1284, 258, "NORTH KADEM" },
                    { 1285, 258, "MACALDER/KANYARWANDA" },
                    { 1286, 258, "KALER" },
                    { 1287, 258, "GOT KACHOLA" },
                    { 1288, 258, "MUHURU" },
                    { 1289, 259, "BUKIRA EAST" },
                    { 1290, 259, "BUKIRA CENTRL/IKEREGE" },
                    { 1291, 259, "ISIBANIA" },
                    { 1292, 259, "MAKERERO" },
                    { 1293, 259, "MASABA" },
                    { 1294, 259, "TAGARE" },
                    { 1295, 259, "NYAMOSENSE/KOMOSOKO" },
                    { 1296, 260, "GOKEHARAKA/GETAMBWEGA" },
                    { 1297, 260, "NTIMARU WEST" },
                    { 1298, 260, "NTIMARU EAST" },
                    { 1299, 260, "NYABASI EAST" },
                    { 1300, 260, "NYABASI WEST" },
                    { 1301, 261, "BOMARIBA" },
                    { 1302, 261, "BOGIAKUMU" },
                    { 1303, 261, "BOMORENDA" },
                    { 1304, 261, "RIANA" },
                    { 1305, 262, "TABAKA" },
                    { 1306, 262, "BOIKANG'A" },
                    { 1307, 262, "BOGETENGA" },
                    { 1308, 262, "BORABU / CHITAGO" },
                    { 1309, 262, "MOTICHO" },
                    { 1310, 262, "GETENGA" },
                    { 1311, 263, "BOMBABA BORABU" },
                    { 1312, 263, "BOOCHI BORABU" },
                    { 1313, 263, "BOKIMONGE" },
                    { 1314, 263, "MAGENCHE" },
                    { 1315, 264, "MASIGE WEST" },
                    { 1316, 264, "MASIGE EAST" },
                    { 1317, 264, "BOBASI CENTRAL" },
                    { 1318, 264, "NYACHEKI" },
                    { 1319, 264, "BOBASI BOGETAORIO" },
                    { 1320, 264, "BOBASI CHACHE" },
                    { 1321, 264, "SAMETA/MOKWERERO" },
                    { 1322, 264, "BOBASI BOITANGARE" },
                    { 1323, 265, "MAJOGE" },
                    { 1324, 265, "BOOCHI/TENDERE" },
                    { 1325, 265, "BOSOTI/SENGERA" },
                    { 1326, 266, "ICHUNI" },
                    { 1327, 266, "NYAMASIBI" },
                    { 1328, 266, "MASIMBA" },
                    { 1329, 266, "GESUSU" },
                    { 1330, 266, "KIAMOKAMA" },
                    { 1331, 267, "BOBARACHO" },
                    { 1332, 267, "KISII CENTRAL" },
                    { 1333, 267, "KEUMBU" },
                    { 1334, 267, "KIOGORO" },
                    { 1335, 267, "BIRONGO" },
                    { 1336, 267, "IBENO" },
                    { 1337, 268, "MONYERERO" },
                    { 1338, 268, "SENSI" },
                    { 1339, 268, "MARANI" },
                    { 1340, 268, "KEGOGI" },
                    { 1341, 269, "BOGUSERO" },
                    { 1342, 269, "BOGEKA" },
                    { 1343, 269, "NYAKOE" },
                    { 1344, 269, "KITUTU   CENTRAL" },
                    { 1345, 269, "NYATIEKO" },
                    { 1346, 270, "RIGOMA" },
                    { 1347, 270, "GACHUBA" },
                    { 1348, 270, "KEMERA" },
                    { 1349, 270, "MAGOMBO" },
                    { 1350, 270, "MANGA" },
                    { 1351, 270, "GESIMA" },
                    { 1352, 271, "NYAMAIYA" },
                    { 1353, 271, "BOGICHORA" },
                    { 1354, 271, "BOSAMARO" },
                    { 1355, 271, "BONYAMATUTA" },
                    { 1356, 271, "TOWNSHIP" },
                    { 1357, 272, "ITIBO" },
                    { 1358, 272, "BOMWAGAMO" },
                    { 1359, 272, "BOKEIRA" },
                    { 1360, 272, "MAGWAGWA" },
                    { 1361, 272, "EKERENYO" },
                    { 1362, 273, "MEKENENE" },
                    { 1363, 273, "KIABONYORU" },
                    { 1364, 273, "NYANSIONGO" },
                    { 1365, 273, "ESISE" },
                    { 1366, 274, "KITISURU" },
                    { 1367, 274, "PARKLANDS/HIGHRIDGE" },
                    { 1368, 274, "KARURA" },
                    { 1369, 274, "KANGEMI" },
                    { 1370, 274, "MOUNTAIN VIEW" },
                    { 1371, 275, "KILIMANI" },
                    { 1372, 275, "KAWANGWARE" },
                    { 1373, 275, "GATINA" },
                    { 1374, 275, "KILELESHWA" },
                    { 1375, 275, "KABIRO" },
                    { 1376, 276, "MUTUINI" },
                    { 1377, 276, "NGANDO" },
                    { 1378, 276, "RIRUTA" },
                    { 1379, 276, "UTHIRU/RUTHIMITU" },
                    { 1380, 276, "WAITHAKA" },
                    { 1381, 277, "KAREN" },
                    { 1382, 277, "NAIROBI WEST" },
                    { 1383, 277, "MUGUMO-INI" },
                    { 1384, 277, "SOUTH-C" },
                    { 1385, 277, "NYAYO HIGHRISE" },
                    { 1386, 278, "LAINI SABA" },
                    { 1387, 278, "LINDI" },
                    { 1388, 278, "MAKINA" },
                    { 1389, 278, "WOODLEY/KENYATTA GOLF" },
                    { 1390, 278, "SARANGOMBE" },
                    { 1391, 279, "GITHURAI" },
                    { 1392, 279, "KAHAWA WEST" },
                    { 1393, 279, "ZIMMERMAN" },
                    { 1394, 279, "ROYSAMBU" },
                    { 1395, 279, "KAHAWA" },
                    { 1396, 280, "CLAYCITY" },
                    { 1397, 280, "MWIKI" },
                    { 1398, 280, "KASARANI" },
                    { 1399, 280, "NJIRU" },
                    { 1400, 280, "RUAI" },
                    { 1401, 281, "BABA DOGO" },
                    { 1402, 281, "UTALII" },
                    { 1403, 281, "MATHARE NORTH" },
                    { 1404, 281, "LUCKY SUMMER" },
                    { 1405, 281, "KOROGOCHO" },
                    { 1406, 282, "IMARA DAIMA" },
                    { 1407, 282, "KWA NJENGA" },
                    { 1408, 282, "KWA REUBEN" },
                    { 1409, 282, "PIPELINE" },
                    { 1410, 282, "KWARE" },
                    { 1411, 283, "KARIOBANGI NORTH" },
                    { 1412, 283, "DANDORA AREA I" },
                    { 1413, 283, "DANDORA AREA II" },
                    { 1414, 283, "DANDORA AREA III" },
                    { 1415, 283, "DANDORA AREA IV" },
                    { 1416, 284, "KAYOLE NORTH" },
                    { 1417, 284, "KAYOLE CENTRAL" },
                    { 1418, 284, "KAYOLE SOUTH" },
                    { 1419, 284, "KOMAROCK" },
                    { 1420, 284, "MATOPENI" },
                    { 1421, 285, "UPPER SAVANNAH" },
                    { 1422, 285, "LOWER SAVANNAH" },
                    { 1423, 285, "EMBAKASI" },
                    { 1424, 285, "UTAWALA" },
                    { 1425, 285, "MIHANGO" },
                    { 1426, 286, "UMOJA I" },
                    { 1427, 286, "UMOJA II" },
                    { 1428, 286, "MOWLEM" },
                    { 1429, 286, "KARIOBANGI SOUTH" },
                    { 1430, 287, "MAKONGENI" },
                    { 1431, 287, "MARINGO/HAMZA" },
                    { 1432, 287, "HARAMBEE" },
                    { 1433, 287, "VIWANDANI" },
                    { 1434, 288, "PUMWANI" },
                    { 1435, 288, "EASTLEIGH NORTH" },
                    { 1436, 288, "EASTLEIGH SOUTH" },
                    { 1437, 288, "AIRBASE" },
                    { 1438, 288, "CALIFORNIA" },
                    { 1439, 289, "NAIROBI CENTRAL" },
                    { 1440, 289, "NGARA" },
                    { 1441, 289, "ZIWANI/KARIOKOR" },
                    { 1442, 289, "PANGANI" },
                    { 1443, 289, "LANDIMAWE" },
                    { 1444, 289, "NAIROBI SOUTH" },
                    { 1445, 290, "HOSPITAL" },
                    { 1446, 290, "MABATINI" },
                    { 1447, 290, "HURUMA" },
                    { 1448, 290, "NGEI" },
                    { 1449, 290, "MLANGO KUBWA" },
                    { 1450, 290, "KIAMAIKO" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "ward",
                keyColumn: "id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "subcounty",
                keyColumn: "id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "county",
                keyColumn: "id",
                keyValue: 47);
        }
    }
}
