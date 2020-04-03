using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Services.Models;

namespace WebApplication.Services
{
    public static class Db
    {
        public static List<Manufacturer> GetManufacturers()
        {
            return new List<Manufacturer>
            {
                new Manufacturer {Id = "E74EA75C-EF51-40E1-BD83-086805F32060", ManufacturerName = "STARCRAFT"},
                new Manufacturer {Id = "33E32587-A5A8-4CF9-86EE-093197C63776", ManufacturerName = "AUDI"},
                new Manufacturer {Id = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3", ManufacturerName = "LAMBORGHINI"},
                new Manufacturer {Id = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349", ManufacturerName = "ISUZU"},
                new Manufacturer {Id = "7C092475-3EB2-47F9-A583-0DD5576E8005", ManufacturerName = "FIAT"},
                new Manufacturer {Id = "65D6C514-C10C-45E1-A5B3-0E499F47128E", ManufacturerName = "HYUNDAI"},
                new Manufacturer {Id = "3D958555-0A1D-4463-B6B4-17F71012D660", ManufacturerName = "DODGE"},
                new Manufacturer {Id = "8C2F5142-08DC-441B-8D22-1AACF475B1EE", ManufacturerName = "PEUGEOT"},
                new Manufacturer {Id = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6", ManufacturerName = "EUROPE FORD"},
                new Manufacturer {Id = "43C2D407-171C-4061-AB7E-1F45C200E6EB", ManufacturerName = "AMG"},
                new Manufacturer {Id = "C095FB9A-6616-420F-B6F7-1F9060F9F662", ManufacturerName = "ROLLSROYCE"},
                new Manufacturer {Id = "E665180E-DA4B-45A0-95E7-21AFFF4201FB", ManufacturerName = "BUICK"},
                new Manufacturer {Id = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E", ManufacturerName = "MASERATI"},
                new Manufacturer {Id = "2D0D8E51-08A8-40C3-B729-25F002493322", ManufacturerName = "SUZUKI"},
                new Manufacturer {Id = "D43FCB87-8EB3-4BDC-999F-289DDC3E494E", ManufacturerName = "DAIMLER"},
                new Manufacturer {Id = "7B32052D-44BE-4F29-BFEB-31ECEFBD19C8", ManufacturerName = "LANCIA"},
                new Manufacturer {Id = "5B86E249-FAEA-48D0-8378-34B357C73E10", ManufacturerName = "CT&T"},
                new Manufacturer {Id = "E456911F-2C35-43C8-A3D1-3561B774BCEF", ManufacturerName = "NISSAN"},
                new Manufacturer {Id = "C35A4E7B-0E1A-4002-B648-47F537CA7BF1", ManufacturerName = "ASTON MARTIN"},
                new Manufacturer {Id = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783", ManufacturerName = "TOYOTA"},
                new Manufacturer {Id = "20697E01-ED05-41CC-A815-4D2E3A4CE99C", ManufacturerName = "YES"},
                new Manufacturer {Id = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39", ManufacturerName = "OPEL"},
                new Manufacturer {Id = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6", ManufacturerName = "DAIHATSU"},
                new Manufacturer {Id = "F63C4D3F-85F9-46BA-9938-504E4780525F", ManufacturerName = "SUBARU"},
                new Manufacturer {Id = "D31751D4-7306-4C92-90D1-58ED12ACB972", ManufacturerName = "LINCOLN"},
                new Manufacturer {Id = "F7087EC7-9392-4626-B641-5B006B93ED29", ManufacturerName = "HONDA"},
                new Manufacturer {Id = "66959688-287F-4DBB-BE10-5D54DFD78F5B", ManufacturerName = "ABARTH"},
                new Manufacturer {Id = "AE937731-F027-408A-AB12-5DEB80B45C60", ManufacturerName = "PONTIAC"},
                new Manufacturer {Id = "85716B45-8139-491C-B0A4-5E31D4419A3D", ManufacturerName = "HUMMER"},
                new Manufacturer {Id = "A7489A80-F142-496A-B776-5E8FBACFD8E0", ManufacturerName = "MAZDA"},
                new Manufacturer {Id = "DA040730-9659-498A-994E-5F7F6852208D", ManufacturerName = "AUTOBIANCHI"},
                new Manufacturer {Id = "B1A413BA-2C00-4A59-9910-66AEDECDA9E3", ManufacturerName = "DONKERVOORT"},
                new Manufacturer {Id = "1F23F337-7B28-4B8D-A816-6B9DB1FD0360", ManufacturerName = "MINI"},
                new Manufacturer {Id = "C75E9153-364D-49FC-9C66-6BFA58F98FFB", ManufacturerName = "CITROEN"},
                new Manufacturer {Id = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816", ManufacturerName = "CHRYSLER"},
                new Manufacturer {Id = "B226A88A-B460-4098-9C49-75A711B58867", ManufacturerName = "ROVER"},
                new Manufacturer {Id = "DDD335EF-C0CA-4917-AF81-774FD2A7270B", ManufacturerName = "BENTLEY"},
                new Manufacturer {Id = "9370C145-D1FC-4F86-AC18-7934D2FD996B", ManufacturerName = "TIARA"},
                new Manufacturer {Id = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01", ManufacturerName = "BMW ALPINA"},
                new Manufacturer {Id = "8C239C9E-93BB-41F8-8712-7C0860EE71EC", ManufacturerName = "VOLVO"},
                new Manufacturer {Id = "450FD683-7A50-4E7A-8B71-7DD109689740", ManufacturerName = "MORGAN"},
                new Manufacturer {Id = "0975EF88-66CE-47CC-A7F3-7FA7E4C0DC02", ManufacturerName = "SAAB"},
                new Manufacturer {Id = "43E2EF54-A8C5-475B-B124-861D47C989C0", ManufacturerName = "KIA"},
                new Manufacturer {Id = "DD102D49-CFB6-46D2-A262-864413466FA6", ManufacturerName = "Alfa Romeo"},
                new Manufacturer {Id = "5C080CDE-C53D-46BF-A01B-8DC503AD40AA", ManufacturerName = "MERCURY"},
                new Manufacturer {Id = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A", ManufacturerName = "JAGUAR"},
                new Manufacturer {Id = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF", ManufacturerName = "CADILLAC"},
                new Manufacturer {Id = "6B055302-3A0E-473A-81AB-AA6B85DE14A2", ManufacturerName = "MERCEDES AMG"},
                new Manufacturer {Id = "41BB5DF9-29F2-4025-BB4E-B94EE3B60615", ManufacturerName = "MAYBACH"},
                new Manufacturer {Id = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC", ManufacturerName = "FORD"},
                new Manufacturer {Id = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E", ManufacturerName = "BMW"},
                new Manufacturer {Id = "B61227A8-C640-480B-A3AB-C3826A401516", ManufacturerName = "MITSUOKA"},
                new Manufacturer {Id = "973BFABB-07A0-4F76-8635-C77A306F4F7A", ManufacturerName = "EUNOS"},
                new Manufacturer {Id = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC", ManufacturerName = "LEXUS"},
                new Manufacturer {Id = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E", ManufacturerName = "VOLKSWAGEN"},
                new Manufacturer {Id = "FA8113E4-C57D-4A50-866F-CD97B9400696", ManufacturerName = "MERCEDES BENZ"},
                new Manufacturer {Id = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A", ManufacturerName = "RENAULT"},
                new Manufacturer {Id = "19425355-B6C3-434C-867F-CFECF2AF5A74", ManufacturerName = "CHEVROLET"},
                new Manufacturer {Id = "1A8ED648-F63A-4138-899A-D2BB23DC8E39", ManufacturerName = "PORSCHE"},
                new Manufacturer {Id = "F9884273-31EB-4E1F-AE54-D647F4EAE72D", ManufacturerName = "MITSUBISHI"},
                new Manufacturer {Id = "46DE7CC6-17D5-492E-9F77-D903F206AF4A", ManufacturerName = "MG"},
                new Manufacturer {Id = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9", ManufacturerName = "LAND ROVER"},
                new Manufacturer {Id = "82A2A0EE-8DD1-4F27-9356-E9A5AF96F6AE", ManufacturerName = "DAEWOO"},
                new Manufacturer {Id = "DA89378F-9575-418A-A0A3-EB06C6249000", ManufacturerName = "VENTURI"},
                new Manufacturer {Id = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337", ManufacturerName = "FERRARI"},
                new Manufacturer {Id = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F", ManufacturerName = "SMART"},
                new Manufacturer {Id = "557AD2D9-8F4B-439D-9D0F-EC93BFD9939A", ManufacturerName = "SATURN"},
                new Manufacturer {Id = "4588CAD8-90C2-4E00-A729-F063C024722E", ManufacturerName = "TVR"},
                new Manufacturer {Id = "D2625ADD-806B-4056-9895-F18ADB012FC3", ManufacturerName = "LOTUS"},
                new Manufacturer {Id = "33C29264-B292-4852-9142-F4BC5561C3CC", ManufacturerName = "FORD JAPAN"},
                new Manufacturer {Id = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271", ManufacturerName = "CHRYSLER JEEP"},
            };
        }

        public static List<VehicleModel> GetModels()
        {
            return new List<VehicleModel>
            {
                new VehicleModel
                {
                    Id = "066E509D-4C23-4C70-B7C5-00116F047889", ModelName = "マークIIワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "55010F1F-5269-4B44-AFA6-004EB16104B5", ModelName = "eKワゴン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "533CCA0D-6016-421F-B264-0066206FCF74", ModelName = "RS4",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "C69B0FE1-4531-4B58-A9DA-008FAEB9FBD0", ModelName = "M6",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "B911EF47-A4AA-4E09-8C9E-00B9BD06449B", ModelName = "488GTB",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "CC573AB7-61A4-4D35-A8E7-00BBCE1DD49D", ModelName = "アバルト500C",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "2FEE0D5F-6FB2-4600-956E-011424805B36", ModelName = "RS Q3",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "D3A615D4-E7C5-4C9D-9899-0156731615C5", ModelName = "ティーダ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "E863A653-B7C5-4DFF-A0C4-0159581870B7", ModelName = "ラティオ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "5A100AE3-FC2F-4727-BA8E-017FACCB863C", ModelName = "ワゴンR+(プラス)",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "922F41E5-3521-4DD8-9015-018337BA94A4", ModelName = "R2",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "18B737D0-813F-460F-B864-01855160D3F0", ModelName = "240ワゴン",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "BC2EA9B5-94C2-4A29-8B55-018BC414E7E6", ModelName = "ネイキッド",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "8FC665B7-2E55-4EC5-AB8D-01A1AA2E1FED", ModelName = "RCZ",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "A3194FFD-F36C-43BF-A8F3-01E114D6B0DF", ModelName = "ジェッタ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "DAC68DBD-7E2F-4108-B830-01F9A5164729", ModelName = "セイバー",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "21DFFD5C-64A7-44E3-B0C6-02071EB3F9BD", ModelName = "オールロードクワトロ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "C02291EC-BCB7-40A3-A827-02224FFC7143", ModelName = "センチュリー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "5AD5C74B-3A4C-4B11-9B7A-0247DB49D1D4", ModelName = "コルト",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "10299BEA-A40D-4B7B-8B3B-028D759B9119", ModelName = "ディスカバリー",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "43A80A10-8064-4CFA-B1F0-035B086915E5", ModelName = "インプレッサリトナ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "C6119560-6BC7-4E75-8C1D-035C31CD87B5", ModelName = "パサートGTE",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "6968BDCD-4C97-49E2-BA09-038AF2F5915A", ModelName = "ビュイックリーガル",
                    ManufacturerId = "E665180E-DA4B-45A0-95E7-21AFFF4201FB"
                },
                new VehicleModel
                {
                    Id = "6030C518-28FA-4721-AC5B-039886110A9A", ModelName = "F430スパイダー",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "095C6B67-3182-465F-B029-03B704F74851", ModelName = "セリカ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6A9EAE1D-BF3E-494D-A5E6-03F83D2E4F76", ModelName = "SX4",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "B24D23B7-0949-443D-A4F8-042F0CCD66E8", ModelName = "リンカーン・タウンカー",
                    ManufacturerId = "D31751D4-7306-4C92-90D1-58ED12ACB972"
                },
                new VehicleModel
                {
                    Id = "59062A6D-94A6-428B-B415-04C81CAD9416", ModelName = "ベクトラ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "C8B3087A-32D4-4949-9B23-05605234249E", ModelName = "アクセラ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "62B02568-3A89-4515-B462-058838588152", ModelName = "MR2",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "746328C4-40B8-4D93-A58E-05A679A2E743", ModelName = "インプレッサ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "6287A2D7-3387-43D3-887D-05AD3F55D0F2", ModelName = "MR-S",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "69C902ED-B19D-4717-B7A1-05BE819DD725", ModelName = "A5スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "7595CD6D-37FD-46AF-80B3-05C65ECDA4FF", ModelName = "パークウォード",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "4C3D5139-23F2-4A5F-BE94-05F31D1722FE", ModelName = "ミラージュ・アスティ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "37E1788D-2232-41F4-85CF-05F7D84C047D", ModelName = "タウンボックス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "1D21DE33-F96F-4137-9495-05FE44F16CEA", ModelName = "605",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "941C47E8-F650-48EB-9892-062978D79E13", ModelName = "エリオセダン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "C8439375-62C4-4099-921C-064EFDC96187", ModelName = "ビガー",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "F3956DBB-BA92-4A7D-AC32-069877F78BFD", ModelName = "ギャラン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "43E496C6-2D32-4EB9-AB22-06D4F1B7A6F1", ModelName = "アズール",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "DECE0E21-750F-4367-BAB5-06EEEF368E09", ModelName = "フレアカスタムスタイル",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "AB81FCA6-89FC-4410-B8ED-06FFD795C460", ModelName = "アイミーブ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "C7BD9B13-E274-43D6-BA20-073851FDA0FF", ModelName = "エクリプススパイダー",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "1CA7B9C7-D8A7-4FF9-AD9F-07B62F876468", ModelName = "ライトエースノア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "25272D86-1CBA-45FB-80FA-07FD6129E7C2", ModelName = "アトレー",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "A0FAE532-DF7B-4D43-9FE2-086EC948B852", ModelName = "アストラ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "9A225878-ECC4-4C8F-AE3D-08CF84D40900", ModelName = "ユーノス300",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "3CB05107-0651-4297-0442-08D706C27031", ModelName = "MB E350A",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "38ECC9C3-7A2D-4520-8823-08DB7B5302BA", ModelName = "アリスト",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "62C0637B-9831-486F-BD71-08EF1D73F1C6", ModelName = "リベロ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "47293282-AE11-40B5-94C3-0962326C6929", ModelName = "エスプリ",
                    ManufacturerId = "D2625ADD-806B-4056-9895-F18ADB012FC3"
                },
                new VehicleModel
                {
                    Id = "4A232E87-C85B-40DF-BD58-09784F0BFA4E", ModelName = "カルタス",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "65EF37EE-92A8-45B5-BE7D-0991A2522482", ModelName = "カローラルミオン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "3B98A0A7-8434-4A65-80E2-09A80467D206", ModelName = "シグナム",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "89D4E537-2B08-46E8-835F-09AD78D22D2B", ModelName = "GT 4ドアクーペ",
                    ManufacturerId = "6B055302-3A0E-473A-81AB-AA6B85DE14A2"
                },
                new VehicleModel
                {
                    Id = "64CFAE6E-1476-4A60-AE86-09E2794A64FF", ModelName = "プレーリージョイ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "82528B52-498F-4FBD-BC53-09E79B9935B9", ModelName = "GLAクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "0AAEF21A-F38E-4862-87FC-09F122E1EAD3", ModelName = "エディックス",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "80706386-4796-4125-93EC-09F773011CB3", ModelName = "ユーノスロードスター",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "CFE48B73-760E-4C75-9D8C-09FC219E9234", ModelName = "プレオカスタム",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "55DC9984-C9ED-420B-940C-0A3A92D24A72", ModelName = "400",
                    ManufacturerId = "B226A88A-B460-4098-9C49-75A711B58867"
                },
                new VehicleModel
                {
                    Id = "0BC8302E-059B-4349-B0DC-0A6DD68D51A7", ModelName = "トゥデイ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "14E8FEBE-4895-461D-A78D-0AEA5738B2B3", ModelName = "ゴルフヴァリアント",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "0791625B-F3BB-44AA-837D-0B25CBCEED43", ModelName = "ヒュンダイクーペ",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "193D3ACB-B744-4D3D-B59D-0B465AF058B4", ModelName = "エクストレイル",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "D20485EB-34D9-4016-9B9E-0BCD6D268CF3", ModelName = "MIRAI",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "0A37234C-108A-4292-B3D2-0BDC530930A7", ModelName = "キャデラックCTS",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "A43E186A-C0A5-46AA-ABB9-0C1542F47277", ModelName = "ライトエースワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "3A46561C-1A6F-482D-88B8-0C3CB42EC6E4", ModelName = "GTC4ルッソ",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "161006A1-2841-471A-9A97-0C90D66D4570", ModelName = "プレーリー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "AE6A5DC4-E285-4026-93DE-0D25E78091F1", ModelName = "パッソセッテ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "DBA8E259-432D-4A64-9180-0D38F81584EE", ModelName = "ファントム",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "A8EEE0AA-78E3-44FC-BC08-0D3A48655B39", ModelName = "SLS AMG",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "A3A96724-EE60-45FF-8CE1-0D44F7F77735", ModelName = "エアウェイブ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "141C2000-1889-4A8E-8AD3-0D5096FF2EB8", ModelName = "ヴォクシー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "0ECD5080-697E-483A-B2F9-0D6DFCA026DC", ModelName = "GLC",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "13BCBEC0-AC3E-4F53-A6C9-0DAA38E39B4A", ModelName = "850エステート",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "72E289D2-FB8A-4EEF-B575-0DB63B2BA976", ModelName = "B3",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "94B3A31C-9570-47EC-9D5E-0DB8B978A9FB", ModelName = "アリオン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "12F48961-F932-4BF2-A634-0DFB1FB6E531", ModelName = "ムルシエラゴ",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "E9AD8CA6-8659-461F-B3AA-0E125A55CF3C", ModelName = "ブルーバード",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "1BACB566-973E-4346-9F5D-0E1527273A70", ModelName = "ファミリアワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "0FDB1ACD-629E-48A1-801B-0E198BBE4367", ModelName = "ルークス",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "5CA80DA1-4385-4EDD-AFED-0E4636C92FDC", ModelName = "バモスホビオ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B39FD7B2-089B-4918-B94D-0E8487AC2BF2", ModelName = "STARCRAFT",
                    ManufacturerId = "E74EA75C-EF51-40E1-BD83-086805F32060"
                },
                new VehicleModel
                {
                    Id = "1A5341CC-556C-4F1A-B739-0E9F11B1AE1E", ModelName = "ミラージュ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "5C8CDDBA-10EC-4F56-AE17-0EC2BD9C5FC4", ModelName = "フィエスタ",
                    ManufacturerId = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6"
                },
                new VehicleModel
                {
                    Id = "22360FEA-DE7D-4176-ADAF-0F08E8054508", ModelName = "プレオプラス",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "31232967-179B-4D2A-B7D2-0F3A8597490B", ModelName = "カルタスクレセントワゴン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "90C1B55F-1104-4E8B-B6D0-0F3FDBC799F7", ModelName = "スイフト",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "10686087-DA31-4063-8907-0F41768E5740", ModelName = "Aクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "D1B06896-652A-4823-9FA3-0F45DBAEAEEC", ModelName = "ハマーH3",
                    ManufacturerId = "85716B45-8139-491C-B0A4-5E31D4419A3D"
                },
                new VehicleModel
                {
                    Id = "A95C651F-5CC7-47E5-8DE9-0F9A96B19D77", ModelName = "カローラワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B50DD3DA-BF01-4915-A4ED-0FC1E122A9C0", ModelName = "TT RSロードスター",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "399F81FC-60DE-42F4-85E8-0FF65F0E00AE", ModelName = "モコ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "DD6D301C-4FDB-4837-A2E9-100DA5BCBA8B", ModelName = "パサート",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "F429F6EE-15D6-4DCA-A0BA-10ACC84F2A8F", ModelName = "モビリオ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "04820D98-F5AD-4A4B-8896-10B14E45CE0C", ModelName = "リバティ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "955D322A-4922-4E2F-B4C9-10C551CC1C1C", ModelName = "ノート",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "73FE9B24-A2B2-4466-990A-10E8AA582E32", ModelName = "クーペFIAT",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "445D3C3D-12C3-4B1E-A37D-10E9D15B1705", ModelName = "セドリック",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "E9EA4B95-A962-4447-9A77-11727619B574", ModelName = "セニック",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "E2A4EF9A-2FAA-46D7-A01C-117400D32113", ModelName = "bB",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "BD5151B1-5FF5-48D4-9515-11866D99B03E", ModelName = "コーニッシュ",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "B0769DDD-9AD7-4C84-B626-126BB270CD3C", ModelName = "アバルト595",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "253A7290-3768-45E3-82DE-12D38EA3E8AA", ModelName = "A4オールロードクワトロ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "C8D80C6C-FEA7-4887-83C2-12F037D4A0D4", ModelName = "ドマーニ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "FB35BB62-5889-45E2-BC0E-13053CB6B3C2", ModelName = "マークX",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7CC850EC-811E-4CF3-9B00-132066EA5BD6", ModelName = "iQ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "34A0F9D4-E907-410E-A7F2-1328B1D80DA9", ModelName = "ピクシススペース",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "4079B013-FC52-45CA-930B-135057F00534", ModelName = "ヌエラ",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "ADEAB04E-163A-47DE-85C4-1356AEAFF0BD", ModelName = "オートザムAZ-1",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "430576DD-D33D-416F-9061-138C16505B3E", ModelName = "A8ハイブリッド",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "5A7F77AB-6D9A-4AF9-A3D3-13974FB6D7A6", ModelName = "T350",
                    ManufacturerId = "4588CAD8-90C2-4E00-A729-F063C024722E"
                },
                new VehicleModel
                {
                    Id = "1B127F1F-C332-4F34-8D6A-1398283706A6", ModelName = "XC70",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "F47F7757-5E1B-43B0-A79B-13DA85141CAD", ModelName = "キックス",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "9132ACA0-E1C2-427D-A9B3-142ADD969BF7", ModelName = "パサートワゴン",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "F8B97F1C-345B-433A-B9E7-143F3F575F9D", ModelName = "ザフィーラ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "39AB12AC-6550-4550-8080-14958A04AD11", ModelName = "キャデラックコンコース",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "7DB272E3-478A-4E4B-B878-14A8DA5BB2EC", ModelName = "106",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "F139D956-D8E8-406C-81AE-150DF034692B", ModelName = "アプローズ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "A310C67D-D507-46BF-ABA3-15309A8F35B8", ModelName = "クライスラー・クロスファイア",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "AFF0543C-4F7C-4E27-990C-1562F8AD60AF", ModelName = "RS7スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "A1AF81EF-4F6F-4F1D-9F5E-1567DFF434B4", ModelName = "ジャスティ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "B19252D6-2670-4F23-B72D-156ADAE7C645", ModelName = "エスティマL",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "688037BD-6F15-4D7A-9DE8-1585A7C50AB1", ModelName = "グロリア",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "720BCF6F-6CDD-4D03-8CE4-159A0020E53D", ModelName = "タウンボックスワイド",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "C2607242-0495-4022-A692-15AA83DB8ADE", ModelName = "1シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "8F4391C0-A207-454D-AB43-15B67C72B685", ModelName = "X3",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "1A6CFB2C-F21F-4652-903E-15F019B3640A", ModelName = "クライスラー・インペリアル",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "40A646DC-B0AB-482F-8675-1604F30F64F8", ModelName = "C5エアクロス",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "28652106-3839-44A8-A751-16383058AADE", ModelName = "i30",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "2D621BDC-1BCC-4067-9608-166AD7CF21FF", ModelName = "ミュルザンヌ",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "94068381-5B36-40B9-A3D9-166B393B0648", ModelName = "N-WGN",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "A171584B-3841-4C8D-A932-166F2731E10C", ModelName = "WiLL Vi",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7262E319-463A-4066-9F66-16E712AA092F", ModelName = "スマートフォーフォー",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "5014A0FB-8F00-42B1-9289-171EC8CB2336", ModelName = "B5",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "A35B3ED8-2331-465C-BA41-172343E2F6C0", ModelName = "メガーヌ",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "C8E44498-A1A7-4FC7-A641-1744A6DE52AA", ModelName = "9-3シリーズ",
                    ManufacturerId = "0975EF88-66CE-47CC-A7F3-7FA7E4C0DC02"
                },
                new VehicleModel
                {
                    Id = "C0F6B9E2-FF6D-4D38-9B23-17E821E2E238", ModelName = "デリカスターワゴン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "D1B09B37-B924-4917-B486-180247A1CDD4", ModelName = "ティアラロイヤルスター",
                    ManufacturerId = "9370C145-D1FC-4F86-AC18-7934D2FD996B"
                },
                new VehicleModel
                {
                    Id = "DF57E779-5CA2-4D89-9715-181EC6EDEA00", ModelName = "X-90",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "79EADBD1-D86C-42EF-AC99-183AE9B870CA", ModelName = "ジープ・パトリオット",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "02154B18-9BB2-4FE5-B396-1857317B25E5", ModelName = "エスティマ・エミーナ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7D61557F-15F4-4948-8C1E-1861D3203FF4", ModelName = "ターセル",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B96F0B31-A675-458F-BE8A-1878DF6122FD", ModelName = "シボレーキャプティバ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "F8FE3F9B-AEFF-4FA7-A6EA-1884BBE5B744", ModelName = "Fタイプ",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "064F76E4-9CB6-4154-89E5-1937882A90B0", ModelName = "S-MX",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "A2E21A93-2CB2-47F3-B136-19B3D16297E6", ModelName = "ミラジーノ1000",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "54027D14-C5DB-4E7D-872B-1A0B92A2A75B", ModelName = "エテルナ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "6B38E889-0781-4A3D-8CB8-1A23DA72E1BC", ModelName = "N-BOXスラッシュ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "8AC74913-8678-48BE-A00E-1A32E018DC76", ModelName = "カングー",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "1A681721-C7BD-416D-BA5E-1A331A162D52", ModelName = "5",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "5057D739-CA1B-4899-8BE8-1A42802FC408", ModelName = "A1",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "3E671A17-8BAB-4B92-9B84-1A5AF2A50DDD", ModelName = "アルトラパンショコラ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "080CAC1F-17F8-4E45-9D6F-1A742D6EACA5", ModelName = "クライスラー・ボイジャー",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "E16F1561-0775-4C33-BF89-1AA7900BEB18", ModelName = "エブリイランディ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "87448C57-9F5B-464A-B51D-1AAC0FA81AE9", ModelName = "TTSクーペ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "209F81FD-5D78-49CC-8129-1AAF001E2A74", ModelName = "レヴァンテ",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "CEE98C3D-CDE7-41D1-AAB6-1ADDEF72FF4F", ModelName = "オデッセイ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "6B9CBCD3-8407-4102-83C2-1B39ACA0BD02", ModelName = "セラ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "02C18130-EFB2-4C56-8B0D-1B39F90D6F28", ModelName = "ボーラ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "2707AD5C-F971-4C00-AC9C-1B68BDEE870A", ModelName = "ツーリングリムジン",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "B2615AAC-A354-4658-B36F-1B7FD7909199", ModelName = "シボレーアストロ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "F9B0A0A2-6B7B-43CA-9D75-1B94C121393F", ModelName = "バモス",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "C9BBE99C-FA0C-4012-A07C-1BBBBEDECEAA", ModelName = "フリードスパイクハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "CCF52643-60C6-440F-9281-1C07B75BD3C3", ModelName = "Y10",
                    ManufacturerId = "DA040730-9659-498A-994E-5F7F6852208D"
                },
                new VehicleModel
                {
                    Id = "AD97BFCE-5AC7-4A61-844D-1C0E52ED0264", ModelName = "RS3",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "D5604F7F-258B-4122-87F5-1C34B4B8C711", ModelName = "スマートフォーツーK",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "4C3CB901-753E-41EE-9C7A-1C5AA9A211B8", ModelName = "シルバースピリットII",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "45490838-BD86-45F4-B542-1C61B79BF2BE", ModelName = "ジープ・レネゲード",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "BB26EE95-4C03-4A28-98E9-1C8021A7C7B2", ModelName = "ラグレイト",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "8C12F323-A6B2-4EAA-BCA2-1C87EC834872", ModelName = "アルファ75",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "870D45EC-36D5-4966-90E5-1CB079EC1F0E", ModelName = "アバルト695 ビポスト",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "6B6BADF9-5FFE-4E10-8C47-1D403E9A5B1B", ModelName = "ダットサンピックアップ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "DD6FD4FB-C2DF-435A-9D28-1D75598E0546", ModelName = "セルボ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "2BCB0CDF-155B-4130-B8B8-1DE8905D0FB4", ModelName = "ダッジ・キャリバー",
                    ManufacturerId = "3D958555-0A1D-4463-B6B4-17F71012D660"
                },
                new VehicleModel
                {
                    Id = "96E87556-06C7-4A77-B8CE-1E7A354EE575", ModelName = "ランサー",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "1C5A839C-7BB5-48C6-8BE9-1EA73A08FB85", ModelName = "ガリュー",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "38A08BB1-13E1-4052-A574-1EA8925309BD", ModelName = "サニーNXクーペ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "DB2F2CC7-8498-4682-A322-1EBF47C5F39C", ModelName = "ゴルフGTI",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "B854C0D5-24BC-40C1-99EF-1F0ADA3D2DF1", ModelName = "コルトプラス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "822FC8A6-AA53-4FA2-9198-1F3E928F2FF5", ModelName = "CLAクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "4981D06C-1D2C-4EDC-AA87-1F5DB8025C22", ModelName = "クルーガーL",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "1A151A45-1B63-4C1E-8473-1F84C5C18944", ModelName = "スプリンタートレノ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6656E845-36BC-4FBE-B628-1F9425AB5FBD", ModelName = "ラファーガ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "11ED2CC3-252E-405D-873F-1F9912E3AD75", ModelName = "ティーポ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "599524BC-59DD-48F6-99A4-1FF9942B6277", ModelName = "カローラ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "07BFC97A-E8D7-47E5-8E9F-1FFADDA5A070", ModelName = "MRワゴン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "76305FAC-CEB7-428A-93B8-2005545A3AD6", ModelName = "XF",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "8195A031-7F5B-4FFC-B5B8-2006DD33CF6C", ModelName = "キザシ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "61B5AD12-5DAD-4226-AA0F-200CE1C8C66B", ModelName = "MRワゴンWit",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "94E7C11D-2B7B-4FFE-80C4-2025FE892E12", ModelName = "レイス",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "A6AC8932-49F5-4FA4-A855-202A14D86F0B", ModelName = "ソリオバンディット",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "95363C7A-A5F2-459F-9FCF-203CAD9A292C", ModelName = "エクサ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "6ACA9396-C9B9-4629-9386-2041124DA292", ModelName = "マークIIクオリス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "E7F1AE56-1983-48FD-8CDD-20B8C636AEE0", ModelName = "GT",
                    ManufacturerId = "6B055302-3A0E-473A-81AB-AA6B85DE14A2"
                },
                new VehicleModel
                {
                    Id = "856CC5C5-B430-4473-AEB4-20E9BED2A47C", ModelName = "ランドローバーディフェンダー",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "130B1593-9492-4DB9-A456-210939DA9307", ModelName = "ステップワゴン",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "0DDD6F6E-B6FB-46EF-BE8F-213FDF22D350", ModelName = "シエンタ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "68B5627F-DA5A-4C9C-9D68-2173A0695CFA", ModelName = "プロシードマービー",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "F2B22257-9357-4C8F-8F66-219CC7FD1179", ModelName = "ハイエースレジアス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "ED1563D0-9258-43D1-AE39-21B788BED279", ModelName = "ライク",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "3A6398F3-4643-4BAA-96B8-21C394C9F0DE", ModelName = "ホーミーコーチ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "CCFD76C7-5C8E-4895-AEEC-21FECF97BDBB", ModelName = "シボレーHHR",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "DA3DC371-6D00-4D6D-8ADA-2234AE353697", ModelName = "エスティマ・ルシーダ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "9FA87B0E-A61F-4565-A710-2257FF61F486", ModelName = "ブルーバードオーズィー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "31FDD140-AF03-4443-BC77-225DA24D0E98", ModelName = "75",
                    ManufacturerId = "B226A88A-B460-4098-9C49-75A711B58867"
                },
                new VehicleModel
                {
                    Id = "79DF902E-B852-4B19-B4B9-230F551A619D", ModelName = "500X",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "91A325C4-5877-4D9C-A720-237EA21414BC", ModelName = "パッソ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "E04E7693-D434-474D-87B1-23DFE55EF536", ModelName = "CR-Vハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "33007268-80AB-45AA-AE0D-23E0B6C58027", ModelName = "YRV",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "A99AB084-9D59-4BED-BDE2-2406B5241AFE", ModelName = "マーチ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "6EDE43F1-819A-48F4-A07D-241E8FA54EA7", ModelName = "パジェロ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "6EE05D4D-26DD-4ABF-B608-246189706EB9", ModelName = "ルキノS-RV",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "87A7670B-4068-4777-B73D-2494AE1E3E57", ModelName = "エルグランド",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "9AD78939-44D0-4DEC-BE22-2508F500E636", ModelName = "クライスラー・ストラトス",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "9D9BEE4C-8FF1-4E2D-B3EA-253D1CD0FB9A", ModelName = "プリメーラ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "707195BF-B726-4E33-8AC7-2561C6145281", ModelName = "DS4",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "B4474A02-6118-4EFE-8377-25B6E8398B6B", ModelName = "キャデラックATSクーペ",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "69D0B38C-3EEB-4C99-BBD8-25C05D7F4835", ModelName = "シビック",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "0547CBE3-3477-4383-ADCB-25CA3B11495B", ModelName = "AZオフロード",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "DF8E3E06-0F77-4732-86BE-268C94061045", ModelName = "カングービボップ",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "CEE98621-0B48-4F58-B056-26F421C66F44", ModelName = "アクア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6929A534-6925-4814-A3B7-270A647E3A0A", ModelName = "ヴィヴィオ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "B66510A7-1C38-4E85-A54E-271CC78B9F1D", ModelName = "ヴィヴィオビストロ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "B0F92CC9-CB5F-4398-A0E3-271DDC4F1221", ModelName = "メガクルーザー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "CA7A0D75-1680-49B8-BF98-273314022DC2", ModelName = "プリメーラ・カミノワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "197371A1-48A6-4C63-9C11-2733B0D8E33C", ModelName = "Q2",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "94A88DAA-D04A-498E-ACBC-27464A6B0360", ModelName = "スパーキー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "BE9FA7EA-A5A3-4B7E-9A77-275438C1B713", ModelName = "M3",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "D91971A9-D70E-45D9-9FCD-2761784D0B79", ModelName = "グレイス",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "F0A9FFDB-09B3-4C63-A3AD-2777801A03F4", ModelName = "セプターセダン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7EF2D84A-AD87-4B1D-8A83-2782845479C1", ModelName = "セルボ・クラシック",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "229B0815-5922-42FA-90B3-279C3DA5D4BA", ModelName = "ティグラ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "C5203704-53BC-43F4-988A-28432592E924", ModelName = "シボレータホスポーツ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "A5EB4BC8-5922-4C21-AB53-285DCD8DE2AC", ModelName = "アコードクーペ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B00B4EA7-9242-43E3-8AE2-28867AFFC90D", ModelName = "ランドクルーザー100",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "F013BBF6-3D17-46E4-981F-289078D10DDC", ModelName = "ガヤルド",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "44939B41-5DF5-4AB6-BFB3-28A80D876902", ModelName = "プントエヴォ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "BE068096-8840-4E39-B785-28C48B117B27", ModelName = "ミラトコット",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "9ED9B090-65BA-4EE2-88D9-291CAE822D86", ModelName = "ゲレンデヴァーゲン",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "5572F3E4-0B7F-4085-8306-291CF5C4D3CB", ModelName = "アイシス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "AD470BE9-1271-46B8-8614-291FC8FB2CBE", ModelName = "ゴースト",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "F6938161-4649-4D95-88CB-2928638569CC", ModelName = "キャミ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "A171D411-95C9-4E95-85A5-294F8B0F667D", ModelName = "LS",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "3DEE3181-D318-4D6F-8715-2A17777FD3B8", ModelName = "サクシードワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B3A87AC2-2F3D-4BA9-BA6A-2A2A5B5FFA6B", ModelName = "D4",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "F997BAF8-8B32-4515-8B38-2A459EF0D59D", ModelName = "Xタイプ",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "429036A4-099C-4811-B90F-2B0426080536", ModelName = "5008",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "5A85A5DB-9283-47A0-A8B1-2B2E2E9F4E8E", ModelName = "イプサム",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "0891D9E2-14B1-4759-9898-2BE7230BD5A6", ModelName = "NX",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "6B952390-69E2-42E4-8D2D-2BF1AEB50035", ModelName = "Keiスポーツ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "6AF84818-F664-419A-84BA-2C1236CA3B9A", ModelName = "ルーミー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "EECAF1F2-C030-43A8-A472-2C1ABA432CB9", ModelName = "シボレータホ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "49C3AD92-3359-42F3-ACFC-2C28ECD146A0", ModelName = "ケイマン",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "128529F3-2429-470E-AF32-2C9109734BD0", ModelName = "カレン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "3EEE0414-AA2C-4B00-8335-2CAE6D2720B5", ModelName = "アバルト124 スパイダー",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "DC577C99-566C-44A1-B763-2CBC8EE17624", ModelName = "90",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "36752C7C-C2B5-4D02-91CB-2CC9AB68FC7D", ModelName = "4C",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "F5C895B8-875A-43C5-ABE8-2CFA3A4DDD3A", ModelName = "ファーゴワゴン",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "6057E303-DFB1-43D3-A7AD-2D4B2388ACAB", ModelName = "クライスラー・バイパー",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "9EC04CE7-860D-41AC-B54C-2D5A7BF5BADE", ModelName = "S3セダン",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "9467CCA8-9D79-4BF8-8D56-2D94B1320680", ModelName = "インプレッサスポーツ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "C7812C75-1FA1-40A1-AE0A-2DD89EFA4EAB", ModelName = "フリードスパイク",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "FF763F20-040C-4A44-AA50-2E05BA61E12C", ModelName = "ベンテイガ",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "6408B062-24C7-4EA8-97EC-2E154B4BDC7F", ModelName = "SX4 Sクロス",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "FE44FEBF-1D7A-4114-97C5-2E3BE8789007", ModelName = "グラントゥーリズモ",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "FB0127EF-2ED5-4452-95A7-2E3C6A31BB11", ModelName = "RAV4",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "F10DF2AF-A363-4B4E-B6A0-2E46EF730E0F", ModelName = "シビッククーペ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "43A0CCA3-CB7C-4DA1-B314-2E583DB1414A", ModelName = "エブリイワゴン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "C37F1E35-F042-4BEA-B944-2E9E2172FC74", ModelName = "アトレーワゴン",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "CA4ACB83-65B1-47C8-917D-2EA0479EB07B", ModelName = "Eクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "BAB45474-9089-44A9-8261-2EA5223EF6D9", ModelName = "ジムニーワイド",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "EFF3F105-B430-4904-9E73-2ECC49618B40", ModelName = "レグナム",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "6F41323F-482C-4DA0-8F1C-2F58226D7DD6", ModelName = "フリードハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "DF4DEFB9-7FBB-4348-B868-2F839DBA8257", ModelName = "ラルゴ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "7895C4D9-F68A-457E-BEF3-2F8EF0B6526D", ModelName = "i8",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "45C21509-604B-49D9-B850-2FB5661D8C27", ModelName = "シャレードデ・トマソ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "82EF7F9B-9A02-4E8B-BF13-2FCEF07D27DC", ModelName = "RS Q3 パフォーマンス",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "622BDE7B-BD4F-4E9A-B861-3014EB4F2346", ModelName = "エクスプレス",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "6F278B4C-2450-487A-B05D-303FDCD68D25", ModelName = "アイ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "631D3481-84BD-4B73-B454-304598E984B6", ModelName = "MAX",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "99A87C6A-772B-4E11-97B6-3051026A9BBF", ModelName = "テリオス",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "36A467AA-1FE8-43C6-A877-30764F54D8E7", ModelName = "B4",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "1F2EA7F5-12CC-48F8-BB5C-307E49F0D56D", ModelName = "R1",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "A1C4D922-B9EB-4EC5-A3EF-3088F0A79E9D", ModelName = "XJ-S",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "A70B25D2-3FA7-4685-886E-30C9879BC3E2", ModelName = "カリスマ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "9C710392-F9B2-407F-9266-311182B5776A", ModelName = "ゴルフカブリオレ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "78B25838-EB27-4A18-B60D-311FBB92F4DD", ModelName = "プレミオ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "0783C54F-1FB4-43F2-9ACE-3168AA3D6B54", ModelName = "プレマシー",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "6F6FAEDF-770F-406F-AC8E-31B3A58CE229", ModelName = "ファミリアS-ワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "F12916AE-14D0-48BF-BCA4-31B5EB0B6B13", ModelName = "サニーカリフォルニア",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "D83765D8-1439-4319-831E-31B94B3CACBB", ModelName = "DS3カブリオ",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "8BFF32EA-69B9-4C80-A17E-322935A0149D", ModelName = "607",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "F00FE666-6E7A-478E-9ED9-322ED493D524", ModelName = "ギャラン・シグマ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "790C1E3B-9664-4DF1-B255-3244BC5DAC78", ModelName = "HS",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "2DCD44AA-0492-4664-A23F-329411083709", ModelName = "ギャラクシー",
                    ManufacturerId = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6"
                },
                new VehicleModel
                {
                    Id = "DB2DB047-3C50-4569-BBD9-32AF7320AB89", ModelName = "ゼロワン",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "3537A6C1-C61E-4DEC-AD37-32BBAA50B3AE", ModelName = "ライフ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "91168024-9808-4286-B32A-32BFF215F625", ModelName = "グランセニック",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "95617CF2-A695-49EE-BE02-32C5FB89C371", ModelName = "ユーノスプレッソ",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "B6B84542-C786-46C8-84F2-32FE3AD35EA1", ModelName = "ハイエースワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "A3B753ED-2474-4BB4-B0CF-33343F887C7A", ModelName = "トランスポーターT1N",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "81BC4AD7-958A-450B-A2C6-3347E04E4046", ModelName = "マティス",
                    ManufacturerId = "82A2A0EE-8DD1-4F27-9356-E9A5AF96F6AE"
                },
                new VehicleModel
                {
                    Id = "08ECC4CC-128C-4EB8-85F0-336AB53628ED", ModelName = "エクスプローラー",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "B7C785A8-DFA0-4F8E-AAF9-3380786F6A97", ModelName = "コロナエクシブ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "E0167CAB-7BD2-42F7-B40A-33A4448E834F", ModelName = "キャデラックXLR",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "55D001A1-7184-450D-BBBC-3476E8130D20", ModelName = "タモーラ",
                    ManufacturerId = "4588CAD8-90C2-4E00-A729-F063C024722E"
                },
                new VehicleModel
                {
                    Id = "D95C88E1-15F3-49EA-8E47-34AE763C9C11", ModelName = "クライスラー・PTクルーザー",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "3B57D54C-115D-4CBD-950E-34B360EAEA28", ModelName = "シルバースパーウィズディビジョン",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "37367F57-868B-43BD-B3BD-34BBFF31C1EB", ModelName = "ローレル",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "65C76293-8E84-4E07-804D-34DEBE00D3B6", ModelName = "クリッパーリオ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "6FA280EF-78D4-4045-8441-34E94F4B83CF", ModelName = "キャデラックATS",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "AB14F7E3-1E53-4296-A733-3567EF77FB37", ModelName = "カローラスポーツ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "0F2B678C-0611-4333-AFEC-357AB1986816", ModelName = "F430",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "0F5563B5-1382-426C-BCFA-35F44008409F", ModelName = "ミラココア",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "B7F91713-97AF-4F2F-B023-3616CA90A134", ModelName = "MC-1",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "26756450-B866-4227-AC2D-366F5B973F89", ModelName = "ガイア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "D1BEA508-2C6B-426C-B779-3678F9E3D8D2", ModelName = "シビックハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "44934691-18B7-46B4-8AD1-36D01ADAE75D", ModelName = "センティア",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "E5CAF12D-1795-4349-ADA7-36F57B59AFDF", ModelName = "クラウンハイブリッド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "2F41A5D0-3355-496A-A8FB-372CB2F2E9EE", ModelName = "NV200バネットワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "A38E5996-68ED-4F4C-81D3-37475B4BF49D", ModelName = "S1",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "B8461DF2-EC68-49C7-86E6-378A9EB135A6", ModelName = "カリフォルニア",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "8C0D8480-5DBD-45EA-98D9-37C8E2F8644A", ModelName = "V90",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "F997DE92-A932-4E4F-9E48-382CA52E3711", ModelName = "コロナSF",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B1B602F0-A06B-4A85-B049-382F075006B5", ModelName = "ジープ・ラングラー",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "005BED7F-0966-46DA-A4B1-3849025C889A", ModelName = "アルシオーネ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "7EC4640D-C3A3-439A-B7C5-38744A29D673", ModelName = "R8スパイダー",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "A59A964A-C9CC-4ADE-8093-38A62165D9C3", ModelName = "ファミリアネオ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "EE8A3C63-87F9-491A-9516-38D0874991E0", ModelName = "トラジェ",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "197261C4-C0EC-47F0-93FA-390303F10B91", ModelName = "190シリーズ",
                    ManufacturerId = "43C2D407-171C-4061-AB7E-1F45C200E6EB"
                },
                new VehicleModel
                {
                    Id = "3EBBE90B-62D1-48AB-9F8F-391749689FA4", ModelName = "スプリンターマリノ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "1ADF2278-4479-4519-801F-391D70E8146C", ModelName = "エリシオン",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B40EEF46-F2C1-460E-BCD2-3A21FF9B10A4", ModelName = "C5",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "53B5ABBC-B8CF-4728-B64D-3A345DB9C741", ModelName = "シボレーオプトラ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "58EAFF30-B3BB-4460-8AC5-3A4E05FC3A4D", ModelName = "シルビア",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "F27AECEA-4296-4B3B-BB7E-3A6AD807ADE6", ModelName = "ミラジーノ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "EFD886A2-AA00-49BA-9730-3A757AEFBD76", ModelName = "ヴェルファイア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "718FF892-5B93-4FC4-AECF-3A94B45D10D4", ModelName = "Xタイプエステート",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "E49539B5-A267-4BC5-A643-3AF5ACBBD4E0", ModelName = "TTクーペ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "7F2A30A7-2D01-4E89-B4FE-3B2414A23681", ModelName = "D3",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "B2406B43-43E1-4738-B739-3B7714B0CE39", ModelName = "RS6アバント パフォーマンス",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "98D79794-6B45-4059-844E-3B8256688611", ModelName = "オートザムキャロル",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "F6F780C0-3A53-420D-9C5A-3BC573F8695A", ModelName = "アスカ",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "E8C13C59-FBF3-4360-9322-3BE29C32E558", ModelName = "インスパイア",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B5CF02D8-5D52-404E-A450-3C0E2A911F09", ModelName = "トーラス",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "491823A2-B44C-4CBE-A495-3C2685091E80", ModelName = "アルテオン",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "4D859961-29AE-4642-B017-3C37C6B8C68D", ModelName = "アルファードV",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "24E75112-2D46-4EEB-9E20-3C3E0512EC4B", ModelName = "パサートバリアント",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "17EB5746-60AD-473A-8E3C-3C6D0F567575", ModelName = "9000シリーズ",
                    ManufacturerId = "0975EF88-66CE-47CC-A7F3-7FA7E4C0DC02"
                },
                new VehicleModel
                {
                    Id = "18101401-0F0D-4A13-8780-3C72DD37FCA0", ModelName = "MDX",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "07C57506-CCAF-41E0-AE9D-3D2CD1EB95C2", ModelName = "トラヴィック",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "F67FA037-4838-4929-A846-3D6D73FC2BAA", ModelName = "エレメント",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "7F37BFF3-2235-4C32-A7C5-3D815B2AEF91", ModelName = "アレックス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B910E3B5-A42E-43A1-9DCE-3DF8F8DECE08", ModelName = "スマートフォーツーカブリオ",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "D0967B70-964D-459D-9492-3E07BA4B895C", ModelName = "CR-Z",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "5B12DDDD-E001-4D6C-A82E-3E1527469CAF", ModelName = "C30",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "940F99A1-99B5-4039-81A4-3EA4B630FAF6", ModelName = "オーリス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7B409DA4-71A2-46D4-A486-3EAFD7EE0849", ModelName = "アルファ164",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "7A4C7E23-C2D1-4C34-BB3D-3EF40985AAC7", ModelName = "オートザムAZ-3",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "6169D085-178D-465B-968D-3F70B2E93995", ModelName = "Mロードスター",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "01E9EDD6-4CDC-4A39-9F1F-3F9AFFBE0514", ModelName = "テラノ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "E4C37612-FA1B-447A-BE3D-4010EE59B942", ModelName = "ムルシエラゴ・ロードスター",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "084AC585-0CF7-4403-94CF-4054A7D07AD3", ModelName = "ザ・ビートル・カブリオレ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "5C8D385F-A33C-40A9-A67B-4073C272303D", ModelName = "ピクシスメガ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "1111220F-E97A-4C96-BB7C-407FB2E9A003", ModelName = "Eクラスステーションワゴン",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "F50C543E-D564-4FFF-96AE-408CCDD9FD06", ModelName = "A3",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "CEDA16D4-F86F-48B0-BAD3-40FAB392C7BE", ModelName = "キャデラックドゥビル",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "FC953B60-D59D-4981-8D61-410F28E98F98", ModelName = "ミト",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "4A5F597A-2B71-4000-9EE1-4125071C8568", ModelName = "ステラ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "241CF03B-D5CC-4540-80D0-416899F64941", ModelName = "M5",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "008856EC-0AB4-4E85-B580-4192A6B9B29C", ModelName = "C4 ピカソ",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "448FAEB0-DDE7-48C9-BED7-419D7F743886", ModelName = "イクシオン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "AEC93F4B-7797-4600-9E4F-41C0C93E3FA1", ModelName = "FF",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "3F8E3D78-ECB1-49AC-BB8D-41C228AD3BCC", ModelName = "C6",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "65DE7F06-A796-499D-AD8A-41CF3CFDBAAB", ModelName = "パジェロイオ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "9FBFC377-DBFA-4DFE-A076-421DE7BAE6A7", ModelName = "S5カブリオレ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "4EA9B0CE-32A6-45AA-BB07-423AD0ADFB15", ModelName = "シボレーアバランチ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "1B159C44-95BC-4EAD-9FFD-423F2A9AB16E", ModelName = "ダッジ・アベンジャー",
                    ManufacturerId = "3D958555-0A1D-4463-B6B4-17F71012D660"
                },
                new VehicleModel
                {
                    Id = "1F39B11C-5728-4FDF-AE47-425434BB08F2", ModelName = "カローラレビン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "9E7D6196-0AEB-48DC-88E1-42D38B26E889", ModelName = "エリシオンプレステージ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "EF0BEE7D-EA17-40F1-A7F7-431548280C62", ModelName = "S4アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "FFD11E0E-D6EE-4AD4-899D-432377AFCB44", ModelName = "SAI",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "9363B73B-F2C3-487C-9B26-43496CAD65C8", ModelName = "レヴォーグ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "3DD0289B-830E-42C6-82C4-43675B3DFB0D", ModelName = "オッティ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "4FAA8ED6-5240-43E1-A22B-436C1C66C59C", ModelName = "ソブリン",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "887D090F-61A4-4F37-9862-439755FE643F", ModelName = "ミゼットII",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "E8737FBC-58FB-427A-BE6B-43ED7A451074", ModelName = "ピアッツァ",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "A1CD0A96-FCB0-46EF-9A93-440CCE8E04E9", ModelName = "ティーダラティオ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "0D4A1D49-8AE8-48D0-9390-44667167310B", ModelName = "MX-6",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "49DF4945-87DC-4984-817F-4480151C0616", ModelName = "ストーリア",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "8D5BACC0-6CB3-4618-A513-4487A3D698A8", ModelName = "ユーノスコスモ",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "EF671436-EBAA-45AC-BCC1-44D43A661DD9", ModelName = "フレアワゴンタフスタイル",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "B281731D-5E7C-4B8A-B0AC-44D7E8194717", ModelName = "アルファ159",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "743E8EF5-EB05-4EA2-9AA3-44EAFEC64E5C", ModelName = "ガリュー204",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "5EE7DBCB-8A70-4B67-AADA-45045B835E7B", ModelName = "X5 M",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "42D68AAE-67CC-467C-A457-4504F5C8B14F", ModelName = "フィットハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B6AE7150-F838-43AF-9913-4512F81830A8", ModelName = "N-BOX+カスタム",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "92476F32-9725-4B80-B84B-451FA3C956AA", ModelName = "ジムニーL",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "A4DA715C-CD77-4DD6-B187-452946A7F843", ModelName = "ランサーワゴン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "2B0B1974-7B61-412A-8D0E-45457DD49D47", ModelName = "AD MAXワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "3C743DF2-F6FE-4597-8D28-461BAB27E9EF", ModelName = "ニューパンダ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "A0014790-BCA8-43BF-90C8-4665732A5795", ModelName = "フェアレディZ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "7B1D9E77-6FF0-42DC-89D2-46A7DA507C8C", ModelName = "Z3ロードスター",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "10AFEE92-2F78-4D8F-BD2B-46BFBCE2CBB4", ModelName = "タンク",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "70D6A3F1-D5DB-4308-B5C3-46C6483AC5BC", ModelName = "オプティ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "9B2BEBF4-448A-40FB-978F-4764356AB995", ModelName = "ビュート",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "6FFBA57B-CE55-4527-8A13-47817470D47A", ModelName = "マークXジオ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "40517E14-D57F-4C7A-98DD-47C5316EFBD8", ModelName = "ブーンルミナス",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "8C4F231C-C682-4E3D-B8B0-47F840E4883C", ModelName = "キャデラックCTSスポーツワゴン",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "D6535628-9652-45ED-9B8A-484244FE7432", ModelName = "グランスポーツ",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "A5D9C06C-C088-42B8-82C8-485E2EA4FFEB", ModelName = "3200GT",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "5FC32D95-16C8-4248-8A64-485ED1E00BE0", ModelName = "シビックフェリオ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "F2960E1E-D5D8-4E0D-8F8E-4869CD4CCAEE", ModelName = "MAZDA3ファストバック",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "9D60A83E-8008-40D5-B5EE-487FE15CA927", ModelName = "パジェロミニ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "76D681E6-98F7-422E-8137-48CF7BE3421C", ModelName = "プリメーラワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "7EB3FFFF-2FB1-4691-A935-491474CDF025", ModelName = "ゼストスパーク",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "D5D1D50C-8396-4BA5-9EE6-493D5647D118", ModelName = "アルトC2",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "8C71D708-6455-410A-9C61-49652A49C427", ModelName = "クライスラー・300C",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "C8FF57BE-674B-40C4-8956-4A2D26951C9E", ModelName = "デミオ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "84013F36-05F6-4CD3-B102-4AA61ED7C5E3", ModelName = "ヴェント",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "3F72D484-AD12-455A-980C-4AE7AFED4E0F", ModelName = "ディスカバリー3",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "9F6E4A4F-5720-46E0-B5F0-4B2C345B3843", ModelName = "トゥアラー",
                    ManufacturerId = "B226A88A-B460-4098-9C49-75A711B58867"
                },
                new VehicleModel
                {
                    Id = "699103DA-5FDA-4B3A-9E4E-4B43ED84FED3", ModelName = "キャパ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "515CC84A-79C8-4D48-9B12-4B53BA0F0EF8", ModelName = "シャラン",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "55D5EB20-3759-4998-8367-4B887A92EB86", ModelName = "ムーヴキャンバス",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "B817BDAD-BAAB-4A6C-91D4-4BA7196ABAEA", ModelName = "ゴルフカブリオ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "ADD0BA16-7FD9-490C-8830-4BCDDBEAC9F4", ModelName = "トゥデイアソシエ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "2704E8FE-3514-4C1E-BDB1-4C230B7EC195", ModelName = "アルファード",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "D8887736-72DC-4512-A6FC-4C2B7BE276BE", ModelName = "アトレー7",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "00AF8FEA-1B04-429B-A381-4C5EE4274C7A", ModelName = "N-WGNカスタム",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "DC271AA5-6801-43FB-8332-4C7983440396", ModelName = "エリオ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "126121CD-7953-44C6-A23E-4C9358C184D8", ModelName = "500",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "9FAB3B4A-FC78-4A0E-9D2C-4C9E3727D31D", ModelName = "A4",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "8D36BD2F-347E-4D7B-9C38-4CEACBF243DC", ModelName = "ジープ・チェロキー",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "8E176E8B-82D5-42D1-B0AB-4D0C6B37FA2E", ModelName = "プリメーラカミノ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "EB0A47AC-87FE-4C0D-9AD9-4D403FA48707", ModelName = "マークII",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "E52647B1-29B1-48E3-9C72-4D4F7D740F2C", ModelName = "エメロード",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "4F3B282F-C8FD-4D90-94A6-4D59590690B6", ModelName = "ロゴ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "9C84E362-6E6D-4609-AD2B-4D95E76DD4A6", ModelName = "エクスペディション",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "0F8BEB0A-9512-4B43-8219-4DCC43274369", ModelName = "チャレンジャー",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "150036D0-AA26-4B4D-A6B6-4E4A5F708A77", ModelName = "フォーカス",
                    ManufacturerId = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6"
                },
                new VehicleModel
                {
                    Id = "2D2E0160-3F9B-446F-89FD-4E5D75F0C92C", ModelName = "7シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "CD530960-264D-48E1-B927-4E7B7886C864", ModelName = "レオーネ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "EEA5F5F1-D50E-45F0-BB26-4EDB0550304B", ModelName = "リーザ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "9D4C0E72-21F8-4A52-BE4E-4F279CDCB65E", ModelName = "ストリーム",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "BCE34E4B-3B30-4CCF-AB53-4F36BC415274", ModelName = "ツイン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "149A3F9D-369D-48A4-A5C0-4FB60757D311", ModelName = "GLKクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "E80EACF9-218E-4D3B-9799-50022F14C62A", ModelName = "309",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "8AEE04F1-6F97-4FC6-B628-501325B50C1D", ModelName = "80",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "1FCD25E6-F0E4-4D49-B804-5022D1AD73BD", ModelName = "Gクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "AD3CD6EC-4A92-44C2-8F21-50330D9BDC1A", ModelName = "アルト",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "D7B260CF-C737-411A-B844-5043EB8B2DD4", ModelName = "575",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "6E4F31FF-C907-4C8E-9587-506873F4C5D4", ModelName = "XVハイブリッド",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "9972F17F-B7D4-4740-9B25-50937E486F3D", ModelName = "マスターエースサーフ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "33D3A65C-49BD-462E-B763-5096007315CD", ModelName = "ムルティプラ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "A67FD0D5-1D0D-4439-9000-5195D0F4490E", ModelName = "スペーシアカスタムZ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "43EC5864-5DF6-4885-A121-51C367B8F368", ModelName = "スペイド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "EF22B0E8-E5E0-4A7B-8D67-51D7BBD2D46C", ModelName = "デルタワゴン",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "3941D0C9-D10F-49B4-9813-520CF28F9342", ModelName = "スターレット",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "51EDC4E9-CBBF-498A-821A-520FAA6C753F", ModelName = "アルピーヌ A110",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "83F46728-D697-4034-B210-5225DA8627CD", ModelName = "599",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "97EF241C-2112-493F-9921-5256EE130124", ModelName = "プロナード",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "48FF89D0-4D46-46A4-8779-52758793A7FF", ModelName = "S60",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "AC272C98-0778-4A7E-9B1F-5288A809A1DC", ModelName = "スカイライン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "7785378D-1746-4793-8D65-52A212D7E1C6", ModelName = "308",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "1EBE66A0-D770-49DB-AF62-52BFA90B3518", ModelName = "スプラッシュ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "D2D3F66E-A7EC-4F5D-BB81-52CE50FE5690", ModelName = "シボレーMW",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "ED10E5DB-9F2F-4554-88A2-52F6DA538CCD", ModelName = "ディフェンダー",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "EF8924A1-E683-4C0D-94A1-532AC4DC704F", ModelName = "エクリプスクロス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "D7A4780F-8323-4014-A321-533A72F610F0", ModelName = "アルトC",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "AA36AD03-4FFB-4F32-B2C6-537ED974D651", ModelName = "S2000",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "6FA1F4F1-0111-4DEA-9013-53F60C6C17CE", ModelName = "テムプラ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "341964AC-54F6-4965-9B41-5412A7CF529A", ModelName = "クー",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "5BD33654-4103-491A-915D-5436AF55E309", ModelName = "シルバースパー",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "2E28C5A6-3455-41ED-A6C0-54A32F4F83CC", ModelName = "ビスタ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "01733B18-7A3E-4D72-AA49-54AD6FA9B21B", ModelName = "クーガ",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "6930AD06-4398-4695-9E70-55293B24BB0F", ModelName = "500C",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "AC298673-F46B-4EE4-86F2-555C7CAF2591", ModelName = "プラス8",
                    ManufacturerId = "450FD683-7A50-4E7A-8B71-7DD109689740"
                },
                new VehicleModel
                {
                    Id = "5B9F4784-683C-4766-94C8-556ABD745092", ModelName = "フィットシャトル",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "8633E605-8CE3-487E-9560-55CB94F20B7A", ModelName = "アルファ155",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "0D0CCB24-4DA9-4E79-B9E1-562A7421FD59", ModelName = "トリビュート",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "68F4D707-4AB9-4F45-A8BE-56341FA486D4", ModelName = "デイムラー",
                    ManufacturerId = "D43FCB87-8EB3-4BDC-999F-289DDC3E494E"
                },
                new VehicleModel
                {
                    Id = "CA945D76-B782-4879-BDCC-5642468599C5", ModelName = "レパード",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "F7D907FE-D220-41F8-8CC2-56BA7545B14D", ModelName = "エブリイ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "ABE0C8CC-5FB2-4F01-8B13-570B347189BB", ModelName = "サーブラウ",
                    ManufacturerId = "4588CAD8-90C2-4E00-A729-F063C024722E"
                },
                new VehicleModel
                {
                    Id = "8A2DF912-4444-4A37-84F4-572D7DF1015D", ModelName = "SLC",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "A99A66A7-A521-4A00-AE79-5743A528CA21", ModelName = "オルティアV",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "409A130B-E8AC-4995-90CC-579A13DFDF39", ModelName = "ミニカ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "6A808194-83F3-4B98-B449-57AAC03AB98C", ModelName = "クロスゴルフ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "1B15C78F-F80C-440C-9A6E-57C999DE1EB3", ModelName = "レジアス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "65B24781-B4E8-42D6-8451-5844438EEED5", ModelName = "TB",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "7132C9CD-B614-4621-B7E4-58565DCAFAD8", ModelName = "ハリアーハイブリッド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "14533389-554E-4D16-8F1D-58616B3B3914", ModelName = "トルネオ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "80893CAC-0137-4D98-92C1-586CE2AC0AC7", ModelName = "Bクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "B40E7FFD-19F1-405A-99BF-5876F89697C4", ModelName = "スープラ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "2DF19A9A-8420-4660-A970-58B329C988F4", ModelName = "レガシィランカスター",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "DF4B90F7-79C5-44D6-8AEB-5977AE8A80E6", ModelName = "ルクラ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "71D29891-211E-460D-8232-59CCC8928529", ModelName = "ディンゴ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "E822AE9E-8FE2-49C0-BC95-59F3EB8D1ABE", ModelName = "ディアスワゴン",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "9CD37B67-A8B6-44DA-8E77-5A370CF8C9F3", ModelName = "スカイラインクロスオーバー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "296C4C0A-4455-4346-91EE-5A57EFE475F2", ModelName = "RX-8",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "60EFA22B-660B-4497-8D1B-5AA9BE09EE5B", ModelName = "イオス",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "F55ED5F0-4307-404A-83B6-5AAF8762D3E1", ModelName = "ステップワゴンスパーダ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "2903A01E-A5B0-455C-A64E-5AD8D2608B6B", ModelName = "レイ",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "D0CAE0EA-A54B-40A5-A12D-5ADC31B8C355", ModelName = "エクシーガ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "61EE2228-F336-4901-917D-5B384FE902F6", ModelName = "アウトランダーPHEV",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "A25BBBE3-C429-455E-9B42-5B839660E8C0", ModelName = "カムリ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "25CA8C06-07D4-4B5D-8E98-5B9BE881287F", ModelName = "カリーナ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "A320A2D6-BA6E-4965-9EFC-5C09F31AC337", ModelName = "キャデラックCTS-V",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "67A1DED1-D3A5-4D5B-A6FE-5C1BF7ABCDEB", ModelName = "F12ベルリネッタ",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "D101FEB0-A3AF-4F1D-8AD3-5C8EF971B6CF", ModelName = "スプリンターカリブ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "43BA788A-F4FA-4CA3-9EE5-5C992AE3A0E5", ModelName = "インプレッサスポーツワゴン",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "69604BCC-384B-4632-81F0-5CB51B676858", ModelName = "カムリグラシアセダン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "AB6FFBD5-EBA7-4519-8EC1-5D27C43874AE", ModelName = "ZX",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "17A5BD9D-F6B9-4BA1-9F0A-5D385ABB595D", ModelName = "オリジン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B4F2AEE2-C2AF-4A4E-A4E8-5D531580AE03", ModelName = "B10",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "FFF64F59-BD71-45EA-A5FB-5D7A94DEDFE0", ModelName = "スタリオン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "7E1F3233-DB5F-40D5-9C20-5D864F382591", ModelName = "インプレッサG4",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "31806EDC-BCD6-4C4E-9819-5DC90C83513E", ModelName = "960",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "23392921-6FEE-43A3-96BF-5E3833C61EF5", ModelName = "グレンジャー",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "11EE3AC6-169F-475C-8904-5E38D447613F", ModelName = "シルバードーン",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "2BF146C6-F760-4C90-B24C-5E6909991966", ModelName = "ミニカトッポ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "FE7D4D99-E665-432D-B5DA-5E6F6FD64533", ModelName = "リューギワゴン",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "0B7C731C-B81D-41C3-A60B-5E9E33A81A83", ModelName = "ヴァンガード",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "F1EC32E2-D4C5-4719-95E3-5ECC80B31F1E", ModelName = "FTO",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "3EF34DAF-194A-46FF-B01B-5EEA67ECD5CC", ModelName = "テルスターII",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "D5BE64EF-78EC-41DC-AFAF-5EEE0CB24E56", ModelName = "ジュリエッタ",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "44225A5C-626B-4E21-991B-5EFA1156B309", ModelName = "シボレークルーズ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "8E2AA43A-0CEE-40DE-871F-5EFAB91A16A4", ModelName = "プラス4",
                    ManufacturerId = "450FD683-7A50-4E7A-8B71-7DD109689740"
                },
                new VehicleModel
                {
                    Id = "50FD4E09-D0E2-43DF-B875-5F2C164D6798", ModelName = "シャトル",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "100382B7-16FE-4AC4-8307-5F73D2739782", ModelName = "RS3スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "E2AF7DAC-2FE7-448F-8DB1-5F8B920D73AE", ModelName = "クライスラー・ネオン",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "7D38C50F-125D-41F4-9263-603FDF8CFBBD", ModelName = "クライスラー・300",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "E293215C-31B8-4F72-9BB6-6075AA82A7DB", ModelName = "ユーノスカーゴワゴン",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "A2414098-CF64-456C-9C0F-607C17DCBC9E", ModelName = "シティ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "D68AA196-8936-4659-B245-6095A9D2E3BB", ModelName = "V12ヴァンキッシュ",
                    ManufacturerId = "C35A4E7B-0E1A-4002-B648-47F537CA7BF1"
                },
                new VehicleModel
                {
                    Id = "3F36994C-7357-422C-9B08-609CCA733B80", ModelName = "スペクトロン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "12430A1E-2EB5-4E92-948E-610042D48A6F", ModelName = "ロードスター",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "C2353050-0FB0-4FFC-89D7-612ECE352569", ModelName = "SL",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "0C2C1F40-17D3-4338-807E-6153F2163634", ModelName = "ミューウィザード",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "21AC55C6-193F-45D4-ACF7-6181E2342D77", ModelName = "718ケイマン",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "C98D68F6-98F6-43F7-B69A-6188507AA834", ModelName = "セレナ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "93B48C06-B24F-4D30-883C-61A9EAB26648", ModelName = "XC90",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "036ABAEB-A082-41C4-895D-61F84874D908", ModelName = "クライスラー・300M",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "A57AA0AD-C903-41BC-8DEA-6213D231F80A", ModelName = "フーガハイブリッド",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "ECB2B031-C453-4EB2-9D53-6229089830AF", ModelName = "スプリンターシエロ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "5078312B-AC8E-4C07-AF20-623488140AD0", ModelName = "ルキノ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "009A1010-1371-42BF-8EDB-6246CC12C6CB", ModelName = "ビスタアルデオ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B81820CD-8CB1-4921-A20E-62882FE0C8CB", ModelName = "アルファ156",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "5BFBA835-D315-4781-B13B-62EB921E32DD", ModelName = "リョーガ",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "172FE97E-F5FF-45DE-82EC-62EE05FE1A6E", ModelName = "M2",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "3EB71385-5CB9-4E32-8976-62FEC840E390", ModelName = "フライングスパー",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "E6C7C412-5529-4CD8-8B2C-630269F3DA17", ModelName = "S7スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "5765E3DD-444B-4997-ACBB-6304969E991E", ModelName = "X6",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "8D38D16C-A580-4D30-9FED-63103A9424FD", ModelName = "テルスターワゴン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "B95EE7A9-64DB-40FF-9080-6377D15BD44C", ModelName = "フォーカスC-MAX",
                    ManufacturerId = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6"
                },
                new VehicleModel
                {
                    Id = "C915D159-0D2F-4B39-89D9-63884D7242D3", ModelName = "C4 カクタス",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "F579FBEB-3694-45A4-B9B9-63941DCF4F03", ModelName = "チェイサー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "1CA8A580-2422-4E12-BA37-63AF4F47BEA1", ModelName = "インプレッサスポーツハイブリッド",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "28B9317E-2353-4268-8833-63B517CDB792", ModelName = "SX4セダン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "A4C6C25D-C516-4C80-BFD1-63F7AEE4FAA4", ModelName = "ファントム・クーペ",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "DDA65694-639C-42E4-9302-6402970B2E5F", ModelName = "プローブ",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "E4571614-B1B2-4E89-8C2D-645781B8FF8B", ModelName = "サイノス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "E4A13168-22B3-4957-8CEE-646A88AC3715", ModelName = "マツダスピードアテンザ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "23B90D7D-B540-4B13-8DC6-64B619FBDBC1", ModelName = "キャデラックSTS",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "F46BC4CA-FBB8-4CAF-B067-6507A74D3100", ModelName = "インサイトエクスクルーシブ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "987101D6-B2AB-4DB6-9576-651B7FEEB3D4", ModelName = "スイフトスポーツ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "D0990AB6-3DB6-4E90-8983-655FDF8D026A", ModelName = "ウラカン",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "B314C3EE-DF68-4D7B-9DA0-656CD148F553", ModelName = "アクセラハイブリッド",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "CCCFFE04-A63F-4DBE-A397-6579F025FDD0", ModelName = "アベンシスワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "31EB6F2C-ACD2-44C8-812B-658B55A247D8", ModelName = "レガシィB4",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "3AAFDAB3-EDA1-4B1F-98D8-65C3A135EFED", ModelName = "ピクシスエポック",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "F1B12875-A332-4ECF-A6BF-65C9383860FC", ModelName = "ゴルフR",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "92AD6774-1D21-406B-9019-662D85AA7F5E", ModelName = "オメガ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "F61C4F1A-4891-4476-95D3-662DA74819F7", ModelName = "N-BOX",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "DDC80DC6-DD3D-41A7-958A-66B655BFB869", ModelName = "4Cスパイダー",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "940C22CE-4CA1-48C0-90C0-679C59D4C534", ModelName = "8シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "8E615E1D-2A49-43EA-802C-67BA36D50CD2", ModelName = "UX",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "33ED9371-9214-4D9F-B7E8-6801113E13E8", ModelName = "ワゴンRスティングレー",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "E886E00D-5F9D-4537-9D19-680655515EEC", ModelName = "ハイラックスサーフ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "0B6B5AA7-C642-41CB-BC3D-680B01686306", ModelName = "ボンゴブローニイワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "3FBC8AF1-67EC-4A27-BD8C-6836A95341D2", ModelName = "プログレ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "2414DC9D-94E3-4704-A3CE-6852EBDFC9D4", ModelName = "Cクラススポーツクーペ",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "641E5AF1-BEFC-4FBB-AA2B-685DD8493447", ModelName = "アルファ166",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "EE882984-89C6-4319-82D2-68A02BABF707", ModelName = "ドーン",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "D0611AFA-4089-4CD1-811D-68CCEEF13B18", ModelName = "S3",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "132A3F07-104D-45AD-90D0-68CE3089EB99", ModelName = "A6オールロードクワトロ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "CB668DCE-2681-49B5-933D-68D2B3BE966E", ModelName = "スペーシア",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "F888F6EE-1C3F-4FA3-949D-68F9465A5B63", ModelName = "ランドクルーザープラド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B06D0357-4866-48EF-9A1F-691AF839253F", ModelName = "C3",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "598F8424-4DBE-4FE0-A885-69D1A0905EB5", ModelName = "eKクラッシィ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "BB5735CC-AF32-495E-BAEB-6A065CDA96C4", ModelName = "コーニッシュIV",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "E97F73E8-7E88-43F9-9645-6A0AC3279981", ModelName = "アルテッツァジータ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "2D65D3DA-6B4E-4A7E-8D84-6A41F56FBE6F", ModelName = "ジェミニ",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "0C0200DB-E4FC-408F-9708-6A454BDECE4B", ModelName = "780",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "7E4891E9-30AF-4383-9A0D-6A64D1DB3479", ModelName = "カリブラ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "9BF4D7E0-5C5A-4F4C-868D-6A78E859DAB4", ModelName = "シフォン",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "02D3CCBC-2D0A-49FD-88F0-6AF92E98A530", ModelName = "ムラーノ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "67B9FA93-035D-4F03-B1F0-6B1E79D58C9F", ModelName = "クライスラー・300Cツーリング",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "1AD09E0B-CE6A-4E73-8BD2-6B9E3A129A66", ModelName = "NV100クリッパーリオ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "3CEC829F-C43B-4CCC-A6DD-6C09C11349E2", ModelName = "カムリグラシアステーションワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "35AF9614-C557-4D9B-8DDD-6C13168C90F8", ModelName = "パナメーラ",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "E704AF7E-304F-4DD3-AA55-6C433C18566F", ModelName = "リューギ",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "0A85D825-120B-4B55-9C8B-6C6D5CA1A2E0", ModelName = "IS",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "454DE86E-4E40-4353-B1E7-6C71CDF08EA8", ModelName = "プレリュード",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "8A2CCB5B-E5E3-4373-8242-6C84FC74EC56", ModelName = "ルーチェ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "8655A949-7C8B-4F66-A73F-6D2050CADBC3", ModelName = "760",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "AB4264AC-8297-4EFD-8D80-6D33755E6765", ModelName = "940",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "4F48D589-2CA7-41EC-974B-6D372E247A3F", ModelName = "カムリグラシア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "EB24F1E7-7C5C-42D6-81F2-6D7678D977DA", ModelName = "アルファ147",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "45CFFB69-2956-46D1-BF9C-6DCA0F0B8962", ModelName = "960エステート",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "0ABF84A1-F0E3-4E19-A73E-6DE8CD1215DA", ModelName = "ミレーニア",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "D49D587D-B7AA-46FB-98AC-6DFE1F2AFC2A", ModelName = "ソニカ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "35B2EFCD-B378-49C9-82F8-6E0AB7FB438E", ModelName = "FJクルーザー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "164F412D-0183-43D5-9D5B-6ED4F5836740", ModelName = "ポロ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "5848DFB3-28BC-47A4-80EF-6F1C256923E7", ModelName = "クサラピカソ",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "D16B6857-6C6B-4E85-AE04-6F1C8E742070", ModelName = "アルファスパイダー",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "604EE30E-D0C5-489E-8F36-6F20278E4238", ModelName = "レンジROVER2000(平成12)年7月~[販売中]",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "A8DAC3ED-46F4-41EB-B4CC-6F4674C983D7", ModelName = "セプターステーションワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "D0B7D283-9F64-4750-B5C9-6F4DB76FF659", ModelName = "プラッツ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "85257415-3493-4E50-98BE-6F575B5D61DE", ModelName = "レックス",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "BC223C33-485B-4DAB-B424-6F7F3F7EA93B", ModelName = "プレオ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "03A5D1F0-DEE4-468B-836C-6FA68BF6852C", ModelName = "アルファブレラ",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "E8BB86D2-1EC7-4119-B069-702EA220A299", ModelName = "ロードスターRF",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "CC09AC3B-8073-44B0-B86C-70326AAC7E5D", ModelName = "ハマーH2",
                    ManufacturerId = "85716B45-8139-491C-B0A4-5E31D4419A3D"
                },
                new VehicleModel
                {
                    Id = "7F224329-DE6C-4B2E-ABE4-705FB84D83E7", ModelName = "Z4",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "2A4E0160-01B3-45C2-9D5E-7077BAA92253", ModelName = "パサートGTEヴァリアント",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "72287ACF-7A2A-4EFB-B9A6-707D19C6D670", ModelName = "オデッセイハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "46BAA5EF-5B58-4A46-BB31-708EC7A86C7F", ModelName = "セドリック・シーマ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "B3B3EED6-598D-41D3-A071-70A61768D154", ModelName = "プロシード",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "A161F8B7-713D-464D-82E5-70B48976E628", ModelName = "ハイラックスピックアップ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "89D46E0A-652D-4582-B230-70CDA489CB9E", ModelName = "ジープ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "000E3197-FBFB-45E6-94A8-70FBD8028328", ModelName = "e-ZONEセダン",
                    ManufacturerId = "5B86E249-FAEA-48D0-8378-34B357C73E10"
                },
                new VehicleModel
                {
                    Id = "2183C9D3-F0B4-47D6-AE5B-71375AFFA2E4", ModelName = "V8",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "CEE8B50E-69FB-4E1D-84C1-71494FC51B89", ModelName = "S660",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "F7494A4E-299E-4032-ACE5-71999AB64C4E", ModelName = "アテンザスポーツワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "AF08894C-DF78-471C-B6FA-71C9AC2A2531", ModelName = "ゴルフワゴン",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "484D3978-BBA8-4FD0-8DB8-71D192B618A4", ModelName = "S90",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "98A7D7E7-B99D-4E22-ABA1-720903F0F0C3", ModelName = "エラントラ",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "E5541506-D897-42DF-A1AB-7233005713D8", ModelName = "スプリンターワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "FA5AFB65-4898-445F-8D8F-724663699FFA", ModelName = "アベニール",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "2E3351CF-D7D4-49E0-A0D9-72A88CEA016D", ModelName = "サンバーディアス",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "C1977120-2CAF-489C-BCDD-72F5D602A889", ModelName = "デボネア",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "5511832C-87B1-476A-B5A3-731C5C52CA41", ModelName = "プラウディア",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "3D8DCC43-E153-41B8-AD54-73339E5A84EF", ModelName = "マキシマ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "6F158F02-C823-459C-AFB5-7374A4ED51AB", ModelName = "フリーランダー",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "770F3470-8C27-44CB-8E13-737A3465047D", ModelName = "BRZ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "B9EC20C7-BB80-4C7F-A7C1-73A40641C0B2", ModelName = "アベニールサリュー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "5C14AD59-98AC-42DE-BD55-747B72CE84B8", ModelName = "RS6",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "6E0E68CF-9C62-45B9-BE50-748DBA031794", ModelName = "クラウン・ステーションワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "D29CEF4A-3274-4BF7-9CD3-74D634AC75EA", ModelName = "ウイングロード",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "635E0A79-FCA2-4C16-94ED-74EB9E8A09CC", ModelName = "ハイラックス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "02D81E96-6EDB-4B7A-A425-74EE18DA2EB5", ModelName = "488スパイダー",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "882FAAC9-622A-4B69-B5A1-75168A3B57B5", ModelName = "R8",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "B97FA772-4785-4A82-A2CC-7523A6D8845A", ModelName = "シボレートラバース",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "F2414B9E-604E-4F9E-9294-75449143C277", ModelName = "Kei",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "4B2CDCE2-1AEE-4B15-8882-759565234C62", ModelName = "GS",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "E585D33B-36CB-4AD0-A98F-75BF9405E48A", ModelName = "ホライゾン",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "337F20AC-6F46-42E3-9796-760AF422D63A", ModelName = "キャラバンコーチ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "D1F0BACF-E4BF-4E6F-BD4A-7654F5BE2153", ModelName = "キャデラックCT6",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "7FB9CA22-F6BD-4D23-9C1A-766F7495FE30", ModelName = "グランデプント",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "AE3798BF-D3DC-479A-B14E-7687EE2469FF", ModelName = "200",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "23267950-5EA3-440B-81A5-768B7042B9D9", ModelName = "パルサーセリエS-RV",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "BC3B78BF-CCA2-4CAF-9B47-76E4A6913511", ModelName = "XV",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "A87E071F-3825-47E9-A285-772323E97D6C", ModelName = "アルファ159スポーツワゴン",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "FE0A316D-F63A-403B-B651-77A3B6836EEC", ModelName = "エクスプローラースポーツトラック",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "FA5AB6EB-2C68-426F-A1EE-77D01F3F118A", ModelName = "ゴルフGTE",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "04AEC368-5B03-416B-8F2C-77D1D2E9CD06", ModelName = "ラフェスタ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "A906EB58-DD35-4073-8D36-77D224457264", ModelName = "ニュームルティプラ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "72097F25-027A-4B0F-9100-77E710E2595D", ModelName = "クロスロード",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "43986DB6-417C-41A0-B9A1-77FDC0A5EBF3", ModelName = "406",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "314701BE-1864-4241-8599-7880E447EA20", ModelName = "CR-V",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "4D868866-70A5-458D-8AE2-78A684B44CBB", ModelName = "RS4アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "2C3A094B-B69A-45CB-B2F0-78DEFD63F6CA", ModelName = "Q3",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "6FF670C8-00C1-44A2-ABF8-790F42F09A00", ModelName = "ブルーバードシルフィ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "4ACEDF2A-3303-47DD-BE7D-79244BC70ADD", ModelName = "レーザークーペ",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "50ABFF86-B9FF-47C2-B75B-7987E8615F80", ModelName = "ラピュタ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "105D70C0-EFDF-45C9-9E47-79BBEE63CDD9", ModelName = "デュアリス",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "BCA3C2CA-400E-4FFA-A8B0-79E722B0E8A5", ModelName = "プロシードレバンテ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "DEF98AD5-B4D2-4ABA-8542-7A282E98B56D", ModelName = "ファミリア",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "0E1424D3-AFE6-496B-9F7E-7A35DC4CA60C", ModelName = "アテンザセダン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "C570394A-D59F-43BC-A269-7A627AD500D9", ModelName = "アコードプラグインハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "8151CD7D-92A5-4EB8-895C-7A710F712FF1", ModelName = "WRX STI",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "400BE0F5-9C2F-4A77-BA60-7A9A544967E7", ModelName = "CR-X",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "889F4316-7EBA-4608-AAD1-7AA8EB0C5CCB", ModelName = "イエス!",
                    ManufacturerId = "20697E01-ED05-41CC-A815-4D2E3A4CE99C"
                },
                new VehicleModel
                {
                    Id = "337A73BC-0975-4FC1-8591-7B58A95F7431", ModelName = "ボクスター",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "ECC1357D-4123-4A2D-93C6-7B6EE17790EE", ModelName = "カルタスエスティーム",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "305BC4D5-A73B-4B82-91BE-7B8DF19257C9", ModelName = "Sタイプ",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "BD0C03C6-343A-469B-94A7-7B9F01465C75", ModelName = "バレーノ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "CB2C6A42-B98C-4648-843F-7BBB65E0445F", ModelName = "ゴルフプラス",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "4ABD783A-39FF-47A1-B2A3-7BEE330D48B0", ModelName = "S80",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "C381E533-79C5-4413-8640-7C5B587031AD", ModelName = "クルーガーV",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "094B45CF-5C18-4DF4-A497-7CE5DDBFF646", ModelName = "カローラII",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "C4F775CD-4FC3-4CC1-AD52-7CEF342FD461", ModelName = "XFスポーツブレイク",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "687B975D-B9FE-45EF-94CA-7D3DF732430C", ModelName = "グランドC4 ピカソ",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "499EA744-E2B2-4BA6-BA62-7D4241790C58", ModelName = "カルディナ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7EECADEB-BDCB-4C27-A3DF-7D8F9189EFAD", ModelName = "eKアクティブ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "0F6D995B-0D4E-4FF8-98F4-7D93F8BA4222", ModelName = "900シリーズ",
                    ManufacturerId = "0975EF88-66CE-47CC-A7F3-7FA7E4C0DC02"
                },
                new VehicleModel
                {
                    Id = "08427565-B3BB-4605-A52D-7E54388F9050", ModelName = "ブルーバードワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "87EA35B0-DD23-4B6E-BC01-7EA4E0989DC9", ModelName = "A3スポーツバックe-トロン",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "0385F27E-15EA-4A9A-AC65-7F2C46FE9ACF", ModelName = "エスケープ",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "1EB12DC0-1432-4C61-92D7-7F5CB28A0B97", ModelName = "フリード+",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "7C5E7D9F-0DD6-443D-8307-808A13284C2D", ModelName = "アルファードG",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "82F2C772-31B5-4AF1-91F9-809800145D95", ModelName = "AZワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "9F72B096-E7C6-4405-9A9B-80B28B8078EB", ModelName = "ユーノス800",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "48DC8FED-7854-4367-BCBA-80B87ECDE4CB", ModelName = "ギャランスポーツ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "7378ABCA-4A78-4C69-ABEA-80CCA6F06195", ModelName = "アルファGT",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "499BB609-2239-4CAE-984F-80E106F0D13C", ModelName = "アヴァンシア",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "85FB298E-BED0-4369-A9A4-80FE26566656", ModelName = "ギブリ",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "F27FCEBD-D23A-4B22-8D48-81005011EBBC", ModelName = "550",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "3233188B-2E20-4ECE-A570-811A4EAE0E54", ModelName = "タントエグゼ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "B53A2585-0978-411E-B954-818D864D12C1", ModelName = "ファンカーゴ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "01922E10-5D9D-4BF3-B6C8-81F1E4B8C0D3", ModelName = "208",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "D7F19A35-7E4B-41C4-9724-8210C4940D07", ModelName = "レガシィ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "DF3E4937-0B82-4C14-BC67-82228274290A", ModelName = "ファミリアアスティナ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "3ECABC40-4E81-49A1-ACA1-82AF919295EE", ModelName = "アルトワークス",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "9710ED43-90C5-4600-AC14-82E39FDC7190", ModelName = "シーマ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "A6037C7A-1E10-4D3B-B33B-8351777AC60F", ModelName = "C3 プルリエル",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "7C46A1C5-5AA9-49E7-A35E-835B2FE12A25", ModelName = "キャデラックCTSクーペ",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "66B8CD4B-3A53-45AC-8782-8361D3F5D47E", ModelName = "ウィザード",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "07FCC668-1BED-49F1-8955-83B509FDD98A", ModelName = "355F1",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "E3687258-CC0A-4C16-95FD-840795269651", ModelName = "ディアブロ",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "B1031510-DBC8-438C-AC22-840E4633FD47", ModelName = "グランドエスクード",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "F939F8D2-E1CE-4BD1-9295-843F402527C1", ModelName = "カペラカーゴ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "74C4988C-E757-4B4A-BEEA-845029A47623", ModelName = "Z3クーペ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "1F4CF53B-7564-43BA-8593-847D04F04674", ModelName = "コンチネンタル",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "7CE4D812-4CEA-4C8A-B9A3-850056BDEBE9", ModelName = "ビュイックパークアベニュー",
                    ManufacturerId = "E665180E-DA4B-45A0-95E7-21AFFF4201FB"
                },
                new VehicleModel
                {
                    Id = "01101B97-894D-472D-9C67-851CD81F893A", ModelName = "アルトターボRS",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "A4DB6868-7B47-47A6-BF99-851FA3536E56", ModelName = "VWサンタナ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "691CCBDE-A554-49EA-9955-853E66467217", ModelName = "スクラムワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "A9BBA84C-6021-487C-99D1-85D1A4420A4A", ModelName = "ニュービートルカブリオレ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "5D46FA6C-840F-465F-A50F-85F30F36FF41", ModelName = "キャラバンエルグランド",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "3CE147CE-3356-4885-96D0-85FF3ABDF959", ModelName = "クルーガーハイブリッド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B33A8E47-30C3-4C40-8E01-86057D64840B", ModelName = "キミーラ",
                    ManufacturerId = "4588CAD8-90C2-4E00-A729-F063C024722E"
                },
                new VehicleModel
                {
                    Id = "3EF0A030-7139-4940-9DF9-862487F710AC", ModelName = "ピクシスジョイ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6B43BFF5-6B82-400D-8C18-8637A8C464D6", ModelName = "サンバートライ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "5C23EDD3-3295-424D-B59E-863ABBFFE74F", ModelName = "DS3",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "8E226EFE-B362-45C1-9D2E-86799B1EF6D5", ModelName = "ポンテアックグランダム",
                    ManufacturerId = "AE937731-F027-408A-AB12-5DEB80B45C60"
                },
                new VehicleModel
                {
                    Id = "28F9FE07-A3F5-4A18-A34D-8682C5B19E59", ModelName = "Eクラスオールテレイン",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "FE5AA3A5-41C8-41E4-A451-86875E677CEE", ModelName = "718ボクスター",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "8C528B6E-E61C-403B-BF62-86BAAA2DA55D", ModelName = "セドリックワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "1A3EBB85-F60D-4058-91AB-86D6FA0FE626", ModelName = "XE",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "AD07082E-217D-491D-9D10-86E6DD3FE837", ModelName = "S5スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "5408159B-DA06-4273-B8A0-86EB07ACA155", ModelName = "190クラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "0CCA2C35-22FE-4B06-A958-8727577C1736", ModelName = "Ka",
                    ManufacturerId = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6"
                },
                new VehicleModel
                {
                    Id = "C16F877F-9572-45D8-BD6E-872DB6098676", ModelName = "イグニス",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "AD7441EC-260A-4746-BD95-87A33DA5F74E", ModelName = "XD3",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "0241AACF-88DA-416B-B184-87EA4736AA24", ModelName = "CT",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "FEF8EFB2-B046-43F8-8679-882925162E91", ModelName = "TT RSクーペ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "E3B4FC7A-BC37-4582-9F60-88403FD1E838", ModelName = "ES",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "0EF1DACE-EF09-4338-8E12-884663522A26", ModelName = "サバンナRX-7",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "EDE09822-7B58-40F0-9257-889AAE7E2C59", ModelName = "クルー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "8E77ED6A-3049-47C7-BD92-88DA4920B64B", ModelName = "アバルト595C",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "0EA97D87-4263-4DD6-86FE-897A68F65DF3", ModelName = "Eペース",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "49CB6A34-AF65-4EDB-998B-898EE4B24E4F", ModelName = "340R",
                    ManufacturerId = "D2625ADD-806B-4056-9895-F18ADB012FC3"
                },
                new VehicleModel
                {
                    Id = "1C2D8071-0D93-4377-8ABF-89C38AEB7BB6", ModelName = "フリード+ハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B6A89298-030D-4725-8B06-89D45B0D0A4C", ModelName = "N-ONE",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "5F8FD7DA-687B-48C4-A23E-89E1BD4A8326", ModelName = "ユーノス500",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "A1EFE7EC-8329-4CEB-8FFD-89E351252F5F", ModelName = "カブリオレ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "DE78DF36-F7AE-40CB-9E75-8A05A992BE6B", ModelName = "インプレッサWRX",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "31F96D3D-923F-451E-A03F-8A24C3771999", ModelName = "レンジローバーイヴォークコンバーチブル",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "690ADA37-F287-44A0-A1B8-8A3CDCFD8DAA", ModelName = "カローラフィールダー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "CAE5743A-9EC2-4A2F-8CAD-8A42E94DA4C0", ModelName = "RS5",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "0AD7C27D-A863-42CB-BBDE-8A770D126384", ModelName = "セプタークーペ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "4E39E7A1-7F9C-4D72-8808-8ABA911EF77A", ModelName = "S1スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "279DEF69-38E1-48A6-A73B-8AD5781BF32D", ModelName = "アルトハッスル",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "A13807DE-999F-4DE9-9446-8AF7E2778549", ModelName = "カローラランクス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "ED9AF51C-8DC1-49D1-A8C9-8B2B90980011", ModelName = "クサラ",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "E2B80D7B-84D8-4727-ADC4-8B35F38A31ED", ModelName = "クーペ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "140E4795-B888-4EE6-B243-8B42F585C0B9", ModelName = "パンダ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "85FF92FE-0242-436D-966F-8B661C8DB8CD", ModelName = "RS5カブリオレ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "B6057ABD-FB93-4316-A9C3-8B731A42842F", ModelName = "ミストラル",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "79C96552-369A-4B07-9890-8BAB2F25BF8B", ModelName = "86",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "AB5ED97F-19A5-4B4D-A466-8BB27B27EADE", ModelName = "セルボ・モード",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "CC28ED98-DE4E-4614-931B-8C03F4ED209A", ModelName = "ジムニー",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "9CECD79C-D4CB-4958-A2B6-8C0941ED44FB", ModelName = "コルサ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "C64E3A18-3F56-4ABE-B842-8C18C417B3AA", ModelName = "アヴァンタイム",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "3919710C-7FFC-4381-82D2-8C902C71219C", ModelName = "アルファGTV",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "DA595968-F007-4435-BAF7-8CC3154DB975", ModelName = "CLAクラス シューティングブレーク",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "02C39D8C-D4DB-4F81-ADB0-8CD153843A51", ModelName = "キャデラックXTS",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "9E048E6C-9866-43E7-93CD-8CDCA47EDF32", ModelName = "アルファ156スポーツワゴン",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "30962BE4-B292-4280-8AB4-8CE6DD66540A", ModelName = "フレアワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "8F30B923-392B-4481-9B70-8D2DA5312EE4", ModelName = "エリーゼ",
                    ManufacturerId = "D2625ADD-806B-4056-9895-F18ADB012FC3"
                },
                new VehicleModel
                {
                    Id = "A211D52A-BCE8-471A-9866-8DD3C2E2E6EC", ModelName = "アスパイア",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "26B355A9-E5F8-427C-A647-8DE9DA439EFC", ModelName = "キャデラックリムジン",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "86C67E55-2FB6-472E-AA86-8E549FE314CB", ModelName = "カローラFX",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6F3E991E-D065-4949-BA67-8E5CD16A5A94", ModelName = "プリウスPHV",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "38B32AB7-3022-4B04-91F3-8E7779A2603B", ModelName = "クライスラー・PTクルーザーカブリオ",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "8411CD49-F023-412F-8999-8E7AC0439EEE", ModelName = "モンデオ",
                    ManufacturerId = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6"
                },
                new VehicleModel
                {
                    Id = "49E17957-4250-4DE2-BC89-8E949B4A94CC", ModelName = "9-5シリーズ",
                    ManufacturerId = "0975EF88-66CE-47CC-A7F3-7FA7E4C0DC02"
                },
                new VehicleModel
                {
                    Id = "47BFA873-6411-42E4-B76A-8ED4D1A8D3DA", ModelName = "D5",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "BA1C08CE-E4C5-4385-8177-8EE9CD1CF780", ModelName = "ムーヴコンテ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "1CF0A2E0-F37C-4834-9CD5-8F08A7924902", ModelName = "アルファスポーツワゴン",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "AD6EF28D-7511-4DCF-A45A-8F92A626AF11", ModelName = "パイザー",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "B0013EB4-1E30-40AE-9DC0-903AEE09C13C", ModelName = "レンジROVER1990(平成2)年4月~2000(平成12)年7月",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "716510D1-E352-412C-AFAB-906C404C4700", ModelName = "マーキュリークーガー",
                    ManufacturerId = "5C080CDE-C53D-46BF-A01B-8DC503AD40AA"
                },
                new VehicleModel
                {
                    Id = "C6533678-C22B-4B55-8629-9103F4B013CC", ModelName = "レンジローバースポーツ",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "38996B1E-8066-4EA3-9277-9109A619BE5C", ModelName = "アンフィニMS-9",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "E8A5BE56-68AE-4CBE-821C-910BF0ABB4AA", ModelName = "458イタリア",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "4BEC9F8B-F9AC-49D3-8697-91458B29D56E", ModelName = "アバルト500",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "52B99CA5-1D17-4A19-9433-914C5A8993CF", ModelName = "シボレーS-10ブレーザー",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "446389E6-8B2A-4A2F-8995-91ACBD8B6287", ModelName = "19",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "F1A25342-F6DD-4EA4-BB79-91BC405D05F3", ModelName = "シボレーコルベット",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "F7FA09D3-1D6A-4B62-A4C5-91EC0E25EB24", ModelName = "クロノス",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "FB7E72C4-9A8A-43D3-9BBF-925A4899D91A", ModelName = "ターボ",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "80124339-5818-440F-BEE6-92A1382E51B0", ModelName = "4シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "61966E20-9650-4BBC-8D00-92DDD210734C", ModelName = "コンチェルト",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "80509804-E784-4E82-AFF6-931629A3F778", ModelName = "シボレーブレーザーシルバラード",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "0DDEFE95-7B97-436D-B6C4-932566A66FCB", ModelName = "アルファードハイブリッド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "93A6E55F-4106-437C-B356-93265FDF2AFB", ModelName = "イスト",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "3759AF3B-D70E-4C22-A675-934EA1B6F738", ModelName = "フィット",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "FF744C34-9DEF-4DDF-8988-9387605BEE6F", ModelName = "パサートヴァリアント",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "34F7900C-4D42-413D-96C7-93AB1D3B68AF", ModelName = "2008",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "40DB7FC0-2663-4327-A0C0-93C288F95D16", ModelName = "CLSクラス シューティングブレーク",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "EA08DBCC-B9BF-4A9E-B022-94AF94EAB995", ModelName = "ランドローバーディスカバリー",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "0A2CE9A2-9BBF-4BF3-BA7C-94B0426C7AE3", ModelName = "パルサー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "55E6D4E7-9486-497B-8EAC-94D8DA6FC1D9", ModelName = "オーパ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "316F7A34-FCB0-4DB8-B94C-951AE3306F07", ModelName = "ソナタ",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "7C768B2C-D4FC-475B-8312-953A84C329A4", ModelName = "ビアンテ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "AF1C5454-3BAA-44D4-A6F5-9566FCFB1AB9", ModelName = "A6アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "F6202AF9-0DFA-4506-9468-95914760E573", ModelName = "グロリア・シーマ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "9D04DC7D-FA13-458C-AFA7-95C78505207E", ModelName = "ステージア",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "3A4BB4FD-27F1-4A11-8BBC-95ECBA5C15E5", ModelName = "アンフィニMS-6",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "CCBC8E5A-2864-4310-8907-95F244BA78E2", ModelName = "エアロ8",
                    ManufacturerId = "450FD683-7A50-4E7A-8B71-7DD109689740"
                },
                new VehicleModel
                {
                    Id = "C03EAF28-6097-42B6-B0F9-9614328CD130", ModelName = "グランビア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "D9B6CF8D-E0BD-470A-A16A-965715286190", ModelName = "A6",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "5DF61CBA-5983-4531-86DA-966C3C1967CD", ModelName = "トゥアレグ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "966C4A6A-8C9B-4F57-B4C5-9677F6FCE186", ModelName = "ストラーダ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "B6A0089A-7F6E-42F7-BF2B-969D9D696A50", ModelName = "オルティアP",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "662DE7F3-3481-48A2-96AA-96B5009E055C", ModelName = "ヌエラ6-02セダン",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "79845BD7-734B-4C45-A78D-96EDFEC6308D", ModelName = "ジープ・グランドチェロキー",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "E243F883-951E-4BF6-96BA-975B3F2FBEDC", ModelName = "カペラワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "D5E86957-19BA-4D42-87A4-976B198E5D17", ModelName = "シロッコ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "336883A1-70F9-44FD-B9EB-9780715108B6", ModelName = "プリウス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "04014C3C-1C1C-4E4C-ADFB-979C253F0536", ModelName = "S6アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "B6F06C64-A2F1-4896-A0E2-97D83782A4F7", ModelName = "フィットアリア",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "FAFC0E53-F1EE-4C99-B67E-986C296BC3DA", ModelName = "キャロルエコ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "3EAE52C6-1F43-43E5-B051-9882911882B7", ModelName = "AX",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "87B7733B-FDA6-41FF-99EF-98A596EE6BB0", ModelName = "XG",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "B4F60297-6852-4A89-80E5-98EFF5831C6A", ModelName = "ファーゴフィリー",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "26BE8EED-1AAA-49B3-93D4-99514A2EE8D2", ModelName = "ティアナ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "8D68748B-4BB6-427D-95D0-995FD10D97BD", ModelName = "456",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "76A3A9E1-FDA0-40F4-95B6-99DCC0344C35", ModelName = "タウンエースワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "74834C9F-F251-484D-A5A5-9A2AEDA6E501", ModelName = "エテルナ・シグマ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "C3BCB1C0-FD4D-4DD2-93C3-9A330D71F34A", ModelName = "BX",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "E9F9C696-70FA-443C-BD11-9A56C66702C7", ModelName = "アルファ145",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "F84E3DDB-F73E-4689-BDA0-9A6E95FF0EFA", ModelName = "インサイト",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "577F70F3-3A51-4C16-AE01-9A7EADE90CAC", ModelName = "ウィッシュ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "928F717C-62EE-456F-8530-9AB50EB8BDD2", ModelName = "NSX",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "839FC9E8-9D86-4DB1-A0B5-9AD42D43FCF3", ModelName = "B12",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "E81E8EB4-7D2C-45EE-91FF-9ADB8E28E8B5", ModelName = "ポンテアックボンネビル",
                    ManufacturerId = "AE937731-F027-408A-AB12-5DEB80B45C60"
                },
                new VehicleModel
                {
                    Id = "2D2E42F3-9ABA-4AA8-ABFD-9AE2587FB2BC", ModelName = "405",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "4F704279-500B-42B3-B75B-9B25C666EBD1", ModelName = "フレアクロスオーバー",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "93426054-AE8D-4E8B-8DCE-9B59156DC649", ModelName = "ゴルフ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "4991AFD0-A6CE-4348-BC65-9B6F62316E7E", ModelName = "プレサージュ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "2DCC87F2-EBB9-4BA5-8643-9BBD0BB78249", ModelName = "e-アップ!",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "DCEEAFE9-70F3-47FB-8D63-9CADE36815B8", ModelName = "アコード",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "1C62364D-26EA-45CD-AAF6-9CC654C2981C", ModelName = "パジェロジュニア",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "2D1A096B-E07C-4A2D-87E7-9D55CA23463E", ModelName = "ユーガ",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "5A15C763-46CF-4F8B-9FC5-9D5A955001A1", ModelName = "ブレビス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "071D0DBA-39D1-4D94-B0EC-9D86B4C27B4B", ModelName = "TTロードスター",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "347C7431-CC61-4371-822E-9DA6AA790C83", ModelName = "シボレーシェビー",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "E6274BFE-3272-4C64-83D1-9DCD100EACB7", ModelName = "スマートフォーツークーペ",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "3C0729B9-1A2E-478A-BB91-9DCFB0AFCBEE", ModelName = "ハイラックススポーツピックアップ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "CCFCDA79-DDB2-49F9-B4D3-9DDDE7691677", ModelName = "ロードスターV8",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "769EC055-D531-42A0-A656-9E0B68A9EC24", ModelName = "C4",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "B0D6E258-4F60-4331-AB4C-9E13FEA2FD8D", ModelName = "B7",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "B60EAD71-220E-4F53-90DB-9E1DDCD89048", ModelName = "デュエット",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "935EEA54-8D9F-4EC6-B554-9E40134953AA", ModelName = "ミラ・モデルノ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "D0ED8A67-DD20-47A7-9EF6-9E5498106238", ModelName = "マーキュリーグランド・マーキー",
                    ManufacturerId = "5C080CDE-C53D-46BF-A01B-8DC503AD40AA"
                },
                new VehicleModel
                {
                    Id = "A138835C-F3A8-44B3-987A-9E6E362BD48C", ModelName = "MG RV8",
                    ManufacturerId = "46DE7CC6-17D5-492E-9F77-D903F206AF4A"
                },
                new VehicleModel
                {
                    Id = "B431E524-1CFD-4882-8218-9EB5A7FA75FC", ModelName = "V50",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "BD6A0C8C-0B8A-4608-AFF8-9EC1E707B89F", ModelName = "CLSクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "ADA8A062-FE93-4000-8786-9EF4261B90F1", ModelName = "オートザムクレフ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "A61A5E36-A711-4B8F-98F9-9F71A3F90D32", ModelName = "パサートCC",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "1F545562-416E-4CFF-A6D4-9F932CBB169E", ModelName = "ラグナ",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "3A6A90B8-5E0A-43B2-B7AA-9FAC7EB28F2F", ModelName = "RS7スポーツバック パフォーマンス",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "1B3541EB-111D-4C73-9043-9FBACBAA9164", ModelName = "トッポBJワイド",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "429B7427-DDF1-49E6-9EE1-9FC649143F4E", ModelName = "ランドクルーザー70",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "F0847E25-372D-4E02-B489-9FF94A1E4F25", ModelName = "アンフィニMS-8",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "18B13C0A-4345-4743-A5C8-A04B4B169F50", ModelName = "ヴァナゴン",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "5E821A8A-F22B-4224-8DB4-A066CA2FAD9E", ModelName = "ADワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "EDC9812B-599D-4748-88FD-A07101BFA127", ModelName = "トール",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "7ABEB79A-94AF-4CB3-96C5-A0ABDA334C82", ModelName = "ティーノ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "5D27B4A1-A35D-4E7A-9197-A0CE3D112F69", ModelName = "ワゴンR",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "AB23F42E-7A83-4022-9A42-A0CF6F6CBE04", ModelName = "X4",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "7F2142BD-4193-4272-AC5F-A0EE41B01A02", ModelName = "クロスビー",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "CEF95DFC-2CD5-44B4-9A0C-A13E3D75ECF3", ModelName = "ティグアン",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "76139450-F988-4B78-A3D9-A1417F57CF87", ModelName = "カローラアクシオ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "EA6B0F0C-B11F-439A-9FC6-A18E5CD685B0", ModelName = "クロスカントリー",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "6B50F05B-7153-4C22-A8EE-A1AD7B677509", ModelName = "DS5",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "289AEE7A-718B-4D23-9758-A1BC765BF13A", ModelName = "ルキノ・ハッチ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "549FA987-220D-4650-B038-A23AAEEAE6E8", ModelName = "アプローズθ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "BE95BDB9-FB70-49CE-B2DC-A246B6C51BDB", ModelName = "フィットシャトルハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "D1C055E5-8DD6-4471-BDF0-A26359F9B179", ModelName = "クアトロポルテ",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "93CAEE4A-1F20-42FC-8B4B-A270E348FFF5", ModelName = "デイズ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "93F741ED-A929-415C-B149-A2FFF54ACC4C", ModelName = "360",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "CE7E26D1-C280-4A04-96C5-A355E2DAEAE5", ModelName = "e-ゴルフ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "6E8050EE-6648-4FE9-A916-A3569C0AA7B1", ModelName = "リンカーンナビゲーター",
                    ManufacturerId = "D31751D4-7306-4C92-90D1-58ED12ACB972"
                },
                new VehicleModel
                {
                    Id = "9D529E24-7CEF-4DD1-91EF-A395B6ADE57D", ModelName = "Vシュトラール",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "1325B897-A1EF-46AE-824C-A3C335A05EC1", ModelName = "MGF",
                    ManufacturerId = "46DE7CC6-17D5-492E-9F77-D903F206AF4A"
                },
                new VehicleModel
                {
                    Id = "64EA2314-4167-4466-9D80-A3E153A6E330", ModelName = "X5",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "217BD484-F0F9-467B-A1A9-A3E555974744", ModelName = "カリフォルニアT",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "475DBF24-B71C-40B5-8D85-A401C914DAB8", ModelName = "ディスカバリー4",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "4329CE97-ADA8-43BD-8C63-A465000CB943", ModelName = "ギャランフォルティススポーツバック",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "144B926E-FB2D-41A7-91A7-A48AE4D40CE6", ModelName = "ベルタ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "214690B6-3F12-413E-B776-A51DCF5CA971", ModelName = "エテルナ・サヴァ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "B7826F35-AEE0-4BA3-A65F-A55FF18C04F5", ModelName = "グリフィス",
                    ManufacturerId = "4588CAD8-90C2-4E00-A729-F063C024722E"
                },
                new VehicleModel
                {
                    Id = "9A1E3FC7-4D21-4B90-A36A-A59589664FA9", ModelName = "デリカD:5",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "46884AE1-315A-4DC5-8FC9-A5CFD77ADD76", ModelName = "プレリュードinx",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "92643D50-F83F-4A69-A440-A5E413C430D8", ModelName = "LX",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "39FB58B3-485C-4F2F-AF65-A5F7FFF6F567", ModelName = "フェスティバ",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "650ECD56-26DD-4823-9B45-A610294E4F2D", ModelName = "ビーゴ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "5D2E139C-D5C7-40D4-8AEB-A623BCE2DDD2", ModelName = "デルタ",
                    ManufacturerId = "7B32052D-44BE-4F29-BFEB-31ECEFBD19C8"
                },
                new VehicleModel
                {
                    Id = "B539CEE8-C360-4A20-97A0-A6464BDF605D", ModelName = "レンジローバーヴォーグ",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "DCE753E1-2B2C-407C-929B-A671D93CAB78", ModelName = "ディアマンテ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "BA87F45A-82A0-4888-9A12-A6728FEB8DA1", ModelName = "マツダスピードアクセラ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "2B48F056-1278-43D4-BFCC-A67C9CA05D76", ModelName = "508",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "CECF9DD5-2C84-41A7-A0C6-A6C18FCAA1FA", ModelName = "シボレーカマロ",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "37F2430C-A66E-49CF-8E26-A725AD991339", ModelName = "ヌエラ6-02ワゴン",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "3D20A345-41C3-49B2-8F1F-A7CE4BD158EF", ModelName = "B8",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "BC43DB50-C359-498B-A99F-A7E02F26451D", ModelName = "プレジデント",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "A7128A2F-7FFD-4455-8CA9-A821EA496328", ModelName = "C70",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "E4E809E4-4991-4320-AC30-A841A635780C", ModelName = "2シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "831710AD-3C08-4984-8086-A85279D24F96", ModelName = "トライトン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "9864A7D6-16EC-4047-AE2F-A8A20871C36B", ModelName = "コモ・ワゴン",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "8A281DF6-A821-426E-AB03-A90B40DEBD01", ModelName = "Q7",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "6897B6A5-A98D-4C18-912E-A90F0BCDBB04", ModelName = "リンカーン・マークVIII",
                    ManufacturerId = "D31751D4-7306-4C92-90D1-58ED12ACB972"
                },
                new VehicleModel
                {
                    Id = "6778EA64-146D-4F14-BAF2-A928C9277519", ModelName = "ジュリア",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "BE377DC5-525E-406C-92EE-A94D0983F5E7", ModelName = "スピードスター",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "B0F49D7D-6CD8-486C-BD06-A980DBF94929", ModelName = "ジューク",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "C9566316-46C7-42E8-9734-A9918ED73651", ModelName = "テルスターセダン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "8D6FDFC1-CD95-4F38-B385-A9B7FA6283BB", ModelName = "エスティマハイブリッド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6CBF6B56-B217-426E-9E4A-A9F99ABD7993", ModelName = "ポンテアックグランプリ",
                    ManufacturerId = "AE937731-F027-408A-AB12-5DEB80B45C60"
                },
                new VehicleModel
                {
                    Id = "74B0C674-C046-47DB-8A50-AA20A5C8AD70", ModelName = "ソリオ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "8CD897A9-0DC3-4375-A4C9-AAAB24253CD7", ModelName = "ヴィータ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "8B4CA79D-C373-4EB5-BF3F-AAE978E458AB", ModelName = "キャラ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "BACD4D23-81AC-4F7E-BC31-AB1EF25C10F6", ModelName = "S6",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "02B9398D-182C-4082-9D7C-AB2AADEA4DC3", ModelName = "デリカスペースギア",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "D7960610-2F2E-4AA9-B708-AB2EDB6A47C2", ModelName = "MPV",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "48EF616D-28F9-4D01-9BD1-AC0B468C7196", ModelName = "クライスラー・イプシロン",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "35BB7B4A-E9BA-420D-8FC2-AC252E8DFE0D", ModelName = "クレスタ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6A744646-B436-4CBD-8E30-AC415216FD45", ModelName = "6シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "29F8C622-D6E6-4EE0-895E-AC95B05050A0", ModelName = "GTO",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "0A174464-ED95-4F59-B7E6-ACCFB60CB4E5", ModelName = "eKカスタム",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "417D1CC2-51C1-4657-B29A-ACE3547AA9D7", ModelName = "バネットラルゴコーチ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "EDC1CA25-5612-4332-85C9-AD2587BB2A69", ModelName = "ウィンダム",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "D2EB09FB-1AB0-40AB-99C9-AD2A04EA31BC", ModelName = "ベリーサ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "570B3C9F-3CF2-4BE4-9ECB-AD527FE54A46", ModelName = "ピアッツァ・ネロ",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "4722860A-2370-43BE-81E7-AD6F6067E3B8", ModelName = "307",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "E8ED652E-83D4-42B1-89DB-AD7A59D36F2E", ModelName = "RX-7",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "B13A2665-47DD-42D3-9732-AD92BA7D50F0", ModelName = "カジャー",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "26CE7B15-B836-4197-B4A0-AD934DEE8AB9", ModelName = "カプチーノ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "D2FF4A99-1B62-49D8-A434-ADA26A752256", ModelName = "コロナ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "149EB042-CD5B-45DE-9CD5-ADA2A0434330", ModelName = "レガシィグランドワゴン",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "6DC3B2B8-CEEA-400B-9F0B-ADAC9F15F896", ModelName = "i3",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "9089AD48-40B7-4786-9733-ADAE3E265451", ModelName = "レンジローバーヴェラール",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "A27EF958-1EF9-4084-969D-AE386DF1CF2B", ModelName = "180SX",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "BCDE250B-53B5-4531-9627-AE6F20F90514", ModelName = "207",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "C8A4A38F-7666-47E6-A882-AE83BFE2E887", ModelName = "キャプチャー",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "FE46DA51-91A6-4366-9CD0-AEA95CADC4B2", ModelName = "ラシーン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "4DE05595-E8E4-46C0-9D64-AEB331467EB7", ModelName = "エスティマT",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "ADAF6B15-D30D-41EB-ABA8-AEC4A57F3D0D", ModelName = "3イレブン",
                    ManufacturerId = "D2625ADD-806B-4056-9895-F18ADB012FC3"
                },
                new VehicleModel
                {
                    Id = "078439D8-C672-48C1-9C46-AEF496476563", ModelName = "テラノレグラス",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "CBC3C1C3-E187-456F-B176-AF21BFFB5D85", ModelName = "ミラカスタム",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "FE87624A-CA7F-4A75-8A78-AF3C862DEC8D", ModelName = "D8スポーツ",
                    ManufacturerId = "B1A413BA-2C00-4A59-9910-66AEDECDA9E3"
                },
                new VehicleModel
                {
                    Id = "4D5B628F-00C3-45E1-9798-AF519A51BEB6", ModelName = "ウーノ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "4BFCFF36-D154-404F-BE31-AF8AB0907927", ModelName = "シビックシャトル",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "F8DDA587-21D0-44D5-AF67-B00E85893F7B", ModelName = "ファントム・ドロップヘッドクーペ",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "683DE5DD-06CF-41A3-9AC9-B016193AEEDB", ModelName = "エスクード",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "40CCE132-A578-4724-8DA6-B04D106B2E5E", ModelName = "パレット",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "C492D74B-E436-40DC-9AE4-B07BCB8C4A8A", ModelName = "マカン",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "834D07D6-B572-4FDE-AB71-B0D8E0CE406C", ModelName = "V70",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "F6E9C2B7-7118-4E6B-86D0-B0DE6AE1A3CF", ModelName = "GSi エステート",
                    ManufacturerId = "B226A88A-B460-4098-9C49-75A711B58867"
                },
                new VehicleModel
                {
                    Id = "76CA9322-6F1E-4E78-A766-B1118D7EA38D", ModelName = "サンタフェ",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "C940D3DF-1E3D-47DE-AC03-B114CF21DBD4", ModelName = "プリズマ",
                    ManufacturerId = "7B32052D-44BE-4F29-BFEB-31ECEFBD19C8"
                },
                new VehicleModel
                {
                    Id = "D571FA1A-5D24-4F8A-B6B6-B13895F6C06C", ModelName = "ツーリングハイエース",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "06F36FB8-41DB-4A7D-9288-B1715C4DC8BE", ModelName = "シャリオグランディス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "44820247-0265-4533-843F-B1E114C0E91B", ModelName = "アルティス",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "26FAC4B1-58B3-4E8F-AD41-B1F7E7639B3B", ModelName = "リーフ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "25B8532A-318F-41E6-A723-B22B39D52D4D", ModelName = "テルスターTX5",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "12657D15-7ACD-4A07-94F2-B231BCF60ACE", ModelName = "1007",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "8F2718E1-E0CF-458F-9460-B2376297F9DD", ModelName = "アクセラスポーツ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "916EAA96-D2DC-490A-BF6A-B2612C60AD8B", ModelName = "ヴェゼル",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "601AC7CE-FD2B-4722-A39F-B279093362D3", ModelName = "eKスペースカスタム",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "B88DC8CE-05A2-4E15-9870-B2AED7632515", ModelName = "e-NV200ワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "A2E8BD5D-0983-464F-A291-B2BFF1EFD1BC", ModelName = "A7スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "74942635-EF33-44E5-8E2F-B2C7B42D7BF9", ModelName = "パサートオールトラック",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "BEC0367C-51D1-42D3-8D93-B2FC9603A13C", ModelName = "3シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "C0B44310-93DE-4F74-A9CD-B41A9ECAEF1C", ModelName = "メリーバ",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "00A2DB18-5FB8-4C6C-8F85-B432256EB4C0", ModelName = "セルシオ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "A0BFC744-56EF-4C44-AD69-B45CB48CA4FC", ModelName = "A5カブリオレ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "91B296D5-0E62-4CDC-861C-B488AF0C7009", ModelName = "プリメーラUK",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "0FB14187-F769-4609-9B28-B4AF108AB112", ModelName = "アンフィニRX-7",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "5AEFD4E8-8529-447F-9CA5-B4BDA126FDC3", ModelName = "マーチBOX",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "DF58A66D-C3D1-4CCC-97D3-B4C6E1E931BF", ModelName = "インプレッサアネシス",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "18E24940-09F3-4475-896D-B52C3AACC1D8", ModelName = "カイエン",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "01284198-31FB-4CA9-84BC-B552C7F57D20", ModelName = "キャデラックアランテ",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "ADA57707-8883-4068-93CE-B567B1F2C3A7", ModelName = "NV350キャラバンワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "7679C378-1E1E-4C43-ADE4-B5739557CBF6", ModelName = "CR-Xデルソル",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "D9A6F014-FF69-47A8-94F7-B58F716DE0C5", ModelName = "セフィーロ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "F3272049-DA58-47F9-A11D-B5B1B3A035F5", ModelName = "ディオン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "18FE27C2-FB4B-4388-90F9-B5D01EA7CA24", ModelName = "スパイダー",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "35758DAB-11C6-45A4-8428-B5D831E7AF4E", ModelName = "デリカD:2",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "E2EB5283-AA4F-47EF-B5A3-B63BB0371532", ModelName = "シルフィ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "45DFEC4A-3165-4E08-B861-B67C6E0DE0E8", ModelName = "ジムニーシエラ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "DB265A87-032A-4BEE-8FD0-B6DAD318321D", ModelName = "HR-V",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "E9E2B766-E65C-460F-A1D0-B7334E39F497", ModelName = "ニュービートル",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "9FBF2939-4DF0-45D3-BF91-B78F2D33AFFE", ModelName = "ヨーロッパS",
                    ManufacturerId = "D2625ADD-806B-4056-9895-F18ADB012FC3"
                },
                new VehicleModel
                {
                    Id = "AD0939C4-CA26-464C-B03A-B82386CE03B7", ModelName = "フォレスター",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "072EB391-ED90-4BFE-94AF-B839165CDE52", ModelName = "AZワゴンカスタムスタイル",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "26E4967C-9460-432F-AD23-B89990C84EFC", ModelName = "マイクラC+C",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "606EB465-8CB4-4F5F-AA2A-B8B69C476922", ModelName = "アベンシスセダン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "0BB2F629-C1EF-4AB7-8C19-B907BBAE58A9", ModelName = "コロナプレミオ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7104A532-0B27-406A-B84A-B90D6EACE33D", ModelName = "SC",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "1F0A3918-6A96-4214-8C49-B93830D6D0D6", ModelName = "RVR",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "2ED66DF0-B8E9-4FE5-8767-B978AEFB3E37", ModelName = "プレセア",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "662D1078-A3D6-4DF6-BD01-BA76DF38DAC4", ModelName = "デリカD:3",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "36739513-6ABC-41B4-AB05-BB535C3851A4", ModelName = "アンフィニMPV",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "88BCC0A5-3FD0-42A6-966C-BB61D7898580", ModelName = "ディアマンテワゴン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "8E107333-BFD4-4ACF-8E21-BB9D21CD1726", ModelName = "ロードスタークーペ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "2D241B6B-D38F-4AB7-BCE7-BBEA62D918C4", ModelName = "100",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "A88390FA-1A54-4AD7-A81D-BC52B31557DF", ModelName = "コラード",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "06FAC0D4-3D5E-463E-B702-BC71490E328F", ModelName = "ラガー",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "3DE4FC59-645A-4BB0-BBB1-BCB058E1CBC1", ModelName = "JM",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "B20D6583-9E94-49C9-BA23-BD1CC2909E59", ModelName = "21",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "8FC85ECE-BD3C-4E95-9184-BD5427B09626", ModelName = "GLE",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "EA4BC475-7E2F-4F9C-A5A0-BD9F61D854DA", ModelName = "ウインド",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "08979410-64A6-48A0-AF06-BDC2C7289C8F", ModelName = "ユーノス100",
                    ManufacturerId = "973BFABB-07A0-4F76-8635-C77A306F4F7A"
                },
                new VehicleModel
                {
                    Id = "A281CF3F-EF75-4398-A5CF-BE0E89454B71", ModelName = "カルタスクレセント",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "687E1518-6837-475F-823F-BE3AB33284A9", ModelName = "ブルックランズ",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "48F0BFC9-EFB0-408A-8C96-BED9161F2CE9", ModelName = "アコードワゴン",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "2C36D8E8-AF23-408A-8327-BEF9C9907AEE", ModelName = "アルシオーネSVX",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "F81BC1E2-22C2-4B41-98F8-BEFE6F102A08", ModelName = "グロリアワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "5D80934A-0894-490E-BE66-BF470409713B", ModelName = "アヴェンタドール",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "06E94098-2CB2-43EB-BD80-BF545F118D29", ModelName = "ピノ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "5650E383-B077-4340-A898-BF61A2DA5ED1", ModelName = "ギャランフォルティス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "381671DB-5DD0-4EB6-8E6F-BF8996AFBF45", ModelName = "フィリー",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "102ABDE9-B4F5-4CC7-A3A7-C057ED48C1AC", ModelName = "シグマ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "7AA2E803-AC4E-4C22-A752-C07E02D81DF5", ModelName = "ロックスター",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "866D6417-09D3-48BE-9F78-C10C7753A428", ModelName = "カルタスワゴン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "FAE9C8E6-FE23-4814-9F83-C10D8E7253DB", ModelName = "Q5ハイブリッド",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "3F930715-F5EA-46BC-B388-C1C9234B1C79", ModelName = "キャデラックATS-V",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "A1E21589-179C-4501-A76D-C22C90C34FC1", ModelName = "WiLL VS",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B13E8BF3-E0DF-48C0-B1ED-C22F65BC2BA9", ModelName = "シャレード・ソシアル",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "A2E97EF9-8999-4416-9E46-C24BCDB04B48", ModelName = "スピアーノ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "6A364FA1-0BDE-4C42-A409-C25A7E250B1D", ModelName = "ヴェルファイアハイブリッド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "4B1D367E-6C81-4638-BEED-C283CE712219", ModelName = "クラウン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "655F2711-6A96-45F1-8738-C285B2AC991C", ModelName = "プレジデントJS",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "B23A7913-A220-4879-8F09-C2DE08B1138F", ModelName = "ルーテシア",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "D160A191-BD9B-4AAC-AEC3-C2E59E8026D9", ModelName = "ジャズ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "628CBD1A-F797-4FF6-9D71-C39DAB48692F", ModelName = "トッポ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "5BFEFE9F-8E14-4A47-A058-C3CBDF21F98A", ModelName = "レガシィアウトバック",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "E6818F57-1F36-4BD2-BAB1-C4870F3D943C", ModelName = "カリーナED",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "BAE02CFC-64A2-49B4-B0C2-C4A86C92904A", ModelName = "Q5",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "D68EE9F4-2E67-4E2F-9566-C4E3FBD97A14", ModelName = "ミライース",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "78C3EC55-B72A-4C4B-B875-C4FA7A696E60", ModelName = "エグザンティア",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "DB0A4CEF-E503-4BA7-8C83-C505BD6D3D2F", ModelName = "ボンゴワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "0BF55DF6-5C47-46C9-9547-C5111C2BBA47", ModelName = "ワゴンR RR",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "241439B2-694A-435E-8E31-C5402C63E4D4", ModelName = "エクシーガクロスオーバー7",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "F5307822-87DF-4DB9-BC26-C549DD864979", ModelName = "コペン",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "531ACFF1-2131-4AA6-8F48-C55FF9B1A917", ModelName = "Sクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "26386771-1164-4A85-8213-C574089EC5E6", ModelName = "ビアノ",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "DDC232B0-6B63-4914-81E8-C577E6DF8F47", ModelName = "スマートクーペ",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "64974317-6137-4BE4-92BD-C583094A1996", ModelName = "サターンSL2セダン",
                    ManufacturerId = "557AD2D9-8F4B-439D-9D0F-EC93BFD9939A"
                },
                new VehicleModel
                {
                    Id = "C1206704-0944-44A7-8AC2-C5AE90DB7745", ModelName = "フィガロ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "3488546F-4816-4196-AF10-C5F6D7AC3269", ModelName = "X6 M",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "AAAE1504-C7D9-4B61-A6B9-C6170F4F3A32", ModelName = "アバルト695 リヴァーレ",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "8681393B-D68B-411D-9D96-C6273B391FD0", ModelName = "エコスポーツ",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "0086B5A5-9601-4EE8-8F47-C69F6010CD42", ModelName = "ミラ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "38C6B552-696E-4C29-AAFD-C6A16B6636D4", ModelName = "デボネアV",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "E1DB15A9-6D8C-4740-A1FE-C6AE2C7AED3B", ModelName = "カペラC2",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "E77EAD87-3A96-4E45-B323-C6BCF71A136A", ModelName = "ホーミーエルグランド",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "D746F597-19A9-4B00-9025-C6BE06F49B1E", ModelName = "インフィニティQ45",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "E21F8BC0-C717-4F07-8DE2-C6ED80DBF126", ModelName = "エラントラユーロ",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "33613B33-D5E4-4D37-A2E1-C6F232178499", ModelName = "シルバーセラフ",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "94E61271-4AC6-4F8B-8C10-C75BA8150B62", ModelName = "スマートカブリオ",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "5F52E796-6D30-4833-BFC4-C7778EE0F31E", ModelName = "ランドクルーザー80",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "97B615A1-4440-4D93-AB8E-C79EBF511C93", ModelName = "XK",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "13CF3475-9E8C-4BCB-9776-C7B5CFD363D2", ModelName = "アスコットイノーバ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "7B012339-312B-49D5-8438-C7C66FB05167", ModelName = "206",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "67A59223-E818-4369-87CD-C7EB52B82C09", ModelName = "928",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "C989B523-6CB3-4B9E-86F0-C805EF701F3C", ModelName = "シャリオ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "89F6050D-4108-4E51-BF50-C843A071CECA", ModelName = "シルバースパーII",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "5A1A9F68-64CE-4BCE-A629-C87DEF5E813E", ModelName = "ヴェロッサ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B7B05100-5C24-4ED3-AB13-C8B32A24AF00", ModelName = "ミディアムクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "B331220F-DD0F-4BD6-A41F-C8C93E1C8E29", ModelName = "ミラージュワゴン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "9701EE4E-691B-41FE-8B2C-C8CD654604DC", ModelName = "CX-5",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "1E2DF2AF-A706-4AD7-8139-C8D7AD99758D", ModelName = "740",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "C30CA117-A3D3-40E5-8786-C91E06279258", ModelName = "ランティス",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "20187B4F-0BC4-4928-B9F6-C92055647470", ModelName = "V40",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "0E3D1F78-64A4-4B71-900F-C94EAEF86C7D", ModelName = "DB7",
                    ManufacturerId = "C35A4E7B-0E1A-4002-B648-47F537CA7BF1"
                },
                new VehicleModel
                {
                    Id = "42EAB4FF-F518-405B-989E-C99E5957D7F8", ModelName = "スーパーアメリカ",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "CABE8E20-B8D6-4AE9-BF26-C9BC9FA27662", ModelName = "A4カブリオレ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "B088F791-4649-4A72-8BD6-C9DCBFA02FB7", ModelName = "カローラスパシオ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "C3A8AF87-E43F-458D-966E-CA198D516932", ModelName = "セフィーロワゴン",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "B2154293-BCA5-4579-9FA9-CA392873169E", ModelName = "ラッシュ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "5BE26F46-BCB0-4FF2-98D7-CA4FE1BDAABB", ModelName = "S40",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "0A835C3C-D3A8-4894-96C2-CAA7EEFE98D3", ModelName = "シャンソン",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "D7A877FD-926F-4999-A8C9-CAB38AC748BD", ModelName = "キャデラックエスカレード",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "E18FF44F-60D0-4B78-8EEE-CAD0F342AAD6", ModelName = "ディスカバリースポーツ",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "DC473A93-97D6-4B57-9F1A-CAF2C6B1E9F1", ModelName = "eKスポーツ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "003CE4D7-FD79-4ED0-BBB5-CB23CEDCFE0E", ModelName = "インテグラSJ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "1E3BA744-1B55-4401-8D3E-CB278202E0BE", ModelName = "メビウス",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "9D530277-754C-4588-BFAB-CB4292137591", ModelName = "スペーシアギア",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "15006B93-94D9-4303-9F6B-CB71D420EAB7", ModelName = "ムーヴラテ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "566D85A8-A86D-4799-8050-CBA92F30B0E1", ModelName = "ガリューリムジンS50",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "005E0E0B-156A-4A52-94DC-CC24A8C86056", ModelName = "シボレーシルバラード",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "053ED3D2-EFD5-4024-92A4-CCC11C744769", ModelName = "エスティマ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "107DDAD3-714F-42B8-A980-CD1F79D5DD59", ModelName = "RC F",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "40CC727D-A92C-448E-8148-CD26C5B2F53A", ModelName = "A8",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "0ED49F7F-7ADF-4FB3-9363-CD3154BD1FF9", ModelName = "ランドクルーザー60",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "FA3C0ACF-3FBC-4214-AC15-CD3B35674B5D", ModelName = "ミラTR-XX",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "04835467-D045-4BBC-A588-CD4A440ADDCE", ModelName = "XM",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "0EDE4B08-5E06-47A2-A36C-CD57BE7DBBA4", ModelName = "ビガート",
                    ManufacturerId = "43E2EF54-A8C5-475B-B124-861D47C989C0"
                },
                new VehicleModel
                {
                    Id = "D26896B4-7D41-4B13-9915-CDBCF03CC1B2", ModelName = "ストリート",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "8DCD0223-D378-45D6-B298-CDED7DC6BE34", ModelName = "ディグニティ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "D8705103-9532-4750-BFAC-CE1306ACBFE6", ModelName = "CL",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "E6B906F5-DB14-43EC-9182-CE3A5180FE11", ModelName = "アップ!",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "968005D6-BCA8-41FF-A764-CE3E3A1D267B", ModelName = "RAV4 L",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B3F05F44-B3F5-4DB2-9096-CE5378CBF315", ModelName = "ビッグホーン",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "48F27F2D-0193-4B2D-A3D4-CE6A45BF212D", ModelName = "CLK",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "5A2F6B1A-AEB6-4C1B-9C51-CEA9FD8E78AB", ModelName = "サニー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "0375456B-9036-4D1D-A884-CEB49E58E84D", ModelName = "スプリンター",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7180AF71-846C-4C64-A4EF-CF00594F5398", ModelName = "ガリューI",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "9CA7CBE8-A4D8-4859-A269-CF5C46B26CEF", ModelName = "XC60",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "5C8317B8-30C7-4C82-92F6-CF60CB0DF2DB", ModelName = "ランディ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "F2A3A59C-7F3C-4734-BBF8-CF8BFFC394C8", ModelName = "A3セダン",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "A997FCBC-A36C-47BB-A294-CFC207223849", ModelName = "ゴーストII",
                    ManufacturerId = "C095FB9A-6616-420F-B6F7-1F9060F9F662"
                },
                new VehicleModel
                {
                    Id = "820487B9-C096-401D-A81E-CFE8EBFBFE4C", ModelName = "テリオスルキア",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "838E0F94-088F-4394-B0F3-D042A5704707", ModelName = "クライスラー・グランドボイジャー",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "69D82971-FD21-47B1-BE14-D046E609D0EB", ModelName = "ステルヴィオ",
                    ManufacturerId = "DD102D49-CFB6-46D2-A262-864413466FA6"
                },
                new VehicleModel
                {
                    Id = "1662C8B1-4557-4E1F-A7F6-D04AE19E0B07", ModelName = "レパードJ.フェリー",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "A1F7DDE4-DF58-425E-A268-D0796BA93EE2", ModelName = "タント",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "23D7DA4C-5B05-4869-B5A1-D097923D321C", ModelName = "アコードインスパイア",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "FBE2D503-E5FE-4754-9B6C-D09C341A4287", ModelName = "Vクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "9C5F7865-B932-46AA-8F40-D0DF69E90FBA", ModelName = "クエスト",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "08389DDD-A29B-4635-97C5-D130ACCAFB95", ModelName = "ファミリアビジネスワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "46F72407-9B30-427C-BFBE-D1A3F82ED2F5", ModelName = "レジェンドクーペ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "5BC5CBB6-BB86-402B-9129-D1A80CEEC48F", ModelName = "3008",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "FFCDB01B-DFAC-444E-9920-D1E68205488C", ModelName = "Fペース",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "D93689F0-4179-4404-B558-D215A4941F03", ModelName = "ポンテアックファイヤーバード",
                    ManufacturerId = "AE937731-F027-408A-AB12-5DEB80B45C60"
                },
                new VehicleModel
                {
                    Id = "D9E1E4ED-F628-4CFC-A5E1-D2205E1C5023", ModelName = "タウンエースノア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "C9A3CD72-2569-4592-B260-D25CEF782DB9", ModelName = "C-HR",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7A19C6BE-66A1-4E37-A948-D26DBA3CEC27", ModelName = "A6ハイブリッド",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "928A45CF-386A-455E-9E7F-D2731EF5821C", ModelName = "740エステート",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "FC7503A7-FBDD-49D7-9E06-D278BACDF7A7", ModelName = "ムーヴ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "6933F297-24C0-40FB-B782-D2A349DD8695", ModelName = "ハリアー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "3786370B-B89A-4B14-9379-D2F30E466C4C", ModelName = "ラウム",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "FB8AFEF0-290B-4679-962C-D318C276E68E", ModelName = "GT-R",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "C8905F1F-62E0-4B64-B81C-D31CBC709F48", ModelName = "スマートフォーツーエレクトリックドライブ",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "5C6167A9-5539-423F-9084-D326080D3097", ModelName = "ジープ・ラングラーアンリミテッド",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "0557679D-854F-4776-A89E-D3358E95A437", ModelName = "ランサーセディアワゴン",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "020DCAB7-1583-46E2-AD00-D37749AE9995", ModelName = "M4",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "E0B7FD5E-FEB8-4367-B310-D37C38094681", ModelName = "オートザムレビュー",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "E6DAEC6D-9CAD-4DA3-9B42-D37E00E0F1B1", ModelName = "アバルトグランデプント",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "A4BC9E43-9A3E-4D43-AEDD-D3B201C31E8F", ModelName = "キャデラックDTS",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "F329A746-1F23-4197-BD6D-D440CB85B042", ModelName = "ガリューコンバーチブル",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "971AAD1E-8268-4C1B-AAD7-D443F700F13C", ModelName = "レーザーセダン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "54A416DF-0BAE-4BB2-97F0-D4665C7FE454", ModelName = "ラ・セード",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "8AC491FB-AD87-4DD0-B586-D493E9780BEA", ModelName = "i30cw",
                    ManufacturerId = "65D6C514-C10C-45E1-A5B3-0E499F47128E"
                },
                new VehicleModel
                {
                    Id = "81B9E48A-FF61-4573-81E1-D495CAF7F9F5", ModelName = "アバルト695 エディツィオーネMASERATI",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "8ED158AD-BA1C-429F-BD31-D49D7B1E9F60", ModelName = "ヴォルツ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "599FA977-51CE-40A5-9360-D4C0D4201463", ModelName = "ルクラカスタム",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "3D134DD1-A100-455E-80E6-D5EE6E6C3B40", ModelName = "ハスラー",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "EBE4391F-613E-4CBB-81BE-D706A0A3A0CA", ModelName = "ピスタチオ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "F6B10FE5-D80B-46A7-B57A-D73442A2EEDB", ModelName = "シボレーソニック",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "875A4CAD-D4B5-4313-9288-D755033E3CCB", ModelName = "グランディス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "45D209E7-1368-44B0-B080-D764D3F74AD2", ModelName = "S70",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "1AD5FEC3-903A-47E7-B5BD-D7AEED2384DB", ModelName = "スペーシアカスタム",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "D98E81A6-9445-44CD-91CE-D7B0E9E7232C", ModelName = "ビークロス",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "127ABE2E-AD7A-4D3C-BAC6-D7C7EA274E22", ModelName = "Z",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "6457C84E-65AF-488D-8D78-D7CCB44AB14D", ModelName = "LFA",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "1EC3D2EA-A66A-4A5F-941C-D7ED9C1A2D59", ModelName = "キャスト",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "8D8057A2-BF8C-41AF-9417-D82738A41CC2", ModelName = "S8プラス",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "6EB27FF8-D769-4382-8646-D82FBB8573F5", ModelName = "グランドハイエース",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "7EF0889C-8145-4DD3-A3E1-D8532C8DF142", ModelName = "プロボックスワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "346D023F-C445-4615-846A-D85B376B8B5F", ModelName = "ワゴンRワイド",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "0744B3F2-2347-4BDC-A347-D8BBA3FD2518", ModelName = "エブリイ+(プラス)",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "79BC2735-9C85-4A34-B927-D908527235D1", ModelName = "4/4",
                    ManufacturerId = "450FD683-7A50-4E7A-8B71-7DD109689740"
                },
                new VehicleModel
                {
                    Id = "5346F14F-E050-4C85-AEA6-D90C403EA3F6", ModelName = "S4",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "2E1AF92A-7EE3-4B3C-9E3C-D92F84EC108E", ModelName = "Mクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "F33212F8-B68E-4FAB-8727-D95679CAC4EC", ModelName = "DS7クロスバック",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "297BC986-46C9-4B42-8C9B-D972B1E0462E", ModelName = "リンカーンMKX",
                    ManufacturerId = "D31751D4-7306-4C92-90D1-58ED12ACB972"
                },
                new VehicleModel
                {
                    Id = "E14796B5-A8E4-4FFD-88CB-D9B659D5B8B7", ModelName = "スタークラフトG-Van",
                    ManufacturerId = "E74EA75C-EF51-40E1-BD83-086805F32060"
                },
                new VehicleModel
                {
                    Id = "F78A260E-90DA-48E4-A67E-D9C4AE97713A", ModelName = "ダッジ・チャージャー",
                    ManufacturerId = "3D958555-0A1D-4463-B6B4-17F71012D660"
                },
                new VehicleModel
                {
                    Id = "576FCA0D-8B53-43DF-9B61-DA526EB53C2A", ModelName = "シャレード",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "EC0AF7E6-877A-43CA-AEE8-DA594CE3FD3C", ModelName = "ガリューII",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "F467D51E-CDAD-4835-B885-DA97570C81CD", ModelName = "タスカン",
                    ManufacturerId = "4588CAD8-90C2-4E00-A729-F063C024722E"
                },
                new VehicleModel
                {
                    Id = "22E4A536-0329-409B-9867-DAA759E9BF7B", ModelName = "テーマ",
                    ManufacturerId = "7B32052D-44BE-4F29-BFEB-31ECEFBD19C8"
                },
                new VehicleModel
                {
                    Id = "01A3ED25-C9A6-41E6-9C06-DAAB3BBF34F8", ModelName = "F355",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "BD44C392-32C8-4EF5-8A54-DB8427B0CDBC", ModelName = "ルネッサ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "9F1AB698-3D22-4376-ACE7-DB9F00863381", ModelName = "WRX S4",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "6FC37F4C-0BDF-4B93-979A-DBAA686FEC87", ModelName = "デドラ",
                    ManufacturerId = "7B32052D-44BE-4F29-BFEB-31ECEFBD19C8"
                },
                new VehicleModel
                {
                    Id = "7C8767F0-F5D3-4152-A3F1-DBDDB38D8415", ModelName = "TT RSプラスクーペ",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "9A607290-4D89-4594-B483-DC33E00E7A6F", ModelName = "5シリーズ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "90745632-4034-465F-809F-DC354909CDC0", ModelName = "スマートK",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "BF9D6A94-235A-4489-A656-DC3EE4008211", ModelName = "パルサーセリエ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "511BFB2C-15A0-42AC-92D7-DC4F6D22E142", ModelName = "セネター",
                    ManufacturerId = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39"
                },
                new VehicleModel
                {
                    Id = "15956A5F-BFF8-4C0C-92FC-DC8BA0E2BE76", ModelName = "500S",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "F10F63C2-D108-4918-A49B-DC8C98C57064", ModelName = "ブーン",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "0AB9F2A7-A21F-4DF3-948D-DCAB96CE03D1", ModelName = "CX-7",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "1CD204D7-7EBB-4151-B2A2-DCB92135903A", ModelName = "フリーランダー2",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "AB62D2E1-8CB9-4687-9B28-DD0112DE540C", ModelName = "フォルクスワーゲンCC",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "2C8BE0E6-75CB-4697-B35A-DD6BC186AE66", ModelName = "カローラツーリングワゴン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "17083BD1-91D1-4863-B89B-DDC78EAAB100", ModelName = "eKクロス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "8B89E9E8-3164-48F7-A2EC-DDDA46E407C9", ModelName = "SLRマクラーレン",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "21A205DD-9034-4E75-845B-DE1AA470E23A", ModelName = "デイズルークス",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "EF1C5A99-5CE9-4FA3-A4D4-DE204F2C8C0F", ModelName = "ウィザードアライブ",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "8B28AF71-E4DE-4AAC-94C7-DE4239955A1B", ModelName = "キューブキュービック",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "E592027D-6BF4-4634-AAF3-DE52E7406EC8", ModelName = "アルテッツァ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "5C0BE180-6A14-4F3A-B302-DE89DB22EA78", ModelName = "eKスペース",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "9C56D115-43C7-41F0-926D-DE8FC87F5E17", ModelName = "GLクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "86DDFE33-D18C-4B21-A7D8-DE913B5FA0F0", ModelName = "サクソ",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "35847292-7557-43F1-8A76-DECDDC78598A", ModelName = "ウェイク",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "4658BFB2-88CA-45BC-8C4B-DF0A7BFADD95", ModelName = "ミラアヴィ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "AF11ADA6-27F1-4628-9280-DF79467D075B", ModelName = "ザッツ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "9F818DB9-60E8-4B3E-B802-DF7FA1BAEDB9", ModelName = "SQ5",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "C6DA046B-70E8-4ADF-A125-DFA0DAFFB9AD", ModelName = "ダッジ・ナイトロ",
                    ManufacturerId = "3D958555-0A1D-4463-B6B4-17F71012D660"
                },
                new VehicleModel
                {
                    Id = "FA248BAB-CDE4-46E8-B0BF-DFA25E4BED4E", ModelName = "デックス",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "E33A98C7-7A4A-449A-B2A2-DFC0635B6E4F", ModelName = "Keiワークス",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "B6B3B4DC-B533-4008-A879-E028B7040D62", ModelName = "ドミンゴ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "B883E370-E39C-4B79-BA10-E0483CE4D6B4", ModelName = "フリーダ",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "5B2D7B3A-A599-47B2-888C-E061AFD12378", ModelName = "944",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "4A1A2630-77D0-4803-977C-E0AD2FA9E5CA", ModelName = "GLS",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "CEF89A5F-DF38-4247-8A73-E0BF2AA219A0", ModelName = "エスクァイア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "A7EC010A-323D-4AA4-BB8D-E0C7B216203A", ModelName = "アルトラパン",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "9A58328F-958B-4DC6-80B3-E0EEC24064C7", ModelName = "A1スポーツバック",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "C8487B3E-E059-4CD3-B1DC-E14F972E0FA2", ModelName = "マークIIブリット",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "F599636F-3938-4CF2-9E21-E15442A65935", ModelName = "ミニキャブ・ブラボー",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "7BF49390-7B66-43B6-A9C4-E1F8F010E5F9", ModelName = "480",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "DC16BB27-7307-4B38-BA21-E21244D81140", ModelName = "600",
                    ManufacturerId = "B226A88A-B460-4098-9C49-75A711B58867"
                },
                new VehicleModel
                {
                    Id = "2727C2A8-D537-4173-A48A-E238D5958097", ModelName = "800",
                    ManufacturerId = "B226A88A-B460-4098-9C49-75A711B58867"
                },
                new VehicleModel
                {
                    Id = "1230E1FE-D3AD-44C9-99B7-E23CAEF25EDF", ModelName = "ZT",
                    ManufacturerId = "46DE7CC6-17D5-492E-9F77-D903F206AF4A"
                },
                new VehicleModel
                {
                    Id = "66CEA990-5E63-4F37-9618-E2416BF5A35A", ModelName = "ワゴンRソリオ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "3AD6421E-252F-436A-B1FE-E24957460595", ModelName = "XC40",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "338381E5-65E6-4598-82FD-E281AC3C6BC6", ModelName = "ボンゴフレンディ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "A4B85EA5-1792-4314-AA9B-E2C2283EE8E7", ModelName = "ポルテ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "69E234C0-CEE6-422B-908E-E2D5E8AD6353", ModelName = "ノア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "C457CF0F-F131-4286-8970-E2DF2C266A3D", ModelName = "ゴルフオールトラック",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "5BFCD911-C46F-480D-8681-E31349B8A543", ModelName = "メガーヌエステート",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "3540DE94-93A9-4C0D-B33C-E321FEFA70C2", ModelName = "S8",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "62E878B2-080E-44AB-BBC8-E331CC36719C", ModelName = "オロチ",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "FA679E4D-1BC4-4DBE-A384-E3807D522246", ModelName = "205",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "CF3A90A8-84B2-4C49-AB3D-E3A4674F3D90", ModelName = "トッポBJ",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "12F959D0-2611-4DB8-8234-E3F283844C59", ModelName = "カリフォルニア30",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "32944D28-246F-46D2-8CDB-E41B231BD3B5", ModelName = "トゥインゴ",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "7663FA25-A85D-4C61-8793-E45D2805B7F7", ModelName = "IS F",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "AA2736A8-FE28-4205-8F2B-E4F4D5911CA1", ModelName = "アバルト695C リヴァーレ",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "D314F429-8B50-4926-9AEA-E4F8ED1F9931", ModelName = "B6",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "72416686-5B2F-42B6-89C2-E52BF28F2228", ModelName = "キャデラックSRXクロスオーバー",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "B8633F73-F16D-464A-B357-E54771687639", ModelName = "RX",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "B3972A3B-332B-438E-A95E-E54F2DECFFA6", ModelName = "RC",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "60882197-A7DF-48B1-BC5A-E57359D2456E", ModelName = "407",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "B52B56F1-34FB-4E40-87E4-E5A7E98EAB70", ModelName = "V60",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "93A70D6B-B5CB-4456-9C9C-E5C26B282601", ModelName = "アルナージ",
                    ManufacturerId = "DDD335EF-C0CA-4917-AF81-774FD2A7270B"
                },
                new VehicleModel
                {
                    Id = "20AE6A65-65C7-49DC-A7DB-E5CAA4D2989D", ModelName = "ガリュークラシック",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "7784C9ED-7EB8-45E9-A417-E5E955489960", ModelName = "キャデラックフリートウッド",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "665B908F-3DAF-4B29-872A-E5FCBEE708D1", ModelName = "モビリオスパイク",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "9BFD8D1C-3EA4-418C-AEE5-E61F98C750BC", ModelName = "アバルトプントエヴォ",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "CD400240-CA2A-4D8B-8329-E65831C2E5A2", ModelName = "612",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "50F3A2A8-CDEE-4F81-B28E-E6798A5568FF", ModelName = "バネットセレナ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "6E99F9DF-9FFA-411F-853F-E68F8B4602EC", ModelName = "バサラ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "9C76C3A3-E9D1-432F-9D04-E6F2D4C35CF2", ModelName = "Rクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "B51245EF-CD74-4977-9307-E6F67BADEC24", ModelName = "ラクティス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "6D0479F7-E933-46A4-81BA-E6FB00F74A45", ModelName = "キャバリエ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "FADDC556-3E3C-4A77-8E17-E7565E0F2FC8", ModelName = "アルトエコ",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "1E3ED6B9-56EE-4038-AE7E-E771FBD4A912", ModelName = "S5",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "4547B6CA-2738-41BC-A420-E798D237059C", ModelName = "アバルトプント",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "47DD7E2B-B721-46CA-A84B-E799079269D1", ModelName = "バネオ",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "97754AF7-AA0C-4BD0-BA31-E7CD61F3D4EB", ModelName = "X1",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "69C576D2-7A4E-4733-AB54-E8012D17A99E", ModelName = "レーザー",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "AC294BAD-5C0A-469B-A527-E8965F771FDD", ModelName = "マスタング",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "9C3973F0-235C-4CB3-9334-E8A283C9A21F", ModelName = "カペラCG",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "B156CB44-0469-418A-B66E-E8B1B4902CBB", ModelName = "リンカーンコンチネンタル",
                    ManufacturerId = "D31751D4-7306-4C92-90D1-58ED12ACB972"
                },
                new VehicleModel
                {
                    Id = "7269F2EB-03F0-4EFE-BE8E-E90A9568A5C5", ModelName = "アトランテック",
                    ManufacturerId = "DA89378F-9575-418A-A0A3-EB06C6249000"
                },
                new VehicleModel
                {
                    Id = "6F5C823C-509D-4F7F-9C43-E976F4AAD21B", ModelName = "テリオスキッド",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "4DFB4CD9-364B-4A19-A272-EA2C7F788969", ModelName = "レンジローバーイヴォーククーペ",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "0F526100-9123-4253-B3BE-EA393B3BC7D6", ModelName = "ZT-T",
                    ManufacturerId = "46DE7CC6-17D5-492E-9F77-D903F206AF4A"
                },
                new VehicleModel
                {
                    Id = "73B3217B-6ED4-47E9-8EAD-EA3E50A6C561", ModelName = "80アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "B913CADB-EAAB-4D47-BCBF-EA4DD79307FE", ModelName = "キャロル",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "BBE37076-8215-4EAB-8E3E-EA4F3C1CCF5F", ModelName = "アテンザスポーツ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "C79D0789-EB7A-4713-AA64-EA9ADBD2CF51", ModelName = "ガリューIII",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "83CBEFCD-7168-459F-BD79-EA9D2D83550B", ModelName = "クラリティPHEV",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "52D955B9-54E6-4C54-8189-EAAEE0B39064", ModelName = "ガヤルド・スパイダー",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "EF84D23F-FF1D-43CD-8CA6-EB5C39068244", ModelName = "キャデラックSRX",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "B096EF6B-9305-4EFF-B4EE-EB6E7A7D76BC", ModelName = "RS6アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "F126546A-7BE5-48E2-943E-EB88A443327E", ModelName = "レガシィツーリングワゴン",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "6BF67210-4604-46BD-B9CA-EBE06635ADCE", ModelName = "クラウンエステート",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "DD90A951-2F81-4C76-AFCD-EBF539983788", ModelName = "サターンSC2クーペ",
                    ManufacturerId = "557AD2D9-8F4B-439D-9D0F-EC93BFD9939A"
                },
                new VehicleModel
                {
                    Id = "B99A8620-1B4A-43CA-807F-EC12F11EF06F", ModelName = "100アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "F358ABC9-F881-4209-96AB-EC19661DED8A", ModelName = "エキシージ",
                    ManufacturerId = "D2625ADD-806B-4056-9895-F18ADB012FC3"
                },
                new VehicleModel
                {
                    Id = "E8D17A17-CB7B-4BD2-9030-EC23F31EB9E0", ModelName = "アコードハイブリッド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "160FDEB5-7B83-405B-9ACA-ECAA7871676A", ModelName = "ナディア",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "F1EC676E-69EC-499A-9551-ECE19C15372C", ModelName = "サンダーバード",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "4BD1B894-92B5-4DC0-B111-ED0EADE38422", ModelName = "MINI",
                    ManufacturerId = "1F23F337-7B28-4B8D-A816-6B9DB1FD0360"
                },
                new VehicleModel
                {
                    Id = "3FAD9B0F-C4DD-4B48-A6F4-ED18C359CD42", ModelName = "インテグラ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "D594C41D-D6A0-478F-9946-ED5408320C4E", ModelName = "RAV4 J",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "9EDE9979-7E79-4B91-A5BC-ED639BF53A1A", ModelName = "バルケッタ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "A93B90AC-FE55-4F6C-BBFA-EE07FF6CDF9C", ModelName = "TF",
                    ManufacturerId = "46DE7CC6-17D5-492E-9F77-D903F206AF4A"
                },
                new VehicleModel
                {
                    Id = "C531BAC4-1888-409D-9DFF-EE640A654E1F", ModelName = "レーザーリデアセダン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "558E8417-E875-48C3-9860-EE64B0DCC13C", ModelName = "フレアワゴンカスタムスタイル",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "3FF2D4B2-8D78-4FC6-9B93-EEAA3F7F8CA7", ModelName = "911",
                    ManufacturerId = "1A8ED648-F63A-4138-899A-D2BB23DC8E39"
                },
                new VehicleModel
                {
                    Id = "15E78D95-E529-47C6-9FFF-EEF701263AC5", ModelName = "プレオ・ネスタ",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "47A1311F-EA87-4213-8772-EF2386A1C3D0", ModelName = "エッセ",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "C30FC712-EA25-4600-9709-EF35D6F0E47F", ModelName = "ブレイド",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "2C743FAC-CDC1-417E-BAE0-EF90D0CDFA4A", ModelName = "ロッキー",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "E66E7AB6-7166-445B-BCCA-EFE15A77E54F", ModelName = "A5",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "90C0D77A-C0D9-4F98-A98B-EFF2E141BB4C", ModelName = "CX-3",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "077A24B3-4961-4F8B-A8F0-EFF583554EFF", ModelName = "ジープ・コマンダー",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "632E7400-FBBB-4CDA-B085-F01DA07C381B", ModelName = "DS3クロスバック",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "96380A04-C131-439C-B0F5-F0309C6167C0", ModelName = "ポロGTI",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "A1CAE10C-07C1-43CD-A2B2-F038B5147324", ModelName = "Z8",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "1B6FF856-3B86-497E-B017-F056AB9C3F39", ModelName = "SLK",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "4AA62E5C-081B-40C7-94BC-F06FEBA932F8", ModelName = "Mクーペ",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "2F49A94B-63FE-44FF-A927-F09835C42B04", ModelName = "エヴォーラ",
                    ManufacturerId = "D2625ADD-806B-4056-9895-F18ADB012FC3"
                },
                new VehicleModel
                {
                    Id = "831BD0A7-02E6-483C-BE31-F0A878911062", ModelName = "Cクラスステーションワゴン",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "07077C12-ED31-4387-A6C7-F0E61AC08D88", ModelName = "ヴィッツ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "799CE308-38EE-425A-BB18-F0FC336F1167", ModelName = "レジェンド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "4BC59462-1562-4AF3-8099-F106F28C517B", ModelName = "ジェイド",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "4A2A9CB1-45E0-4FF0-A272-F1553A9947E7", ModelName = "ゼスト",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "8760DB62-FC60-4AB3-B62E-F168457EB12F", ModelName = "カリーナサーフ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "329494D4-AFF6-4BA9-969C-F19967C1730F", ModelName = "エクリプス",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "1FEAA506-C708-414D-AD11-F1AD884A6756", ModelName = "クラウンマジェスタ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "5EED7992-647A-444F-8057-F1B5650BE3B6", ModelName = "コレオス",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "1412F936-9987-45A9-A7CE-F1CE72E3A073", ModelName = "N-BOX+",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "485BC10B-3981-46B6-AFD9-F2023E6B96B5", ModelName = "キューブ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "E24ADF49-8CB6-47B8-8BB1-F20BA3ED0DA5", ModelName = "グランドC4 スペースツアラー",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "40DA443D-08E0-4AFD-9210-F2182220CF1F", ModelName = "カローラセレス",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B8B65907-7F93-44DB-ABBB-F22DECE42BC3", ModelName = "レンジローバーイヴォーク",
                    ManufacturerId = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9"
                },
                new VehicleModel
                {
                    Id = "077D675C-4F8C-4B2F-B517-F24363596C40", ModelName = "ミュー",
                    ManufacturerId = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349"
                },
                new VehicleModel
                {
                    Id = "8B4C9C7A-96CB-49CF-9919-F2445B242C8E", ModelName = "ゴルフRヴァリアント",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "DB2320D8-5023-4AE4-BEC8-F2594EDBF542", ModelName = "レーザーリデアワゴン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "81011C8B-B20D-4987-B810-F2DA690AD1CE", ModelName = "240",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "7C2C56D2-1413-4F11-9DC9-F3308FA309F7", ModelName = "LC",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "9BC10DFF-C06F-4C93-8D1F-F33734EEC9F3", ModelName = "スマートロードスター",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "C9F04187-0925-4081-9976-F3466C841B42", ModelName = "ブラビッシモ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "E01CAB3E-2FD9-470F-A2FC-F3901DC85DC3", ModelName = "オデッセイプレステージ",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B678F838-AADA-40D2-B6B8-F3DFAA94EB51", ModelName = "レビュー",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "A9EA3375-2E08-4744-ADD1-F3F6510E813C", ModelName = "サフラン",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "E2EF30F4-30CF-4645-B7A3-F3FEAC299BC1", ModelName = "クライスラー・アクレイム",
                    ManufacturerId = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816"
                },
                new VehicleModel
                {
                    Id = "0DB5D295-5BEC-4A35-A1AB-F4144032AC8E", ModelName = "アウトランダー",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "E1F10940-96F0-4F23-83CB-F449DB28D4BD", ModelName = "プリウスa",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "DB5C29C1-6B4B-41EB-A694-F44FE5C43DC2", ModelName = "X2",
                    ManufacturerId = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E"
                },
                new VehicleModel
                {
                    Id = "FCE111C7-326A-44C5-8A4E-F4608ED12BA9", ModelName = "ウルス",
                    ManufacturerId = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3"
                },
                new VehicleModel
                {
                    Id = "6E82DB98-6B07-47E7-AD4F-F460B4F03622", ModelName = "2002(平成14)年9月~2013(平成25)年12月",
                    ManufacturerId = "41BB5DF9-29F2-4025-BB4E-B94EE3B60615"
                },
                new VehicleModel
                {
                    Id = "3B01F2D9-2F31-4E0F-8AC3-F4A13E93C27D", ModelName = "430スクーデリア",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "E14497EF-6B0B-4F77-9524-F4B6DF5AE8FC", ModelName = "キャデラックXT5クロスオーバー",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "B4996A92-B44D-4F78-A356-F4CA13003EF7", ModelName = "アバルト695 トリブートFERRARI",
                    ManufacturerId = "66959688-287F-4DBB-BE10-5D54DFD78F5B"
                },
                new VehicleModel
                {
                    Id = "3BF30EED-1973-4B6A-ACE2-F511B29DBCB5", ModelName = "エアトレック",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "E3FB4DD8-C4F8-48F7-92DF-F51D057F0615", ModelName = "Cクラス",
                    ManufacturerId = "FA8113E4-C57D-4A50-866F-CD97B9400696"
                },
                new VehicleModel
                {
                    Id = "216F34AB-68ED-4D24-A21E-F557911C6E4F", ModelName = "キャデラックエルドラド",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "1A21F094-A09F-4F31-925F-F57743F60E8D", ModelName = "フレア",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "2EB58CB1-3AAC-417C-B952-F5E10C607032", ModelName = "サターンSW2ワゴン",
                    ManufacturerId = "557AD2D9-8F4B-439D-9D0F-EC93BFD9939A"
                },
                new VehicleModel
                {
                    Id = "DD594AD3-2DB5-4158-9F2D-F5FBADE097E9", ModelName = "アコードツアラー",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "4013C4A9-BED4-4612-B80B-F6398EA9AAA2", ModelName = "ザ・ビートル",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "1BCF0101-2225-4AE3-B23F-F6A56CAC8FC1", ModelName = "ソアラ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "B3AC420A-D0E3-4EE1-88F9-F6C910440174", ModelName = "ゴルフトゥーラン",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "42D4ED55-57CF-4561-A351-F6E50D5F2705", ModelName = "パオ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "E4CF6885-C8D2-4791-9A93-F6F622D32B1D", ModelName = "フリード",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "5B150008-1D48-4341-9535-F7353DBF9173", ModelName = "ビート",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "015D69F0-93C5-405F-8515-F781909EC8BF", ModelName = "ランドクルーザー",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "C80AE6C6-5542-4300-B2ED-F78C2AD8182A", ModelName = "CX-8",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "AE7925A8-98FB-4BFE-8691-F818D5D9C0D7", ModelName = "ヒミコ",
                    ManufacturerId = "B61227A8-C640-480B-A3AB-C3826A401516"
                },
                new VehicleModel
                {
                    Id = "BFCAC076-3055-4546-9E7E-F85A2D91CB43", ModelName = "458スペチアーレ",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "80A493F5-3F94-4F34-B223-F87AF78C70AE", ModelName = "XJ",
                    ManufacturerId = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A"
                },
                new VehicleModel
                {
                    Id = "98E5AE29-EE9F-4AB8-9623-F8FB364936A1", ModelName = "C2",
                    ManufacturerId = "C75E9153-364D-49FC-9C66-6BFA58F98FFB"
                },
                new VehicleModel
                {
                    Id = "46502459-312F-4781-A296-F91C6F345251", ModelName = "WiLL サイファ",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "AD10CA6E-93D4-4DD9-B0B9-F9568262EF82", ModelName = "アルピーヌ",
                    ManufacturerId = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A"
                },
                new VehicleModel
                {
                    Id = "7B6FA177-FA7A-4CBD-98B8-F989B403866C", ModelName = "フェスティバミニワゴン",
                    ManufacturerId = "33C29264-B292-4852-9142-F4BC5561C3CC"
                },
                new VehicleModel
                {
                    Id = "F9C7A46A-C03E-43C8-A18E-F9A3FAD880D4", ModelName = "ルポ",
                    ManufacturerId = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E"
                },
                new VehicleModel
                {
                    Id = "A46A55EB-CDF0-4C86-A784-F9AAC41C2DB7", ModelName = "MAZDA3セダン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "C19BB831-DB7A-4BA7-B3FB-F9AFA41FA038", ModelName = "カペラ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "C7C3B285-721C-4824-838D-FA6B48D8296E", ModelName = "プント",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "657048BA-4F7F-4E04-A091-FA7ED0A66D81", ModelName = "ロードスターS",
                    ManufacturerId = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01"
                },
                new VehicleModel
                {
                    Id = "0B6F7A0F-0914-4477-B94E-FB04D0A67A34", ModelName = "シボレートレイルブレイザー",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "FBFBA9AA-60BB-466C-8D42-FB3D047559DC", ModelName = "306",
                    ManufacturerId = "8C2F5142-08DC-441B-8D22-1AACF475B1EE"
                },
                new VehicleModel
                {
                    Id = "03710D43-B0CD-4E17-88CD-FB49F003E131", ModelName = "オルティア",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "FAA55790-11DE-4E72-8318-FB671B8D0624", ModelName = "アバロン",
                    ManufacturerId = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783"
                },
                new VehicleModel
                {
                    Id = "3C32B372-5180-4C0A-B988-FB9D34D7FE26", ModelName = "シボレーブレイザー",
                    ManufacturerId = "19425355-B6C3-434C-867F-CFECF2AF5A74"
                },
                new VehicleModel
                {
                    Id = "517A3AAE-21BD-4CBC-AA4D-FBA1A038B9D3", ModelName = "トレジア",
                    ManufacturerId = "F63C4D3F-85F9-46BA-9938-504E4780525F"
                },
                new VehicleModel
                {
                    Id = "74349B73-3B34-42EB-AD54-FBDA149D6E9C", ModelName = "ジープ・コンパス",
                    ManufacturerId = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271"
                },
                new VehicleModel
                {
                    Id = "321F1FC7-1EAF-4C20-A42B-FBDDB99F0EC2", ModelName = "アスコット",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "C01EF6E3-A06C-472B-A6BE-FC2439B0E00C", ModelName = "GS F",
                    ManufacturerId = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC"
                },
                new VehicleModel
                {
                    Id = "7A0F8A6D-A0BC-4034-987E-FC6A22D13878", ModelName = "ライフダンク",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "11D7E733-F99C-4D41-B54D-FC6BC4E07F07", ModelName = "ダッジ・JC",
                    ManufacturerId = "3D958555-0A1D-4463-B6B4-17F71012D660"
                },
                new VehicleModel
                {
                    Id = "27F50265-60AB-4BE0-92AD-FC854812000D", ModelName = "グランカブリオ",
                    ManufacturerId = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E"
                },
                new VehicleModel
                {
                    Id = "4E5A6C93-5A7F-4440-B928-FCA71D143ED0", ModelName = "N-BOXカスタム",
                    ManufacturerId = "F7087EC7-9392-4626-B641-5B006B93ED29"
                },
                new VehicleModel
                {
                    Id = "B4C751FB-6870-4892-BCCF-FCAC8ED689AE", ModelName = "パレットSW",
                    ManufacturerId = "2D0D8E51-08A8-40C3-B729-25F002493322"
                },
                new VehicleModel
                {
                    Id = "586BD4AB-1CED-4F37-AB9E-FCEBE68C0F4C", ModelName = "デルタワイドワゴン",
                    ManufacturerId = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6"
                },
                new VehicleModel
                {
                    Id = "B06EBA39-1375-44D8-B23C-FD0FA678E177", ModelName = "サファリ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "D17E7EC4-CB62-4489-BEDE-FD3E32DB6DAF", ModelName = "キャデラックセビル",
                    ManufacturerId = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF"
                },
                new VehicleModel
                {
                    Id = "FB230E0F-F7CD-4C3C-9EB2-FD6EB0BF135F", ModelName = "スマートクロスブレード",
                    ManufacturerId = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F"
                },
                new VehicleModel
                {
                    Id = "A7EC3C7A-046E-48F5-94AE-FD8B50D3D2B8", ModelName = "フーガ",
                    ManufacturerId = "E456911F-2C35-43C8-A3D1-3561B774BCEF"
                },
                new VehicleModel
                {
                    Id = "38A1044E-D4BC-47CD-8912-FDCA6CE9BCB8", ModelName = "アテンザワゴン",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
                new VehicleModel
                {
                    Id = "D63635A5-BEC4-4B22-97F3-FE0C771EBD10", ModelName = "A4アバント",
                    ManufacturerId = "33E32587-A5A8-4CF9-86EE-093197C63776"
                },
                new VehicleModel
                {
                    Id = "7DBA55F0-846A-456C-92A8-FE2034834987", ModelName = "リンカーンLS",
                    ManufacturerId = "D31751D4-7306-4C92-90D1-58ED12ACB972"
                },
                new VehicleModel
                {
                    Id = "22302150-25D5-4D7B-93D3-FE217C14F5E0", ModelName = "F-150",
                    ManufacturerId = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC"
                },
                new VehicleModel
                {
                    Id = "0BFDA9DB-0258-439E-A10B-FE296A0D9A1B", ModelName = "850",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "80C1B018-70C5-46D5-92AB-FE7321D3DFEE", ModelName = "ニューバルケッタ",
                    ManufacturerId = "7C092475-3EB2-47F9-A583-0DD5576E8005"
                },
                new VehicleModel
                {
                    Id = "F0B56CA8-B88F-4B0F-9902-FE784FED6DAA", ModelName = "458スパイダー",
                    ManufacturerId = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337"
                },
                new VehicleModel
                {
                    Id = "C2B3227B-385B-4483-9BE6-FEE65F97E985", ModelName = "ランサーセディア",
                    ManufacturerId = "F9884273-31EB-4E1F-AE54-D647F4EAE72D"
                },
                new VehicleModel
                {
                    Id = "7C0D4770-4CE6-4FAB-B85E-FF20D219258A", ModelName = "940エステート",
                    ManufacturerId = "8C239C9E-93BB-41F8-8712-7C0860EE71EC"
                },
                new VehicleModel
                {
                    Id = "CD44B2AA-4AEA-4A85-B182-FF5CF8639704", ModelName = "ペルソナ",
                    ManufacturerId = "A7489A80-F142-496A-B776-5E8FBACFD8E0"
                },
            };
        }
    }
}