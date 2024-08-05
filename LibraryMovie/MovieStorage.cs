namespace LibraryMovie;

public class MovieStorage
{
    public static List<Movie> Movies { get; set; } = 
        [
            new()
            {
                Title = "Маникюр без Покрытия",
                URL = "https://s96vla.storage.yandex.net/rdisk/af37d1f7a5c2f56d2bd557fadce8ef05546ecd48c0a6c6d48ebb34c9aeedb069/66b1325f/ay6ZtcTPtWZowMWx083u0lYaW8O0xifaZ6YANekNfCTIfNcZS7YQtBJp_Aic6PzOqpJQ0gEf7_NWP7VBXJh9LA==?uid=10902123&filename=Nail_not.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=10902123&fsize=158754&hid=869f220341886e7e72f6edc9c6260b3d&media_type=image&tknv=v2&etag=558d5d50c59d0324a554e3e186407ed2&ts=61ef54eda15c0&s=db8d01d61d9b5ae54787985b1fa93292a5101c268f8b64e19c1f35e70b9bfc34&pb=U2FsdGVkX1_GMBx9Xd4i6iq_HFft881CW_boAQhiCyEk30xPHS-yF4dSuFdcdOfkOQka1b-_ly85euLV9fPOreh9EuE-x0Q-7vDFVXpscbw",
                Description = "• придание формы ногтям одноразовой пилкой\n" +
                "• снятие старого покрытия, оработка ногтя (базовое покрытие)\n" +
                "• массаж рук с кремом\n" +
                "• масло для кутикулы",
                Cost = 1000
            },
            new()
            {
                Title = "Маникюр с Покрытием Лаком",
                URL = "https://s383vlx.storage.yandex.net/rdisk/3b240c8068f7d9104fcd1ad902553bbc2533ba3ed0a60c813b3dbfff67f81b81/66b1324b/KluNZx0k6BpGShOUS9EU3y-Ad1QtcD2FbcUXxNmrZjiNvaLEuSHU9M-Kw3K-Alsbh9kI9kIoXj9ik2HLsVuNDQ==?uid=10902123&filename=Nail_Lak.png&disposition=inline&hash=&limit=0&content_type=image%2Fpng&owner_uid=10902123&fsize=489469&hid=1502541f36f3ee402f9abc3e2486362a&media_type=image&tknv=v2&etag=6ddbce4565feba0336e1e4f964aca016&ts=61ef54da8e8c0&s=9aac7798b042156274f029ebe60d381f058c13177de337b9390925acd7812384&pb=U2FsdGVkX1_RqZfXh3onKWJR1HCEn3b8-mB9unfEJ650bbiO9nhVfT6tXdlAOT1DsDvFxU2CWXHZUgRAtrGZC-zGCjkGYjjCJbbjUq0H8vk",
                Description = "• придание формы ногтям одноразовой пилкой\n" +
                "• покрытие Лаком\n" +
                "• массаж с кремом\n" +
                "• масло для кутикулы",
                Cost = 1800
            },
             new()
            {
                Title = "Маникюр с Покрытием Гелем",
                URL = "https://s195vla.storage.yandex.net/rdisk/55944c71e01b84598fdc77726e60d6b303479daf6331966750da4335ce2e46c4/66b13231/KluNZx0k6BpGShOUS9EU389oXzl_BDd4apcn0o02yu-NCNDMQV_MKj7X-zTrnQyq2M3jp-QomvuF-WkNoDxXDw==?uid=10902123&filename=Nail_GelLaK.jpeg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=10902123&fsize=140464&hid=726e0c0503f91587932303a3abc14413&media_type=image&tknv=v2&etag=d60dc05df849ae6f20ef1a707eaa00cf&ts=61ef54c1c2e40&s=8e0081247043cc66f033b45ae6209abd6b0087709493fec08e6b7f9e06952884&pb=U2FsdGVkX1-j90yFdkWed4APZmmrwJd29gXeGI2sypg_y4TXRb1dAHCWGvsR9xNylkfg1okaenXw2lxqlPHa2jM4J1x-T3QiUquU3uB8Qe8",
                Description = "• придание формы ногтям одноразовой пилкой\n" +
                "• покрытие Гелем\n" +
                "• массаж с кремом\n" +
                "• масло для кутикулы",
                Cost = 2000
            }
        ];

}
