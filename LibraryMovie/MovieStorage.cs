namespace LibraryMovie;

public class MovieStorage
{
    public static List<Movie> Movies { get; set; } = 
        [
            new()
            {
                Id = 1,
                Title = "Маникюр без Покрытия",
                URL = "https://s96vla.storage.yandex.net/rdisk/df3d4f66f71da7040768d11347dd45e86361fd1895e85b8b1119c2ff0297dac3/66b2a0f3/ay6ZtcTPtWZowMWx083u0lYaW8O0xifaZ6YANekNfCTIfNcZS7YQtBJp_Aic6PzOqpJQ0gEf7_NWP7VBXJh9LA==?uid=10902123&filename=Nail_not.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=10902123&fsize=158754&hid=869f220341886e7e72f6edc9c6260b3d&media_type=image&tknv=v2&etag=558d5d50c59d0324a554e3e186407ed2&ts=61f0b2863e2c0&s=52c28e18484268bcf36beb2818715535a0fd9ac94fc560ca96620112037f0d07&pb=U2FsdGVkX197vd2xlxhkygwa_IB-1I2c24f6dWKodOIZbRY_9b5Fz7jbkawtyfZzgQz4CJxkAafD3VhZ-4_yckz_501GvvTNtnWg_qXgblE",
                Description = "• придание формы ногтям одноразовой пилкой\n" +
                "• снятие старого покрытия, оработка ногтя (базовое покрытие)\n" +
                "• массаж рук с кремом\n" +
                "• масло для кутикулы",
                Cost = 1000
            },
            new()
            {
                Id = 2,
                Title = "Маникюр с Покрытием Лаком",
                URL = "https://s383vlx.storage.yandex.net/rdisk/42f27035722fb367c622d1567eb309957011a5a64c683cd56516f456717a57bc/66b2a118/KluNZx0k6BpGShOUS9EU3y-Ad1QtcD2FbcUXxNmrZjiNvaLEuSHU9M-Kw3K-Alsbh9kI9kIoXj9ik2HLsVuNDQ==?uid=10902123&filename=Nail_Lak.png&disposition=inline&hash=&limit=0&content_type=image%2Fpng&owner_uid=10902123&fsize=489469&hid=1502541f36f3ee402f9abc3e2486362a&media_type=image&tknv=v2&etag=6ddbce4565feba0336e1e4f964aca016&ts=61f0b2a987600&s=813c8a7b6b0438971be9252c8fe28881c83fd3cd4f1ae474ebcdb9990569958c&pb=U2FsdGVkX1-FUSm3rQqHNe4-35ARtxZvu9DK34B78oTZg5OD7Vrr2xz9attK-oFbr0ufS3XJ8UYB9pxGo1jMpJkOL72ZqIl_x-IDpZHOfUI",
                Description = "• придание формы ногтям одноразовой пилкой\n" +
                "• покрытие Лаком\n" +
                "• массаж с кремом\n" +
                "• масло для кутикулы",
                Cost = 1800
            },
             new()
            {
                Id = 3,
                Title = "Маникюр с Покрытием Гелем",
                URL = "https://s195vla.storage.yandex.net/rdisk/2d3c9554baf5710e6023cc7cdce88e4db6a0a71a5f96390989af78d460c80400/66b2a14a/KluNZx0k6BpGShOUS9EU389oXzl_BDd4apcn0o02yu-NCNDMQV_MKj7X-zTrnQyq2M3jp-QomvuF-WkNoDxXDw==?uid=10902123&filename=Nail_GelLaK.jpeg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=10902123&fsize=140464&hid=726e0c0503f91587932303a3abc14413&media_type=image&tknv=v2&etag=d60dc05df849ae6f20ef1a707eaa00cf&ts=61f0b2d936680&s=4f03457ec365d774773cdac36a2ecb93c4b21a013d239000be7944bc928436ad&pb=U2FsdGVkX1_6DjRAPTe6vbYMeQ6luERAN7c_pSCG1q9QuV65VjAKb96AbvyYC6Ph1NhnNboVNMMv4UOfHyIdv1vMxW9H71wZ9kPqVtScyJE",
                Description = "• придание формы ногтям одноразовой пилкой\n" +
                "• покрытие Гелем\n" +
                "• массаж с кремом\n" +
                "• масло для кутикулы",
                Cost = 2000
            }
        ];

}
